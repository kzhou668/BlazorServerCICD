using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("FailedLotControlledWIPIssueMessage", Schema = "MSPWIP")]
    public partial class FailedLotControlledWipissueMessage
    {
        [Key]
        [Column("FailedLotControlledWIPIssueMessageId")]
        public int FailedLotControlledWipissueMessageId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string MessageType { get; set; } = null!;
        [StringLength(8000)]
        [Unicode(false)]
        public string Message { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
