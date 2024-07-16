using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using Sentry.Protocol;
using System.Diagnostics;

namespace Colpoapp
{
    public class UploadClient
    {

        public static void UploadFile(string filePath)
        {
            UploadFileAsync(filePath,UploadResultCallback);
        }

        public static async Task UploadFileAsync(string filePath, Action<bool> callback)
        {
            var url = "http://localhost:8081/uploadFile"; // Update with the actual URL
            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSize = fileInfo.Length; // Size in bytes
                Debug.WriteLine($"Uploading file: {filePath}, size: {fileSize}, url: {url}");
            }
            else
            {
                Debug.WriteLine($"File not found: {filePath}");
                callback(false);
            }

            try
            {
                using (var client = new HttpClient())
                using (var content = new MultipartFormDataContent())
                using (var fileStream = File.OpenRead(filePath))
                {
                    var fileContent = new StreamContent(fileStream);
                    fileContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                    {
                        Name = "\"file\"", // The name must match the name of the parameter in the Java endpoint
                        FileName = "\"" + Path.GetFileName(filePath) + "\""
                    };
                    content.Add(fileContent);

                    var response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        callback(true);
                    }
                    else
                    {
                        Debug.WriteLine($"Upload failed. Status code: {response.StatusCode} {response.ToString}");
                        callback(false);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
                callback(false);
            }
        }
    

    public static void UploadResultCallback(bool result)
    {
        if (result)
        {
                Debug.WriteLine("Upload successful.");
        }
        else
        {
                Debug.WriteLine("Upload failed.");
        }
    }

}

}
