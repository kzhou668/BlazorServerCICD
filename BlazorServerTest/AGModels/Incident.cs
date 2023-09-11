using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Incident", Schema = "MSPNCP")]
    [Index("WorkOrderNumber", "SerialNumber", "Status", Name = "nc_Incident_WO_SN_S")]
    public partial class Incident
    {
        [Key]
        public int IncidentId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Status { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? IncidentNumber { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? WorkOrderNumber { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? SerialNumber { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? ControlNumber { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? ProductCode { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? ProductionLine { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? OperationLocator { get; set; }
        public int? Quantity { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ReasonCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ErrorCode { get; set; }
        [StringLength(2000)]
        [Unicode(false)]
        public string? Description { get; set; }
        public int? OrgId { get; set; }
        public bool? ReTestRequired { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? DispositionType { get; set; }
        public int? ErrorCount { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? IssueNumber { get; set; }
        public Guid? IncidentKey { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? DispositionStatus { get; set; }
    }
}
