using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("DowntimeForms", Schema = "MSPLSR")]
    public partial class DowntimeForm
    {
        [Key]
        public long AutoId { get; set; }
        public Guid? FormId { get; set; }
        public int WorkOrderNo { get; set; }
        [StringLength(50)]
        public string PartNo { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineNo { get; set; }
        [StringLength(50)]
        public string ToolNo { get; set; }
        [StringLength(50)]
        public string Cell { get; set; }
        [StringLength(50)]
        public string Product { get; set; }
        [StringLength(50)]
        public string CycleTime { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OpsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownTime { get; set; }
        [StringLength(50)]
        public string DownTimeText { get; set; }
        public TimeSpan? DownDuration { get; set; }
        [Column(TypeName = "ntext")]
        public string DownReasons { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpTime { get; set; }
        [StringLength(50)]
        public string UpTimeText { get; set; }
        [Column(TypeName = "ntext")]
        public string ActionDetails { get; set; }
        [StringLength(50)]
        public string OperatorName { get; set; }
        [StringLength(50)]
        public string TimeZoom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
