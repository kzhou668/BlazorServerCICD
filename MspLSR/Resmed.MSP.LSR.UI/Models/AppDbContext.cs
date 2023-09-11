using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<AreaClearance> AreaClearances { get; set; }
        public virtual DbSet<AreaStationClearance> AreaStationClearances { get; set; }
        public virtual DbSet<BillOfOperation> BillOfOperations { get; set; }
        public virtual DbSet<BomlabelPrintRecord> BomlabelPrintRecords { get; set; }
        public virtual DbSet<Bompart> Bomparts { get; set; }
        public virtual DbSet<BompartsAttribute> BompartsAttributes { get; set; }
        public virtual DbSet<CloseShortReason> CloseShortReasons { get; set; }
        public virtual DbSet<CompletedUnit> CompletedUnits { get; set; }
        public virtual DbSet<CompletedUnitsView> CompletedUnitsViews { get; set; }
        public virtual DbSet<ComponentSerialBlocked> ComponentSerialBlockeds { get; set; }
        public virtual DbSet<ComponentTrace> ComponentTraces { get; set; }
        public virtual DbSet<ComponentTraceSubAssy> ComponentTraceSubAssies { get; set; }
        public virtual DbSet<DashboardAction> DashboardActions { get; set; }
        public virtual DbSet<DeviceError> DeviceErrors { get; set; }
        public virtual DbSet<Dfct> Dfcts { get; set; }
        public virtual DbSet<DfctCategory> DfctCategories { get; set; }
        public virtual DbSet<DfctLink> DfctLinks { get; set; }
        public virtual DbSet<DfctLinkHistory> DfctLinkHistories { get; set; }
        public virtual DbSet<DfctResult> DfctResults { get; set; }
        public virtual DbSet<DfctResultDatum> DfctResultData { get; set; }
        public virtual DbSet<DfctSpec> DfctSpecs { get; set; }
        public virtual DbSet<DfctSpecHistory> DfctSpecHistories { get; set; }
        public virtual DbSet<DfctType> DfctTypes { get; set; }
        public virtual DbSet<DowntimeForm> DowntimeForms { get; set; }
        public virtual DbSet<EdhrSummary> EdhrSummaries { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<EmailUser> EmailUsers { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventReferenceColumnType> EventReferenceColumnTypes { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<FailedLotControlledWipissue> FailedLotControlledWipissues { get; set; }
        public virtual DbSet<FailedLotControlledWipissueMessage> FailedLotControlledWipissueMessages { get; set; }
        public virtual DbSet<FglookUp> FglookUps { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<InProcessDataOverride> InProcessDataOverrides { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemValidationRule> ItemValidationRules { get; set; }
        public virtual DbSet<ItemValidationRuleHistory> ItemValidationRuleHistories { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<Ncd> Ncds { get; set; }
        public virtual DbSet<NonStdCompletedDevice> NonStdCompletedDevices { get; set; }
        public virtual DbSet<OnHandQuantity> OnHandQuantities { get; set; }
        public virtual DbSet<OperationType> OperationTypes { get; set; }
        public virtual DbSet<OracleOnHandQuantity> OracleOnHandQuantities { get; set; }
        public virtual DbSet<OracleStation> OracleStations { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OutageMsg> OutageMsgs { get; set; }
        public virtual DbSet<Pallet> Pallets { get; set; }
        public virtual DbSet<PreviewLabel> PreviewLabels { get; set; }
        public virtual DbSet<ProductCategorySet> ProductCategorySets { get; set; }
        public virtual DbSet<ProductionLine> ProductionLines { get; set; }
        public virtual DbSet<RePrintReason> RePrintReasons { get; set; }
        public virtual DbSet<ReasonCode> ReasonCodes { get; set; }
        public virtual DbSet<RegularExpression> RegularExpressions { get; set; }
        public virtual DbSet<ResLabelSpec> ResLabelSpecs { get; set; }
        public virtual DbSet<ResPrinter> ResPrinters { get; set; }
        public virtual DbSet<ReservedParentSerial> ReservedParentSerials { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleFunction> RoleFunctions { get; set; }
        public virtual DbSet<Routing> Routings { get; set; }
        public virtual DbSet<ScrappedDevice> ScrappedDevices { get; set; }
        public virtual DbSet<ScrappedDeviceView> ScrappedDeviceViews { get; set; }
        public virtual DbSet<SerialGeneration> SerialGenerations { get; set; }
        public virtual DbSet<SerialisedUnit> SerialisedUnits { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<SignatureLog> SignatureLogs { get; set; }
        public virtual DbSet<Specification> Specifications { get; set; }
        public virtual DbSet<SpecificationHistory> SpecificationHistories { get; set; }
        public virtual DbSet<SpecificationRule> SpecificationRules { get; set; }
        public virtual DbSet<SpecificationRuleExt> SpecificationRuleExts { get; set; }
        public virtual DbSet<SpecificationRuleHistory> SpecificationRuleHistories { get; set; }
        public virtual DbSet<SpecificatonRuleHistoryExt> SpecificatonRuleHistoryExts { get; set; }
        public virtual DbSet<Ssccgeneration> Ssccgenerations { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<StationClearance> StationClearances { get; set; }
        public virtual DbSet<Tdp> Tdps { get; set; }
        public virtual DbSet<TestCompletedDevice> TestCompletedDevices { get; set; }
        public virtual DbSet<TestStageMap> TestStageMaps { get; set; }
        public virtual DbSet<TnlegacyProductCode> TnlegacyProductCodes { get; set; }
        public virtual DbSet<TrxPatch> TrxPatches { get; set; }
        public virtual DbSet<UdiText> UdiTexts { get; set; }
        public virtual DbSet<UnitCheck> UnitChecks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<WorkOrderAttachment> WorkOrderAttachments { get; set; }
        public virtual DbSet<WorkOrderAttribute> WorkOrderAttributes { get; set; }
        public virtual DbSet<WorkOrderComment> WorkOrderComments { get; set; }
        public virtual DbSet<WorkOrderXml> WorkOrderXmls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=AWS-MSPSQL-D01.corp.resmed.org; database=MSPWIP;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActionType>(entity =>
            {
                entity.Property(e => e.ActionType1).IsUnicode(false);
            });

            modelBuilder.Entity<AreaClearance>(entity =>
            {
                entity.Property(e => e.AreaClearanceInstruction).IsUnicode(false);

                entity.Property(e => e.AreaClearedBy).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.AreaClearances)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_AreaClearance_ToWorkOrder");
            });

            modelBuilder.Entity<AreaStationClearance>(entity =>
            {
                entity.Property(e => e.AreaClearanceInstruction).IsUnicode(false);

                entity.Property(e => e.AreaClearedBy).IsUnicode(false);

                entity.Property(e => e.StationClearanceInstruction).IsUnicode(false);

                entity.Property(e => e.StationClearedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.AreaStationClearances)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AreaStationClearance_ToStation");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.AreaStationClearances)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_AreaStationClearance_ToWorkOrder");
            });

            modelBuilder.Entity<BillOfOperation>(entity =>
            {
                entity.Property(e => e.OperationDescription).IsUnicode(false);

                entity.Property(e => e.OperationType).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.RoutingRevision).IsUnicode(false);

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.BillOfOperations)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_BillOfOperation_WorkOrder");
            });

            modelBuilder.Entity<BomlabelPrintRecord>(entity =>
            {
                entity.Property(e => e.LabelId).IsUnicode(false);

                entity.Property(e => e.LabelIdLength).HasComputedColumnSql("(len([LabelID]))", false);

                entity.Property(e => e.LabelPartCode).IsUnicode(false);

                entity.Property(e => e.LabelType).IsUnicode(false);

                entity.Property(e => e.PrintedBy).IsUnicode(false);

                entity.Property(e => e.PrinterName).IsUnicode(false);

                entity.Property(e => e.Qrcode).IsUnicode(false);

                entity.Property(e => e.RePrintInstruction).IsUnicode(false);

                entity.Property(e => e.ReprintReason).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.BomlabelPrintRecords)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_BOMLabelPrintRecord_ToWorkOrder");
            });

            modelBuilder.Entity<Bompart>(entity =>
            {
                entity.HasKey(e => e.BomcomponentId)
                    .HasName("PK_PartCode");

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ComponentPartCodeType).IsUnicode(false);

                entity.Property(e => e.ComponentPartDesc).IsUnicode(false);

                entity.Property(e => e.ComponentPartRev).IsUnicode(false);

                entity.Property(e => e.IsCriticalComponent).IsUnicode(false);

                entity.Property(e => e.ParentComponentPartCode).IsUnicode(false);

                entity.Property(e => e.SupplyType).IsUnicode(false);

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.Bomparts)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BOMParts_WorkOrder");
            });

            modelBuilder.Entity<BompartsAttribute>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.Bomcomponent)
                    .WithMany(p => p.BompartsAttributes)
                    .HasForeignKey(d => d.BomcomponentId)
                    .HasConstraintName("FK_BOMPartsAttribute_BOMParts");
            });

            modelBuilder.Entity<CloseShortReason>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<CompletedUnit>(entity =>
            {
                entity.Property(e => e.UnitIdentifier).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.CompletedUnits)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_CompletedUnit_ToWorkOrder");
            });

            modelBuilder.Entity<CompletedUnitsView>(entity =>
            {
                entity.ToView("CompletedUnitsView", "MSPWIP");

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentSerialBlocked>(entity =>
            {
                entity.Property(e => e.CurrentStatus).IsUnicode(false);

                entity.Property(e => e.PartCode).IsUnicode(false);

                entity.Property(e => e.Reference).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentTrace>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ComponentValue).IsUnicode(false);

                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.TraceableCompValue).IsUnicode(false);

                entity.Property(e => e.TracedBy).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.ComponentTraces)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComponentTrace_ToTable");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.ComponentTraces)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_ComponentTrace_WorkOrder");
            });

            modelBuilder.Entity<ComponentTraceSubAssy>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ComponentValue).IsUnicode(false);

                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.TraceableCompValue).IsUnicode(false);

                entity.Property(e => e.TracedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.ComponentTraceSubAssies)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComponentTraceSubAssy_ToTable");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.ComponentTraceSubAssies)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_ComponentTraceSubAssy_WorkOrder");
            });

            modelBuilder.Entity<DashboardAction>(entity =>
            {
                entity.Property(e => e.ActionType).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.DashboardActions)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_DashboardAction_ToWorkOrder");
            });

            modelBuilder.Entity<DeviceError>(entity =>
            {
                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Dfct>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.DfctCategory)
                    .WithMany(p => p.Dfcts)
                    .HasForeignKey(d => d.DfctCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dfct_DfctCategory");

                entity.HasOne(d => d.DfctType)
                    .WithMany(p => p.Dfcts)
                    .HasForeignKey(d => d.DfctTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dfct_DfctType");
            });

            modelBuilder.Entity<DfctCategory>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<DfctLink>(entity =>
            {
                entity.HasOne(d => d.Dfct)
                    .WithMany(p => p.DfctLinks)
                    .HasForeignKey(d => d.DfctId)
                    .HasConstraintName("FK_DfctLink_Dfct");

                entity.HasOne(d => d.DfctSpec)
                    .WithMany(p => p.DfctLinks)
                    .HasForeignKey(d => d.DfctSpecId)
                    .HasConstraintName("FK_DfctLink_DfctSpec");
            });

            modelBuilder.Entity<DfctLinkHistory>(entity =>
            {
                entity.Property(e => e.HistoryId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DfctResult>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ToolNo).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<DfctResultDatum>(entity =>
            {
                entity.HasKey(e => e.DfctResultDataId)
                    .HasName("PK_DfctResultDataId");

                entity.Property(e => e.DfctPosition).IsUnicode(false);

                entity.HasOne(d => d.DfctResult)
                    .WithMany(p => p.DfctResultData)
                    .HasForeignKey(d => d.DfctResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DfctResult_DfctResultId");
            });

            modelBuilder.Entity<DfctSpec>(entity =>
            {
                entity.Property(e => e.ChangeNote).IsUnicode(false);

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.DfctStatus).IsUnicode(false);

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.Property(e => e.Revision).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<DfctSpecHistory>(entity =>
            {
                entity.Property(e => e.ChangeNote).IsUnicode(false);

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.DfctStatus).IsUnicode(false);

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.Property(e => e.Revision).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<DfctType>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeForm>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<EdhrSummary>(entity =>
            {
                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.PrimaryReportXml).IsUnicode(false);

                entity.Property(e => e.SecondaryReportXml).IsUnicode(false);

                entity.Property(e => e.SecondarySubReportXml).IsUnicode(false);

                entity.Property(e => e.VerifiedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.EdhrSummaries)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_EdhrSummary_WorkOrder");
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<EmailUser>(entity =>
            {
                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.EmailUsers)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_EmailUser_EmailType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmailUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_EmailUser_User");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventReferenceColumnValue).IsUnicode(false);

                entity.Property(e => e.RoutingStep).IsUnicode(false);

                entity.Property(e => e.StationName).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.EventReferenceColumnType)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventReferenceColumnTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_EventReferenceColumnType");

                entity.HasOne(d => d.EventType)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_EventType");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Events)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_WorkOrder");
            });

            modelBuilder.Entity<EventReferenceColumnType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<FailedLotControlledWipissue>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.ScrapFlag).IsUnicode(false);

                entity.Property(e => e.SubInventory).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<FailedLotControlledWipissueMessage>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.MessageType).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.FailedLotControlledWipissueMessages)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_FailedLotControlledWIPIssueMessage_WorkOrder");
            });

            modelBuilder.Entity<FglookUp>(entity =>
            {
                entity.Property(e => e.Boot).IsUnicode(false);

                entity.Property(e => e.Configuration).IsUnicode(false);

                entity.Property(e => e.FgSoftware).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mid).IsUnicode(false);

                entity.Property(e => e.NightProfileCard).IsUnicode(false);

                entity.Property(e => e.NightProfileWireless).IsUnicode(false);

                entity.Property(e => e.PcbaSubAssy).IsUnicode(false);

                entity.Property(e => e.ProductCode).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.RegionId).IsUnicode(false);

                entity.Property(e => e.Vid).IsUnicode(false);
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.Property(e => e.FunctionCode).IsUnicode(false);

                entity.Property(e => e.FunctionDesciption).IsUnicode(false);

                entity.Property(e => e.FunctionGroup).IsUnicode(false);

                entity.Property(e => e.FunctionName).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<InProcessDataOverride>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.OverriddenBy).IsUnicode(false);

                entity.Property(e => e.OverriddenOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.InProcessDataOverrides)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_InProcessDataOverride_WorkOrder");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DispositionStatus).IsUnicode(false);

                entity.Property(e => e.DispositionType).IsUnicode(false);

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.IncidentNumber).IsUnicode(false);

                entity.Property(e => e.IssueNumber).IsUnicode(false);

                entity.Property(e => e.OperationLocator).IsUnicode(false);

                entity.Property(e => e.ProductCode).IsUnicode(false);

                entity.Property(e => e.ProductionLine).IsUnicode(false);

                entity.Property(e => e.ReasonCode).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.ControlNumber });

                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.CountryOfOrigin).IsUnicode(false);

                entity.Property(e => e.LocatorName).IsUnicode(false);

                entity.Property(e => e.LotStatus).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.ProcessStatus).IsUnicode(false);

                entity.Property(e => e.ReferenceId).IsUnicode(false);

                entity.Property(e => e.SubInventoryLocation).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<ItemValidationRule>(entity =>
            {
                entity.Property(e => e.Rule).IsUnicode(false);

                entity.Property(e => e.RuleType).IsUnicode(false);

                entity.Property(e => e.RuleValue).IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemValidationRules)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemValidationRule_Item");
            });

            modelBuilder.Entity<ItemValidationRuleHistory>(entity =>
            {
                entity.Property(e => e.Rule).IsUnicode(false);

                entity.Property(e => e.RuleType).IsUnicode(false);

                entity.Property(e => e.RuleValue).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemValidationRuleHistories)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemValidationRuleHistory_Item");
            });

            modelBuilder.Entity<Lookup>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_DowntimeLookups");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Ncd>(entity =>
            {
                entity.Property(e => e.NcdNumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Ncds)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NCD_ToWorkOrder");
            });

            modelBuilder.Entity<NonStdCompletedDevice>(entity =>
            {
                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.Ncdnumber).IsUnicode(false);

                entity.Property(e => e.RemovedBy).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.NonStdCompletedDevices)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_NonStdCompletedDevice_ToWorkOrder");
            });

            modelBuilder.Entity<OnHandQuantity>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.CountryOfOrigin).IsUnicode(false);

                entity.Property(e => e.LotStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.ProductionLine)
                    .WithMany(p => p.OnHandQuantities)
                    .HasForeignKey(d => d.ProductionLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnHandQuantity_ProductionLine");
            });

            modelBuilder.Entity<OperationType>(entity =>
            {
                entity.Property(e => e.OperationDescription).IsUnicode(false);

                entity.Property(e => e.OperationType1).IsUnicode(false);
            });

            modelBuilder.Entity<OracleOnHandQuantity>(entity =>
            {
                entity.ToView("OracleOnHandQuantity", "MSPWIP");

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.ControlNumber).IsUnicode(false);

                entity.Property(e => e.LocatorName).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.SubInventoryLocation).IsUnicode(false);
            });

            modelBuilder.Entity<OracleStation>(entity =>
            {
                entity.ToView("OracleStation", "MSPWIP");

                entity.Property(e => e.OperationDescription).IsUnicode(false);

                entity.Property(e => e.OperationLocator).IsUnicode(false);

                entity.Property(e => e.OperationProductionLine).IsUnicode(false);

                entity.Property(e => e.OperationType).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.Printer1).IsUnicode(false);

                entity.Property(e => e.Printer2).IsUnicode(false);

                entity.Property(e => e.Printer3).IsUnicode(false);

                entity.Property(e => e.ReviewLocator).IsUnicode(false);

                entity.Property(e => e.ReviewProductionLine).IsUnicode(false);

                entity.Property(e => e.StationName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(e => e.OrganizationId).IsUnicode(false);

                entity.Property(e => e.OrganizationCode).IsUnicode(false);

                entity.Property(e => e.OrganizationName).IsUnicode(false);
            });

            modelBuilder.Entity<OutageMsg>(entity =>
            {
                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<Pallet>(entity =>
            {
                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.PackedBy).IsUnicode(false);

                entity.Property(e => e.PalletNumber).IsUnicode(false);

                entity.Property(e => e.ReleaseBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Pallets)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_Pallet_WorkOrder");
            });

            modelBuilder.Entity<PreviewLabel>(entity =>
            {
                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.Key).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReviewedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.PreviewLabels)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_PreviewLabel_ToWorkOrder");
            });

            modelBuilder.Entity<ProductCategorySet>(entity =>
            {
                entity.Property(e => e.ProductCategoryName).IsUnicode(false);

                entity.Property(e => e.ProductCategoryValue).IsUnicode(false);

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.ProductCategorySets)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_ProductCategorySet_WorkOrder");
            });

            modelBuilder.Entity<ProductionLine>(entity =>
            {
                entity.Property(e => e.ProductionLine1).IsUnicode(false);
            });

            modelBuilder.Entity<RePrintReason>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<ReasonCode>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<RegularExpression>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartCode).IsUnicode(false);

                entity.Property(e => e.RegexPattern).IsUnicode(false);

                entity.Property(e => e.TypeId).IsUnicode(false);
            });

            modelBuilder.Entity<ResLabelSpec>(entity =>
            {
                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.SubLabelFlag)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ResPrinter>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Printer).IsUnicode(false);

                entity.HasOne(d => d.ResLabelSpec)
                    .WithMany(p => p.ResPrinters)
                    .HasForeignKey(d => d.ResLabelSpecId)
                    .HasConstraintName("FK_ResPrinter_ResLabelSpec");
            });

            modelBuilder.Entity<ReservedParentSerial>(entity =>
            {
                entity.Property(e => e.ChildSerialNumber).IsUnicode(false);

                entity.Property(e => e.DeviceValidationNumber).IsUnicode(false);

                entity.Property(e => e.ParentSerialNumber).IsUnicode(false);

                entity.Property(e => e.PartNumber).IsUnicode(false);

                entity.Property(e => e.TraceStatus).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.ReservedParentSerials)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_ReservedParentSerial_ToWorkOrder");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Role1).IsUnicode(false);

                entity.Property(e => e.RoleDescription).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.RoleFunctions)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_RoleFunction_Function");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleFunctions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleFunction_Role");
            });

            modelBuilder.Entity<Routing>(entity =>
            {
                entity.Property(e => e.InProgress).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStageTest).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingStep).IsUnicode(false);

                entity.Property(e => e.UnitIdentifier).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Routings)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_Routing_WorkOrder");
            });

            modelBuilder.Entity<ScrappedDevice>(entity =>
            {
                entity.Property(e => e.ApprovedBy).IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.ScrappedBy).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.ScrappedDevices)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_ScrappedWorkOrder_ToWorkOrder");
            });

            modelBuilder.Entity<ScrappedDeviceView>(entity =>
            {
                entity.ToView("ScrappedDeviceView", "MSPWIP");

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<SerialGeneration>(entity =>
            {
                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.SerialGenerations)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerialGeneration_ToWorkOrder");
            });

            modelBuilder.Entity<SerialisedUnit>(entity =>
            {
                entity.HasKey(e => e.SerialsedUnitId)
                    .HasName("PK_SerialNumber");

                entity.Property(e => e.DeviceValidationNumber).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.SerialisedUnits)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_SerialisedUnits_WorkOrder");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.PackedBy).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.ShipperNumber).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.Pallet)
                    .WithMany(p => p.Shippers)
                    .HasForeignKey(d => d.PalletId)
                    .HasConstraintName("FK_Shipper_Pallet");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.Shippers)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipper_Station");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Shippers)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_Shipper_WorkOrder");
            });

            modelBuilder.Entity<SignatureLog>(entity =>
            {
                entity.Property(e => e.LoggedUser).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.SignatureLogs)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_SignatureLog_ToWorkOrder");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.Property(e => e.ChangeNote).IsUnicode(false);

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.Revision).IsUnicode(false);

                entity.Property(e => e.SpecificationStatus).IsUnicode(false);

                entity.Property(e => e.VerificationType).IsUnicode(false);
            });

            modelBuilder.Entity<SpecificationHistory>(entity =>
            {
                entity.Property(e => e.ChangeNote).IsUnicode(false);

                entity.Property(e => e.ComponentPartCode).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.Revision).IsUnicode(false);

                entity.Property(e => e.SpecificationStatus).IsUnicode(false);

                entity.Property(e => e.VerificationType).IsUnicode(false);
            });

            modelBuilder.Entity<SpecificationRule>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.RefBom).IsUnicode(false);

                entity.Property(e => e.RegexPattern).IsUnicode(false);

                entity.Property(e => e.RuleDefinition).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.ValidationType).IsUnicode(false);

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.SpecificationRules)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specification_SpecificationRule");
            });

            modelBuilder.Entity<SpecificationRuleExt>(entity =>
            {
                entity.Property(e => e.RefBomend).IsUnicode(false);

                entity.Property(e => e.RefBomstart).IsUnicode(false);

                entity.Property(e => e.Stage).IsUnicode(false);

                entity.HasOne(d => d.SpecificationRule)
                    .WithMany(p => p.SpecificationRuleExts)
                    .HasForeignKey(d => d.SpecificationRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecificationRule_SpecificationRuleExt");
            });

            modelBuilder.Entity<SpecificationRuleHistory>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.RefBom).IsUnicode(false);

                entity.Property(e => e.RegexPattern).IsUnicode(false);

                entity.Property(e => e.RuleDefinition).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.ValidationType).IsUnicode(false);

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.SpecificationRuleHistories)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specification_SpecificationRuleHistory");
            });

            modelBuilder.Entity<SpecificatonRuleHistoryExt>(entity =>
            {
                entity.HasKey(e => e.SpecificationRuleHistoryExtId)
                    .HasName("PK_SpecificationRuleHistoryExt");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.RefBomend).IsUnicode(false);

                entity.Property(e => e.RefBomstart).IsUnicode(false);

                entity.Property(e => e.Stage).IsUnicode(false);
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OperationLocator).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.Printer1).IsUnicode(false);

                entity.Property(e => e.Printer2).IsUnicode(false);

                entity.Property(e => e.Printer3).IsUnicode(false);

                entity.Property(e => e.ReviewLocator).IsUnicode(false);

                entity.Property(e => e.StationName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.OperationProductionLine)
                    .WithMany(p => p.StationOperationProductionLines)
                    .HasForeignKey(d => d.OperationProductionLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Station_OperationProductionLine");

                entity.HasOne(d => d.OperationType)
                    .WithMany(p => p.Stations)
                    .HasForeignKey(d => d.OperationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Station_OperationType");

                entity.HasOne(d => d.ReviewProductionLine)
                    .WithMany(p => p.StationReviewProductionLines)
                    .HasForeignKey(d => d.ReviewProductionLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Station_ReviewProductionLine");
            });

            modelBuilder.Entity<StationClearance>(entity =>
            {
                entity.Property(e => e.StationClearanceInstruction).IsUnicode(false);

                entity.Property(e => e.StationClearedBy).IsUnicode(false);

                entity.Property(e => e.StationName).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.StationClearances)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_StationClearance_ToWorkOrder");
            });

            modelBuilder.Entity<Tdp>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.Tdps)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_TDP_WorkOrder");
            });

            modelBuilder.Entity<TestCompletedDevice>(entity =>
            {
                entity.HasKey(e => e.CompletedDeviceId)
                    .HasName("PK_CompletedDevice");

                entity.Property(e => e.UnitIdentifier).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.TestCompletedDevices)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_TestCompletedDevice_ToWorkOrder");
            });

            modelBuilder.Entity<TestStageMap>(entity =>
            {
                entity.Property(e => e.Acronym).IsUnicode(false);

                entity.Property(e => e.Mspstage).IsUnicode(false);

                entity.Property(e => e.TestStage).IsUnicode(false);
            });

            modelBuilder.Entity<TnlegacyProductCode>(entity =>
            {
                entity.Property(e => e.ProductCode).IsUnicode(false);
            });

            modelBuilder.Entity<TrxPatch>(entity =>
            {
                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.TrxKey).IsUnicode(false);

                entity.Property(e => e.TrxType).IsUnicode(false);

                entity.Property(e => e.WorkOrderId).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<UdiText>(entity =>
            {
                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.UdiText1).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);
            });

            modelBuilder.Entity<UnitCheck>(entity =>
            {
                entity.Property(e => e.CheckedBy).IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.UnitCheckType).IsUnicode(false);

                entity.Property(e => e.UnitIdentifier).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.UnitChecks)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_UnitCheck_ToWorkOrder");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.OrgId).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.UserAdName).IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasKey(e => e.WipworkOrderId)
                    .HasName("PK_WorkOrder_1");

                entity.Property(e => e.Bomrevision).IsUnicode(false);

                entity.Property(e => e.Cestatus).IsUnicode(false);

                entity.Property(e => e.CompletionSubinventory).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CurrentStatus).IsUnicode(false);

                entity.Property(e => e.EdhrFlag).IsUnicode(false);

                entity.Property(e => e.JobTypeMeaning).IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.ManufacturingSystem).IsUnicode(false);

                entity.Property(e => e.OrganisationId).IsUnicode(false);

                entity.Property(e => e.ProductCode).IsUnicode(false);

                entity.Property(e => e.ProductDescription).IsUnicode(false);

                entity.Property(e => e.ProductStatus).IsUnicode(false);

                entity.Property(e => e.ProductionArea).IsUnicode(false);

                entity.Property(e => e.ProductionAreaDescription).IsUnicode(false);

                entity.Property(e => e.ProductionLine).IsUnicode(false);

                entity.Property(e => e.ProductionLineDescription).IsUnicode(false);

                entity.Property(e => e.SerialGenerationFlag).IsUnicode(false);

                entity.Property(e => e.StockBackQuantity).IsUnicode(false);

                entity.Property(e => e.Tdpnumber).IsUnicode(false);

                entity.Property(e => e.Wodescription).IsUnicode(false);

                entity.Property(e => e.WorkOrderId).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.Property(e => e.Wostatus).IsUnicode(false);

                entity.Property(e => e.Wotype).IsUnicode(false);
            });

            modelBuilder.Entity<WorkOrderAttachment>(entity =>
            {
                entity.Property(e => e.FileDescription).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Key).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UploadedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.WorkOrderAttachments)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_WorkOrderAttachment_WorkOrder");
            });

            modelBuilder.Entity<WorkOrderAttribute>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.WorkOrderAttributes)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_WorkOrderAttribute_WorkOrder");
            });

            modelBuilder.Entity<WorkOrderComment>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Key).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReviewedBy).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.WorkOrderComments)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderComment_WorkOrder");
            });

            modelBuilder.Entity<WorkOrderXml>(entity =>
            {
                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.WorkOrderXmls)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WorkOrderXML_WorkOrder");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
