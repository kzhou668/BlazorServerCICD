using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("EdhrSummary", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_EdhrSummary_WorkOrderNumber")]
    public partial class EdhrSummary
    {
        [Key]
        public int EdhrSummaryId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [Column("PrimaryReportXML")]
        public string PrimaryReportXml { get; set; }
        [Required]
        [Column("SecondaryReportXML")]
        public string SecondaryReportXml { get; set; }
        [Required]
        [Column("SecondarySubReportXML")]
        public string SecondarySubReportXml { get; set; }
        [StringLength(150)]
        public string Instruction { get; set; }
        [Required]
        [StringLength(150)]
        public string VerifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime VerifiedOn { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
