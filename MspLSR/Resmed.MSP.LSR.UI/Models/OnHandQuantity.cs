using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("OnHandQuantity", Schema = "MSPWIP")]
    [Index(nameof(OperationLocatorId), Name = "nc_OnHandQuantity_OperationLocatorID")]
    [Index(nameof(ProductionLineId), nameof(OperationLocatorId), Name = "nc_OnHandQuantity_P_L_ID_OID")]
    [Index(nameof(ProductionLineId), nameof(StationId), Name = "nc_OnHandQuantity_P_L_ID_SID")]
    [Index(nameof(StationId), Name = "nc_OnHandQuantity_StationID")]
    [Index(nameof(ComponentPartCode), nameof(OperationLocatorId), nameof(OrgId), nameof(ProductionLineId), nameof(ControlNumber), Name = "nc_OnHandQuantity_partcode_operationlocatorid_orgid_prodLineid")]
    [Index(nameof(ComponentPartCode), nameof(StationId), nameof(OrgId), nameof(ProductionLineId), Name = "nc_OnHandQuantity_partcode_stationId_orgid_prodLineid")]
    public partial class OnHandQuantity
    {
        [Key]
        [Column("OnHandQuantityID")]
        public int OnHandQuantityId { get; set; }
        [Column("InventoryItemID")]
        public int InventoryItemId { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [Column("OrgID")]
        [StringLength(3)]
        public string OrgId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantity { get; set; }
        [Column("ProductionLineID")]
        public int ProductionLineId { get; set; }
        [Column("StationID")]
        public int? StationId { get; set; }
        [Required]
        [StringLength(80)]
        public string ControlNumber { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }
        [StringLength(80)]
        public string CountryOfOrigin { get; set; }
        [Column("TransactionID")]
        public long? TransactionId { get; set; }
        public bool Updated { get; set; }
        [Column("OperationLocatorID")]
        public int? OperationLocatorId { get; set; }
        [StringLength(100)]
        public string LotStatus { get; set; }
        [StringLength(40)]
        public string WorkOrderNumber { get; set; }

        [ForeignKey(nameof(ProductionLineId))]
        [InverseProperty("OnHandQuantities")]
        public virtual ProductionLine ProductionLine { get; set; }
    }
}
