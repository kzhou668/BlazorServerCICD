using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("EdhrSummary", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_EdhrSummary_WorkOrderNumber")]
    public partial class EdhrSummary
    {
        [Key]
        public int EdhrSummaryId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [Column("PrimaryReportXML")]
        [Unicode(false)]
        public string PrimaryReportXml { get; set; } = null!;
        [Column("SecondaryReportXML")]
        [Unicode(false)]
        public string SecondaryReportXml { get; set; } = null!;
        [Column("SecondarySubReportXML")]
        [Unicode(false)]
        public string SecondarySubReportXml { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? Instruction { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string VerifiedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime VerifiedOn { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
