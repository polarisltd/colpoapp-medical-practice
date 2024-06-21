using System;

namespace VisioForge_SDK_Video_Capture_Demo.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string IdCode { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Notes { get; set; }
    }
}
