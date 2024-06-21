using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.ComponentModel;

namespace VisioForge_SDK_Video_Capture_Demo.Models
{
    [Table(name: "IMAGE", Schema = "dbo")]
    public class CImage
    {
        public int Id { get; set; }
       
        public int VisitId { get; set; }
       
        public string ImagePath { get; set; }


        // Navigation property for related visit
        public CVisit Visit { get; set; }


    }
}
