using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ComponentSerialBlocked", Schema = "MSPWIP")]
    [Index("SerialNumber", Name = "ncu_ComponentSerialBlocked_SerialNumber", IsUnique = true)]
    public partial class ComponentSerialBlocked
    {
        [Key]
        [Column("ComponentSerialBlockedID")]
        public int ComponentSerialBlockedId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? PartCode { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Reference { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string CurrentStatus { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
    }
}
