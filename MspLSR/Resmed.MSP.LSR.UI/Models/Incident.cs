using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Incident", Schema = "MSPNCP")]
    public partial class Incident
    {
        [Key]
        public int IncidentId { get; set; }
        [StringLength(30)]
        public string Status { get; set; }
        [StringLength(30)]
        public string IncidentNumber { get; set; }
        [StringLength(30)]
        public string WorkOrderNumber { get; set; }
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [StringLength(80)]
        public string ControlNumber { get; set; }
        [StringLength(40)]
        public string ProductCode { get; set; }
        [StringLength(150)]
        public string ProductionLine { get; set; }
        [StringLength(30)]
        public string OperationLocator { get; set; }
        public int? Quantity { get; set; }
        [StringLength(50)]
        public string ReasonCode { get; set; }
        [StringLength(50)]
        public string ErrorCode { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        public int? OrgId { get; set; }
        public bool? ReTestRequired { get; set; }
        [StringLength(30)]
        public string DispositionType { get; set; }
        public int? ErrorCount { get; set; }
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [StringLength(150)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        [StringLength(40)]
        public string IssueNumber { get; set; }
        public Guid? IncidentKey { get; set; }
        [StringLength(30)]
        public string DispositionStatus { get; set; }
    }
}
