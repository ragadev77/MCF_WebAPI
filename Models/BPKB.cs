using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MCFWebAPI.Models
{
    [Table("tr_bpkb", Schema = "dbo")]
    public class BPKB
    {
        public BPKB() { }
        [Key]
        [Column("agreement_number", TypeName = "varchar(100)")]
        [DisplayName("Agreement Number")]
        public string agreement_number { get; set; }

        [Column("bpkb_no", TypeName = "varchar(100)")]
        [DisplayName("No. BPKB")]
        public string bpkb_no { get; set; }
        
        [Column("bpkb_date")]
        [DisplayName("Tanggal BPKB")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime bpkb_date { get; set; }

        [Column("faktur_no", TypeName = "varchar(10)")]
        [DisplayName("No. Faktur")]
        public string faktur_no { get; set; }

        [Column("faktur_date")]
        [DisplayName("Tanggal Faktur")]
        public DateTime faktur_date { get; set; }

        [Column("LocationId", TypeName = "varchar(10)")]
        [DisplayName("Lokasi Penyimpanan")]
        public string? LocationId { get; set; }
        public Location? Location { get; set; }

        [Column("police_no", TypeName = "varchar(20)")]
        [DisplayName("No. Polisi")]
        public string police_no { get; set; }

        [Column("bpkb_date_in")]
        [DisplayName("Tanggal. BPKB in")]
        public DateTime bpkb_date_in { get; set; }

    }
}
