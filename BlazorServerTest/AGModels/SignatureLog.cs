using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SignatureLog", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_SignatureLog_WorkOrderNumber")]
    public partial class SignatureLog
    {
        [Key]
        public int SignatureLogId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string LoggedUser { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime LoggedInOn { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
