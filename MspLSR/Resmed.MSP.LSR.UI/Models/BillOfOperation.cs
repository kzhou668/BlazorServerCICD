using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("BillOfOperation", Schema = "MSPWIP")]
    [Index(nameof(OperationType), nameof(OperationDescription), nameof(WipworkOrderId), nameof(OperationSequenceNumber), Name = "nc_BillOfOperation_OT_OTD_WO")]
    [Index(nameof(WipworkOrderId), nameof(OperationType), nameof(OperationDescription), Name = "nc_BillOfOperation_WIPWorkOrderID_OT_OTD")]
    public partial class BillOfOperation
    {
        [Key]
        [Column("BillOfOperationID")]
        public int BillOfOperationId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        public int? OperationSequenceNumber { get; set; }
        public bool IsOperationMandatory { get; set; }
        [Required]
        [StringLength(150)]
        public string OperationType { get; set; }
        [Required]
        [StringLength(240)]
        public string OperationDescription { get; set; }
        public bool AutoTransact { get; set; }
        [Required]
        [Column("OrgID")]
        [StringLength(3)]
        public string OrgId { get; set; }
        [StringLength(10)]
        public string RoutingRevision { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.BillOfOperations))]
        public virtual WorkOrder WipworkOrder { get; set; }
    }
}
