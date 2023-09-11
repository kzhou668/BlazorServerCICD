using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Routing", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", "UnitIdentifier", "IsStepComplete", Name = "nc_Routing_UI_WO_ISC")]
    [Index("UnitIdentifier", "WorkOrderNumber", "IsSequenceMandatory", "IsStepComplete", Name = "nc_Routing_UI_WO_ISM_ISC")]
    [Index("WorkOrderNumber", "IsSequenceMandatory", "IsStepComplete", Name = "nc_Routing_WO_ISM_ISC")]
    [Index("WorkOrderNumber", "RoutingStep", "IsStepComplete", Name = "nc_Routing_WO_RS_ISC")]
    [Index("WorkOrderNumber", "Sequence", "IsCurrentStep", Name = "nc_Routing_WO_S_ICS")]
    [Index("WorkOrderNumber", "UnitIdentifier", "RoutingStep", "IsCurrentStep", Name = "nc_Routing_WO_UI_RS_ICS")]
    [Index("WorkOrderNumber", "UnitIdentifier", "IsSequenceMandatory", "IsStepComplete", Name = "nc_Routing_WO_UI_RS_ISM_ISC")]
    public partial class Routing
    {
        [Key]
        [Column("RoutingID")]
        public int RoutingId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string UnitIdentifier { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string RoutingStep { get; set; } = null!;
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
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
