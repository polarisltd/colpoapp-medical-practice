using System;
//using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

using System.Collections.Generic;

namespace VisioForge_SDK_Video_Capture_Demo.Models
{
    public enum TypeServer :byte
    {
        ServerPostgres,
        ServerSQL
    }

    // POCO class
    [Table(name: "PERSON", Schema = "dbo")]
    public class CPerson
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public float? age { get; set; }
        public string? city { get; set; }
        public float? height { get; set; }
    }

    
}
