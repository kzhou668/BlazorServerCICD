using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("WorkOrder", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "UK_WorkOrder_WorkOrderNumber", IsUnique = true)]
    [Index("WipworkOrderId", "ProductCode", Name = "nc_WIPWorkOrderID_ProductCode")]
    [Index("WorkOrderNumber", "WipworkOrderId", "WorkOrderId", "Wostatus", "ManufacturingSystem", "ProductCode", "OrganisationId", "Cestatus", "WorkOrderQty", "Wotype", "Wodescription", Name = "nc_WIPWorkOrderID_WON_WOID_WOS_MS_PC_OID_CES")]
    [Index("WorkOrderNumber", "Wostatus", "ManufacturingSystem", Name = "nc_WN_Status_MS")]
    [Index("ProductCode", Name = "nc_WorkOrder_ProductCode")]
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            AreaClearances = new HashSet<AreaClearance>();
            AreaStationClearances = new HashSet<AreaStationClearance>();
            BillOfOperations = new HashSet<BillOfOperation>();
            BomlabelPrintRecords = new HashSet<BomlabelPrintRecord>();
            Bomparts = new HashSet<Bompart>();
            CompletedUnits = new HashSet<CompletedUnit>();
            ComponentTraceSubAssies = new HashSet<ComponentTraceSubAssy>();
            ComponentTraces = new HashSet<ComponentTrace>();
            DashboardActions = new HashSet<DashboardAction>();
            EdhrSummaries = new HashSet<EdhrSummary>();
            Events = new HashSet<Event>();
            FailedLotControlledWipissueMessages = new HashSet<FailedLotControlledWipissueMessage>();
            InProcessDataOverrides = new HashSet<InProcessDataOverride>();
            Ncds = new HashSet<Ncd>();
            NonStdCompletedDevices = new HashSet<NonStdCompletedDevice>();
            Pallets = new HashSet<Pallet>();
            PreviewLabels = new HashSet<PreviewLabel>();
            ProductCategorySets = new HashSet<ProductCategorySet>();
            ReservedParentSerials = new HashSet<ReservedParentSerial>();
            Routings = new HashSet<Routing>();
            ScrappedDevices = new HashSet<ScrappedDevice>();
            SerialGenerations = new HashSet<SerialGeneration>();
            SerialisedUnits = new HashSet<SerialisedUnit>();
            Shippers = new HashSet<Shipper>();
            SignatureLogs = new HashSet<SignatureLog>();
            StationClearances = new HashSet<StationClearance>();
            Tdps = new HashSet<Tdp>();
            TestCompletedDevices = new HashSet<TestCompletedDevice>();
            UnitChecks = new HashSet<UnitCheck>();
            WorkOrderAttachments = new HashSet<WorkOrderAttachment>();
            WorkOrderAttributes = new HashSet<WorkOrderAttribute>();
            WorkOrderComments = new HashSet<WorkOrderComment>();
            WorkOrderXmls = new HashSet<WorkOrderXml>();
        }

        [Key]
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? ProductCode { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [Column("WorkOrderID")]
        [StringLength(20)]
        [Unicode(false)]
        public string? WorkOrderId { get; set; }
        [Column("OrganisationID")]
        [StringLength(20)]
        [Unicode(false)]
        public string? OrganisationId { get; set; }
        [Column("CEStatus")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Cestatus { get; set; }
        [Column("WOStatus")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Wostatus { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? ProductStatus { get; set; }
        public int? WorkOrderQty { get; set; }
        [Column("WOType")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Wotype { get; set; }
        [Column("WODescription")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Wodescription { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string? ProductDescription { get; set; }
        [Column("BOMRevision")]
        [StringLength(3)]
        [Unicode(false)]
        public string? Bomrevision { get; set; }
        [Column("TDPNumber")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Tdpnumber { get; set; }
        public bool? IsLotControlled { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? ProductionLine { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ProductionLineDescription { get; set; }
        public int? SerialControl { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string? StockBackQuantity { get; set; }
        public bool? CanMoveStage { get; set; }
        [Column("WOReleaseDate")]
        public DateTime? WoreleaseDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? LastUpdatedBy { get; set; }
        public DateTime? ExpiredDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? ManufacturingSystem { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? CompletionSubinventory { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? ProductionArea { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string? ProductionAreaDescription { get; set; }
        public DateTime? StartDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? CurrentStatus { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? EdhrFlag { get; set; }
        public int? JobType { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? JobTypeMeaning { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? SerialGenerationFlag { get; set; }

        public virtual ICollection<AreaClearance> AreaClearances { get; set; }
        public virtual ICollection<AreaStationClearance> AreaStationClearances { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<BillOfOperation> BillOfOperations { get; set; }
        public virtual ICollection<BomlabelPrintRecord> BomlabelPrintRecords { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<Bompart> Bomparts { get; set; }
        public virtual ICollection<CompletedUnit> CompletedUnits { get; set; }
        public virtual ICollection<ComponentTraceSubAssy> ComponentTraceSubAssies { get; set; }
        public virtual ICollection<ComponentTrace> ComponentTraces { get; set; }
        public virtual ICollection<DashboardAction> DashboardActions { get; set; }
        public virtual ICollection<EdhrSummary> EdhrSummaries { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<FailedLotControlledWipissueMessage> FailedLotControlledWipissueMessages { get; set; }
        public virtual ICollection<InProcessDataOverride> InProcessDataOverrides { get; set; }
        public virtual ICollection<Ncd> Ncds { get; set; }
        public virtual ICollection<NonStdCompletedDevice> NonStdCompletedDevices { get; set; }
        public virtual ICollection<Pallet> Pallets { get; set; }
        public virtual ICollection<PreviewLabel> PreviewLabels { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<ProductCategorySet> ProductCategorySets { get; set; }
        public virtual ICollection<ReservedParentSerial> ReservedParentSerials { get; set; }
        public virtual ICollection<Routing> Routings { get; set; }
        public virtual ICollection<ScrappedDevice> ScrappedDevices { get; set; }
        public virtual ICollection<SerialGeneration> SerialGenerations { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<SerialisedUnit> SerialisedUnits { get; set; }
        public virtual ICollection<Shipper> Shippers { get; set; }
        public virtual ICollection<SignatureLog> SignatureLogs { get; set; }
        public virtual ICollection<StationClearance> StationClearances { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<Tdp> Tdps { get; set; }
        public virtual ICollection<TestCompletedDevice> TestCompletedDevices { get; set; }
        public virtual ICollection<UnitCheck> UnitChecks { get; set; }
        public virtual ICollection<WorkOrderAttachment> WorkOrderAttachments { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<WorkOrderAttribute> WorkOrderAttributes { get; set; }
        public virtual ICollection<WorkOrderComment> WorkOrderComments { get; set; }
        [InverseProperty("WipworkOrder")]
        public virtual ICollection<WorkOrderXml> WorkOrderXmls { get; set; }
    }
}
