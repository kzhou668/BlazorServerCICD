using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("SignatureLog", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_SignatureLog_WorkOrderNumber")]
    public partial class SignatureLog
    {
        [Key]
        public int SignatureLogId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(150)]
        public string LoggedUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LoggedInOn { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
