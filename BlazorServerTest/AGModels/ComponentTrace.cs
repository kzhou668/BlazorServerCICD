using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ComponentTrace", Schema = "MSPWIP")]
    [Index("ComponentValue", "IsLotControlled", Name = "nc_ComponentTrace_CompValue_IsLotControl")]
    [Index("ComponentValue", "TraceableCompValue", Name = "nc_ComponentTrace_CompValue_TraceCompValue")]
    [Index("StationId", "OrgId", "ControlNumber", "Wipissued", "ComponentPartCode", Name = "nc_ComponentTrace_SID_OrdID_CN_WI")]
    [Index("SerialNumber", "WorkOrderNumber", "IsLotControlled", "Wipissued", Name = "nc_ComponentTrace_SN_WO_ILC_WI")]
    [Index("StationId", "Wipissued", Name = "nc_ComponentTrace_WIPIssue")]
    [Index("WorkOrderNumber", "ComponentPartCode", "ControlNumber", "OperationSequenceNumber", Name = "nc_ComponentTrace_WN_CPC_CNOSN")]
    [Index("WorkOrderNumber", "TracedOn", Name = "nc_ComponentTrace_WN_TraceOn")]
    [Index("WorkOrderNumber", "SerialNumber", Name = "nc_ComponentTrace_WONumber_SN")]
    [Index("IsLotControlled", "Wipissued", Name = "nc_ComponentTrace_isLotControled_WIPIssued")]
    [Index("WorkOrderNumber", "IsLotControlled", Name = "nc_FK_ComponentTrace_WO_ILC")]
    public partial class ComponentTrace
    {
        [Key]
        public int ComponentTraceId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(80)]
        [Unicode(false)]
        public string? ControlNumber { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? ComponentValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantity { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string TracedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime TracedOn { get; set; }
        public bool IsReplaced { get; set; }
        public bool IsLotControlled { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string? TraceableCompValue { get; set; }
        public int StationId { get; set; }
        [Column("OrgID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [Column("OperationTypeID")]
        public int OperationTypeId { get; set; }
        [Column("WIPIssued")]
        public bool Wipissued { get; set; }
        public int? OperationSequenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }

        [ForeignKey("StationId")]
        [InverseProperty("ComponentTraces")]
        public virtual Station Station { get; set; } = null!;
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
