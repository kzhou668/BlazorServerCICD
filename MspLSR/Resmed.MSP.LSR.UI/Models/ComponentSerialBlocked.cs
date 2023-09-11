using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ComponentSerialBlocked", Schema = "MSPWIP")]
    [Index(nameof(SerialNumber), Name = "ncu_ComponentSerialBlocked_SerialNumber", IsUnique = true)]
    public partial class ComponentSerialBlocked
    {
        [Key]
        [Column("ComponentSerialBlockedID")]
        public int ComponentSerialBlockedId { get; set; }
        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }
        [StringLength(30)]
        public string PartCode { get; set; }
        [Required]
        [StringLength(200)]
        public string Reference { get; set; }
        [Required]
        [StringLength(20)]
        public string CurrentStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
    }
}
