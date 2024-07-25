using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public static class ConfigurationHelper
    {
      
        
    /*
   {
   "ConnectionString": "Server=localhost;Database=tempDB;Uid=<dbUserName>;Pwd=<dbPassword>",
   "Smtp": {
     "Host": "smtp.gmail.com",
     "From": "Your Name"
   }
  }
           

        IConfigurationRoot configuration = GetConfiguration()
        string connectionString = configuration.GetConnectionString("ConnectionString");
        string smtpHost = configuration.GetSection("Smtp:Host").Value;
        */
        public static IConfiguration GetConfiguration()
        {
           
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var configuration = new ConfigurationBuilder()
       .SetBasePath(path)
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .Build();

        return configuration;

        }
    }
}
