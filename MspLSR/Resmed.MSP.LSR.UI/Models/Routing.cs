using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Routing", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), nameof(UnitIdentifier), nameof(IsStepComplete), Name = "nc_Routing_UI_WO_ISC")]
    [Index(nameof(UnitIdentifier), nameof(WorkOrderNumber), nameof(IsSequenceMandatory), nameof(IsStepComplete), Name = "nc_Routing_UI_WO_ISM_ISC")]
    [Index(nameof(WorkOrderNumber), nameof(IsSequenceMandatory), nameof(IsStepComplete), Name = "nc_Routing_WO_ISM_ISC")]
    [Index(nameof(WorkOrderNumber), nameof(RoutingStep), nameof(IsStepComplete), Name = "nc_Routing_WO_RS_ISC")]
    [Index(nameof(WorkOrderNumber), nameof(Sequence), nameof(IsCurrentStep), Name = "nc_Routing_WO_S_ICS")]
    [Index(nameof(WorkOrderNumber), nameof(UnitIdentifier), nameof(RoutingStep), nameof(IsCurrentStep), Name = "nc_Routing_WO_UI_RS_ICS")]
    [Index(nameof(WorkOrderNumber), nameof(UnitIdentifier), nameof(IsSequenceMandatory), nameof(IsStepComplete), Name = "nc_Routing_WO_UI_RS_ISM_ISC")]
    public partial class Routing
    {
        [Key]
        [Column("RoutingID")]
        public int RoutingId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string UnitIdentifier { get; set; }
        [Required]
        [StringLength(50)]
        public string RoutingStep { get; set; }
        public int Sequence { get; set; }
        public bool? IsStepComplete { get; set; }
        public bool? IsCurrentStep { get; set; }
        public bool? IsStepFail { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool? IsSequenceMandatory { get; set; }
        public bool? IsStageTest { get; set; }
        public bool? InProgress { get; set; }
        public DateTime CreateOn { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
