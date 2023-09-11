using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("OnHandQuantity", Schema = "MSPWIP")]
    [Index("OperationLocatorId", Name = "nc_OnHandQuantity_OperationLocatorID")]
    [Index("ProductionLineId", "OperationLocatorId", Name = "nc_OnHandQuantity_P_L_ID_OID")]
    [Index("ProductionLineId", "StationId", Name = "nc_OnHandQuantity_P_L_ID_SID")]
    [Index("StationId", Name = "nc_OnHandQuantity_StationID")]
    [Index("ComponentPartCode", "OperationLocatorId", "OrgId", "ProductionLineId", "ControlNumber", Name = "nc_OnHandQuantity_partcode_operationlocatorid_orgid_prodLineid")]
    [Index("ComponentPartCode", "StationId", "OrgId", "ProductionLineId", Name = "nc_OnHandQuantity_partcode_stationId_orgid_prodLineid")]
    public partial class OnHandQuantity
    {
        [Key]
        [Column("OnHandQuantityID")]
        public int OnHandQuantityId { get; set; }
        [Column("InventoryItemID")]
        public int InventoryItemId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [Column("OrgID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantity { get; set; }
        [Column("ProductionLineID")]
        public int ProductionLineId { get; set; }
        [Column("StationID")]
        public int? StationId { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string ControlNumber { get; set; } = null!;
        [Column("StatusID")]
        public int StatusId { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? CountryOfOrigin { get; set; }
        [Column("TransactionID")]
        public long? TransactionId { get; set; }
        public bool Updated { get; set; }
        [Column("OperationLocatorID")]
        public int? OperationLocatorId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? LotStatus { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? WorkOrderNumber { get; set; }

        [ForeignKey("ProductionLineId")]
        [InverseProperty("OnHandQuantities")]
        public virtual ProductionLine ProductionLine { get; set; } = null!;
    }
}
