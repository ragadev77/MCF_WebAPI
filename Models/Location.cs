using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MCFWebAPI.Models
{
    [Table("ms_storage_location", Schema = "dbo")]
    public class Location
    {
        public Location() { }
        [Key]
        [Column("LocationId", TypeName = "varchar(10)")]
        public string locationId { get; set; }
        [Column("LocationName", TypeName = "varchar(100)")]
        public string locationName { get; set; }        
    }
}
