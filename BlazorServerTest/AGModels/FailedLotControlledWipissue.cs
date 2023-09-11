using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("FailedLotControlledWIPIssue", Schema = "MSPWIP")]
    public partial class FailedLotControlledWipissue
    {
        [Key]
        [Column("FailedLotControlledWIPIssueId")]
        public int FailedLotControlledWipissueId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? WorkOrderNumber { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(80)]
        [Unicode(false)]
        public string ControlNumber { get; set; } = null!;
        public int LocatorId { get; set; }
        public int OperationSequence { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantity { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string ScrapFlag { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string SubInventory { get; set; } = null!;
        public long DataVersion { get; set; }
    }
}
