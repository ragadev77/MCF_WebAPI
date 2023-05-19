using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MCFWebAPI.Models
{
    [Table("tr_bpkb", Schema = "dbo")]
    public class BPKB
    {
        public BPKB() { }
        [Key]
        [Column("agreement_number", TypeName = "varchar(100)")]
        public string agreement_number { get; set; }

        [Column("bpkb_no", TypeName = "varchar(100)")]
        public string bpkb_no { get; set; }

        [Column("bpkb_date")]
        public DateTime bpkb_date { get; set; }

        [Column("faktur_no", TypeName = "varchar(10)")]
        public string faktur_no { get; set; }

        [Column("faktur_date")]
        public DateTime faktur_date { get; set; }

        [Column("LocationId", TypeName = "varchar(10)")]
        public string? LocationId { get; set; }
        public Location? Location { get; set; }

        [Column("police_no", TypeName = "varchar(20)")]
        public string police_no { get; set; }

        [Column("bpkb_date_in")]
        public DateTime bpkb_date_in { get; set; }

    }
}
