using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("FailedLotControlledWIPIssue", Schema = "MSPWIP")]
    public partial class FailedLotControlledWipissue
    {
        [Key]
        [Column("FailedLotControlledWIPIssueId")]
        public int FailedLotControlledWipissueId { get; set; }
        [StringLength(30)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [StringLength(80)]
        public string ControlNumber { get; set; }
        public int LocatorId { get; set; }
        public int OperationSequence { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantity { get; set; }
        [Required]
        [StringLength(1)]
        public string ScrapFlag { get; set; }
        [Required]
        [StringLength(10)]
        public string SubInventory { get; set; }
        public long DataVersion { get; set; }
    }
}
