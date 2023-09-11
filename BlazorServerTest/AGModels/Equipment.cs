using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Equipment", Schema = "MSPLSR")]
    public partial class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        [StringLength(50)]
        public string? CellNo { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string EquipmentNo { get; set; } = null!;
        [StringLength(400)]
        public string? EquipmentDesc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
    }
}
