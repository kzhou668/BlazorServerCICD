using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DownTime", Schema = "MSPLSR")]
    public partial class DownTime
    {
        [Key]
        public int DownTimeId { get; set; }
        [StringLength(50)]
        public string? Operator { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [Column("OrganisationID")]
        [StringLength(5)]
        [Unicode(false)]
        public string? OrganisationId { get; set; }
        [StringLength(50)]
        public string PartNo { get; set; } = null!;
        [StringLength(50)]
        public string CellNo { get; set; } = null!;
        [StringLength(50)]
        public string? ToolNo { get; set; }
        [StringLength(250)]
        public string? SubTools { get; set; }
        [StringLength(50)]
        public string Site { get; set; } = null!;
        [StringLength(50)]
        public string? EquipmentNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownTimeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownTimeStartUtc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownTimeEnd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownTimeEndUtc { get; set; }
        public int? DownDuration { get; set; }
        public int? TroubleShootingRejects { get; set; }
        [StringLength(250)]
        public string? Reason { get; set; }
        [StringLength(2000)]
        public string? DownReason { get; set; }
        [StringLength(250)]
        public string? Action { get; set; }
        [StringLength(2000)]
        public string? ActionDetail { get; set; }
        [StringLength(50)]
        public string? ActionTakenBy { get; set; }
        [StringLength(50)]
        public string? ApprovedBy { get; set; }
        public bool? IsDeleted { get; set; }
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
