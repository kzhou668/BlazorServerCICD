using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("FailedLotControlledWIPIssueMessage", Schema = "MSPWIP")]
    public partial class FailedLotControlledWipissueMessage
    {
        [Key]
        [Column("FailedLotControlledWIPIssueMessageId")]
        public int FailedLotControlledWipissueMessageId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string MessageType { get; set; }
        [Required]
        [StringLength(8000)]
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
