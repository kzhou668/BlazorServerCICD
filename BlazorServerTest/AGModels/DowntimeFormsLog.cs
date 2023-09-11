using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DowntimeFormsLog", Schema = "MSPLSR")]
    public partial class DowntimeFormsLog
    {
        [Key]
        public long AutoId { get; set; }
        public long? ItemId { get; set; }
        public Guid? FormId { get; set; }
        public int? WorkOrderNo { get; set; }
        [StringLength(50)]
        public string? PartNo { get; set; }
        [StringLength(50)]
        public string? MachineNo { get; set; }
        [StringLength(50)]
        public string? ToolNo { get; set; }
        [StringLength(50)]
        public string? Site { get; set; }
        [StringLength(50)]
        public string? EquipmentNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OpsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownDate { get; set; }
        [StringLength(50)]
        public string? DownTimeText { get; set; }
        public int? DownDuration { get; set; }
        [StringLength(250)]
        public string? Reason { get; set; }
        [Column(TypeName = "ntext")]
        public string? DownReasons { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [StringLength(50)]
        public string? UpTimeText { get; set; }
        [StringLength(250)]
        public string? ActionTaken { get; set; }
        [Column(TypeName = "ntext")]
        public string? ActionDetails { get; set; }
        [StringLength(50)]
        public string? OperatorName { get; set; }
        [StringLength(50)]
        public string? TimeZoom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RestartDate { get; set; }
        [StringLength(50)]
        public string? RestartApprover { get; set; }
        public int? RejectQuantity { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(10)]
        public string? Operation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string? CreatedBy { get; set; }
    }
}
