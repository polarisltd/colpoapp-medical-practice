using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace VisioForge_SDK_Video_Capture_Demo.Models
{
    [Table("VISIT")]
    public class CVisit
    {
        public int Id { get; set; }
        
        public int? PatientId { get; set; }

        public string? IzmeklejumaNr { get; set; }
        //public DateTime? IzmeklejumaDatums { get; set; }
        // DateTime dateOnly = visit.IzmeklejumaDatums.Date;
        private DateTime? _izmeklejumaDatums;
        public DateTime? IzmeklejumaDatums
        {
            get { return _izmeklejumaDatums; }
            set
            {
                _izmeklejumaDatums = value.HasValue ? DateTime.SpecifyKind(value.Value, DateTimeKind.Utc) : null;
            }
        }
        public bool? VizitePirmreizejaAtkartota { get; set; }
        public string? VizitesAtkartojums { get; set; }
        public string? SkriningaNr { get; set; }
        public string? Anamneze { get; set; }
        public string? IepriekshVeiktaTerapija { get; set; }
        public bool? Alergijas { get; set; }
        public string? TrnsformacijasZonasTips { get; set; }
        public bool? p1 { get; set; }
        public bool? p2 { get; set; }
        public bool? p3 { get; set; }
        public bool? p4 { get; set; }
        public bool? p5 { get; set; }
        public bool? m1 { get; set; }
        public bool? m2 { get; set; }
        public bool? m3 { get; set; }
        public string? Rezultati { get; set; }
        public string? Sledziens { get; set; }
        //public DateTime? NakosaKolposkopijasKontrole { get; set; }

        private DateTime? _NakosaKolposkopijasKontrole;
        public DateTime? NakosaKolposkopijasKontrole
        {
            get { return _NakosaKolposkopijasKontrole; }
            set
            {
                _NakosaKolposkopijasKontrole = value.HasValue ? DateTime.SpecifyKind(value.Value, DateTimeKind.Utc) : null;
            }
        }

        public ICollection<CImage> Images { get; set; }



    }
}
