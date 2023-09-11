using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("MachineConfig", Schema = "MSPLSR")]
    public partial class MachineConfig
    {
        [Key]
        public int MachineConfigId { get; set; }
        [Column("MachineID")]
        [StringLength(40)]
        public string? MachineId { get; set; }
        [StringLength(40)]
        public string? EquipmentNo { get; set; }
        [StringLength(40)]
        public string? TooNo { get; set; }
        public int? InsertQty { get; set; }
        [StringLength(40)]
        public string? InsertNo { get; set; }
        [StringLength(40)]
        public string? ProductCode { get; set; }
        [StringLength(255)]
        public string? ProductDesc { get; set; }
        [StringLength(10)]
        public string? ApprovalStatus { get; set; }
        [StringLength(100)]
        public string? MachineType { get; set; }
        [StringLength(40)]
        public string? Site { get; set; }
        public bool? IsActive { get; set; }
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
