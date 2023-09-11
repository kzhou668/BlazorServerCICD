using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ComponentTraceSubAssy", Schema = "MSPWIP")]
    [Index(nameof(ComponentValue), nameof(IsLotControlled), Name = "nc_ComponentTraceSubAssy_CompValue_IsLotControl")]
    [Index(nameof(ComponentValue), nameof(TraceableCompValue), Name = "nc_ComponentTraceSubAssy_CompValue_TraceCompValue")]
    [Index(nameof(ComponentValue), Name = "nc_ComponentTraceSubAssy_ComponentValue")]
    [Index(nameof(SerialNumber), nameof(WorkOrderNumber), Name = "nc_ComponentTrace_SN_WO")]
    [Index(nameof(WorkOrderNumber), nameof(IsLotControlled), Name = "nc_FK_ComponentTraceSubAssy_WO_ILC")]
    [Index(nameof(WorkOrderNumber), Name = "nc_FK_ComponentTraceSubAssy_WorkOrder")]
    public partial class ComponentTraceSubAssy
    {
        [Key]
        public int ComponentTraceId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string SerialNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [StringLength(80)]
        public string ControlNumber { get; set; }
        [StringLength(80)]
        public string ComponentValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantity { get; set; }
        [Required]
        [StringLength(80)]
        public string TracedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TracedOn { get; set; }
        public bool IsReplaced { get; set; }
        public bool IsLotControlled { get; set; }
        [StringLength(3)]
        public string TraceableCompValue { get; set; }
        public int StationId { get; set; }
        [Required]
        [Column("OrgID")]
        [StringLength(3)]
        public string OrgId { get; set; }
        [Column("OperationTypeID")]
        public int OperationTypeId { get; set; }
        [Column("WIPIssued")]
        public bool Wipissued { get; set; }
        public int? OperationSequenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }

        [ForeignKey(nameof(StationId))]
        [InverseProperty("ComponentTraceSubAssies")]
        public virtual Station Station { get; set; }
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
