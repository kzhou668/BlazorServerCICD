using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("BillOfOperation", Schema = "MSPWIP")]
    [Index("OperationType", "OperationDescription", "WipworkOrderId", "OperationSequenceNumber", Name = "nc_BillOfOperation_OT_OTD_WO")]
    [Index("WipworkOrderId", "OperationType", "OperationDescription", Name = "nc_BillOfOperation_WIPWorkOrderID_OT_OTD")]
    public partial class BillOfOperation
    {
        [Key]
        [Column("BillOfOperationID")]
        public int BillOfOperationId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        public int? OperationSequenceNumber { get; set; }
        public bool IsOperationMandatory { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string OperationType { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string OperationDescription { get; set; } = null!;
        public bool AutoTransact { get; set; }
        [Column("OrgID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string? RoutingRevision { get; set; }

        [ForeignKey("WipworkOrderId")]
        [InverseProperty("BillOfOperations")]
        public virtual WorkOrder WipworkOrder { get; set; } = null!;
    }
}
