using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorServerTest.AGModels
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

        public virtual DbSet<ActionType> ActionTypes { get; set; } = null!;
        public virtual DbSet<AreaClearance> AreaClearances { get; set; } = null!;
        public virtual DbSet<AreaStationClearance> AreaStationClearances { get; set; } = null!;
        public virtual DbSet<AttrepTruncationSafeguard> AttrepTruncationSafeguards { get; set; } = null!;
        public virtual DbSet<BillOfOperation> BillOfOperations { get; set; } = null!;
        public virtual DbSet<BomlabelPrintRecord> BomlabelPrintRecords { get; set; } = null!;
        public virtual DbSet<Bompart> Bomparts { get; set; } = null!;
        public virtual DbSet<BompartsAttribute> BompartsAttributes { get; set; } = null!;
        public virtual DbSet<CloseShortReason> CloseShortReasons { get; set; } = null!;
        public virtual DbSet<CompletedUnit> CompletedUnits { get; set; } = null!;
        public virtual DbSet<CompletedUnitsView> CompletedUnitsViews { get; set; } = null!;
        public virtual DbSet<ComponentSerialBlocked> ComponentSerialBlockeds { get; set; } = null!;
        public virtual DbSet<ComponentTrace> ComponentTraces { get; set; } = null!;
        public virtual DbSet<ComponentTraceSubAssy> ComponentTraceSubAssies { get; set; } = null!;
        public virtual DbSet<DashboardAction> DashboardActions { get; set; } = null!;
        public virtual DbSet<DeviceError> DeviceErrors { get; set; } = null!;
        public virtual DbSet<Dfct> Dfcts { get; set; } = null!;
        public virtual DbSet<DfctCategory> DfctCategories { get; set; } = null!;
        public virtual DbSet<DfctLink> DfctLinks { get; set; } = null!;
        public virtual DbSet<DfctLinkHistory> DfctLinkHistories { get; set; } = null!;
        public virtual DbSet<DfctResult> DfctResults { get; set; } = null!;
        public virtual DbSet<DfctResultDatum> DfctResultData { get; set; } = null!;
        public virtual DbSet<DfctSpec> DfctSpecs { get; set; } = null!;
        public virtual DbSet<DfctSpecHistory> DfctSpecHistories { get; set; } = null!;
        public virtual DbSet<DfctType> DfctTypes { get; set; } = null!;
        public virtual DbSet<DownTime> DownTimes { get; set; } = null!;
        public virtual DbSet<DownTime1> DownTimes1 { get; set; } = null!;
        public virtual DbSet<DownTimeLog> DownTimeLogs { get; set; } = null!;
        public virtual DbSet<DownTimesLog> DownTimesLogs { get; set; } = null!;
        public virtual DbSet<DowntimeForm> DowntimeForms { get; set; } = null!;
        public virtual DbSet<DowntimeFormsLog> DowntimeFormsLogs { get; set; } = null!;
        public virtual DbSet<EdhrSummary> EdhrSummaries { get; set; } = null!;
        public virtual DbSet<EmailType> EmailTypes { get; set; } = null!;
        public virtual DbSet<EmailUser> EmailUsers { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<EventReferenceColumnType> EventReferenceColumnTypes { get; set; } = null!;
        public virtual DbSet<EventType> EventTypes { get; set; } = null!;
        public virtual DbSet<FailedLotControlledWipissue> FailedLotControlledWipissues { get; set; } = null!;
        public virtual DbSet<FailedLotControlledWipissueMessage> FailedLotControlledWipissueMessages { get; set; } = null!;
        public virtual DbSet<FglookUp> FglookUps { get; set; } = null!;
        public virtual DbSet<Function> Functions { get; set; } = null!;
        public virtual DbSet<InProcessDataOverride> InProcessDataOverrides { get; set; } = null!;
        public virtual DbSet<Incident> Incidents { get; set; } = null!;
        public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemValidationRule> ItemValidationRules { get; set; } = null!;
        public virtual DbSet<ItemValidationRuleHistory> ItemValidationRuleHistories { get; set; } = null!;
        public virtual DbSet<Lookup> Lookups { get; set; } = null!;
        public virtual DbSet<LookupsLog> LookupsLogs { get; set; } = null!;
        public virtual DbSet<MachineConfig> MachineConfigs { get; set; } = null!;
        public virtual DbSet<MspLsrLookupsTable> MspLsrLookupsTables { get; set; } = null!;
        public virtual DbSet<Ncd> Ncds { get; set; } = null!;
        public virtual DbSet<NonStdCompletedDevice> NonStdCompletedDevices { get; set; } = null!;
        public virtual DbSet<OnHandQuantity> OnHandQuantities { get; set; } = null!;
        public virtual DbSet<OperationType> OperationTypes { get; set; } = null!;
        public virtual DbSet<OracleOnHandQuantity> OracleOnHandQuantities { get; set; } = null!;
        public virtual DbSet<OracleStation> OracleStations { get; set; } = null!;
        public virtual DbSet<Organization> Organizations { get; set; } = null!;
        public virtual DbSet<OutageMsg> OutageMsgs { get; set; } = null!;
        public virtual DbSet<Pallet> Pallets { get; set; } = null!;
        public virtual DbSet<PreviewLabel> PreviewLabels { get; set; } = null!;
        public virtual DbSet<ProductCategorySet> ProductCategorySets { get; set; } = null!;
        public virtual DbSet<ProductionLine> ProductionLines { get; set; } = null!;
        public virtual DbSet<RePrintReason> RePrintReasons { get; set; } = null!;
        public virtual DbSet<ReasonCode> ReasonCodes { get; set; } = null!;
        public virtual DbSet<RegularExpression> RegularExpressions { get; set; } = null!;
        public virtual DbSet<ResLabelSpec> ResLabelSpecs { get; set; } = null!;
        public virtual DbSet<ResPrinter> ResPrinters { get; set; } = null!;
        public virtual DbSet<ReservedParentSerial> ReservedParentSerials { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleFunction> RoleFunctions { get; set; } = null!;
        public virtual DbSet<Routing> Routings { get; set; } = null!;
        public virtual DbSet<ScrappedDevice> ScrappedDevices { get; set; } = null!;
        public virtual DbSet<ScrappedDeviceView> ScrappedDeviceViews { get; set; } = null!;
        public virtual DbSet<SerialGeneration> SerialGenerations { get; set; } = null!;
        public virtual DbSet<SerialisedUnit> SerialisedUnits { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<SignatureLog> SignatureLogs { get; set; } = null!;
        public virtual DbSet<Specification> Specifications { get; set; } = null!;
        public virtual DbSet<SpecificationHistory> SpecificationHistories { get; set; } = null!;
        public virtual DbSet<SpecificationRule> SpecificationRules { get; set; } = null!;
        public virtual DbSet<SpecificationRuleExt> SpecificationRuleExts { get; set; } = null!;
        public virtual DbSet<SpecificationRuleHistory> SpecificationRuleHistories { get; set; } = null!;
        public virtual DbSet<SpecificatonRuleHistoryExt> SpecificatonRuleHistoryExts { get; set; } = null!;
        public virtual DbSet<Ssccgeneration> Ssccgenerations { get; set; } = null!;
        public virtual DbSet<Station> Stations { get; set; } = null!;
        public virtual DbSet<StationClearance> StationClearances { get; set; } = null!;
        public virtual DbSet<Tdp> Tdps { get; set; } = null!;
        public virtual DbSet<TestCompletedDevice> TestCompletedDevices { get; set; } = null!;
        public virtual DbSet<TestStageMap> TestStageMaps { get; set; } = null!;
        public virtual DbSet<TnlegacyProductCode> TnlegacyProductCodes { get; set; } = null!;
        public virtual DbSet<Tool> Tools { get; set; } = null!;
        public virtual DbSet<TrxPatch> TrxPatches { get; set; } = null!;
        public virtual DbSet<UdiText> UdiTexts { get; set; } = null!;
        public virtual DbSet<UnitCheck> UnitChecks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<WorkOrder> WorkOrders { get; set; } = null!;
        public virtual DbSet<WorkOrderAttachment> WorkOrderAttachments { get; set; } = null!;
        public virtual DbSet<WorkOrderAttribute> WorkOrderAttributes { get; set; } = null!;
        public virtual DbSet<WorkOrderComment> WorkOrderComments { get; set; } = null!;
        public virtual DbSet<WorkOrderXml> WorkOrderXmls { get; set; } = null!;

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
            modelBuilder.Entity<AreaClearance>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.AreaClearances)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_AreaClearance_ToWorkOrder");
            });

            modelBuilder.Entity<AreaStationClearance>(entity =>
            {
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

            modelBuilder.Entity<AttrepTruncationSafeguard>(entity =>
            {
                entity.HasKey(e => new { e.LatchTaskName, e.LatchMachineGuid, e.LatchKey })
                    .HasName("PK__attrep_t__65C99AC82390C124");

                entity.Property(e => e.LatchKey).IsFixedLength();
            });

            modelBuilder.Entity<BillOfOperation>(entity =>
            {
                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.BillOfOperations)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_BillOfOperation_WorkOrder");
            });

            modelBuilder.Entity<BomlabelPrintRecord>(entity =>
            {
                entity.Property(e => e.LabelIdLength).HasComputedColumnSql("(len([LabelID]))", false);

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

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.Bomparts)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BOMParts_WorkOrder");
            });

            modelBuilder.Entity<BompartsAttribute>(entity =>
            {
                entity.HasOne(d => d.Bomcomponent)
                    .WithMany(p => p.BompartsAttributes)
                    .HasForeignKey(d => d.BomcomponentId)
                    .HasConstraintName("FK_BOMPartsAttribute_BOMParts");
            });

            modelBuilder.Entity<CloseShortReason>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CompletedUnit>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.CompletedUnits)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_CompletedUnit_ToWorkOrder");
            });

            modelBuilder.Entity<CompletedUnitsView>(entity =>
            {
                entity.ToView("CompletedUnitsView", "MSPWIP");
            });

            modelBuilder.Entity<ComponentTrace>(entity =>
            {
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");

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
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.DashboardActions)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_DashboardAction_ToWorkOrder");
            });

            modelBuilder.Entity<Dfct>(entity =>
            {
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

            modelBuilder.Entity<DfctResultDatum>(entity =>
            {
                entity.HasKey(e => e.DfctResultDataId)
                    .HasName("PK_DfctResultDataId");

                entity.HasOne(d => d.DfctResult)
                    .WithMany(p => p.DfctResultData)
                    .HasForeignKey(d => d.DfctResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DfctResult_DfctResultId");
            });

            modelBuilder.Entity<DownTime>(entity =>
            {
                entity.Property(e => e.DownDuration).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TroubleShootingRejects).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DownTime1>(entity =>
            {
                entity.Property(e => e.DownDuration).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TroubleShootingRejects).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DowntimeForm>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Site).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<EdhrSummary>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.EdhrSummaries)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_EdhrSummary_WorkOrder");
            });

            modelBuilder.Entity<EmailUser>(entity =>
            {
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
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

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

            modelBuilder.Entity<FailedLotControlledWipissueMessage>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.FailedLotControlledWipissueMessages)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_FailedLotControlledWIPIssueMessage_WorkOrder");
            });

            modelBuilder.Entity<FglookUp>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InProcessDataOverride>(entity =>
            {
                entity.Property(e => e.OverriddenOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.InProcessDataOverrides)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_InProcessDataOverride_WorkOrder");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.Property(e => e.ErrorCount).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.ControlNumber });
            });

            modelBuilder.Entity<ItemValidationRule>(entity =>
            {
                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemValidationRules)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemValidationRule_Item");
            });

            modelBuilder.Entity<ItemValidationRuleHistory>(entity =>
            {
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

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayText).HasDefaultValueSql("(N'')");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LookupCode).HasDefaultValueSql("(N'')");

                entity.Property(e => e.LookupType).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<LookupsLog>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_DowntimeLookupsLog");
            });

            modelBuilder.Entity<Ncd>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Ncds)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NCD_ToWorkOrder");
            });

            modelBuilder.Entity<NonStdCompletedDevice>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.NonStdCompletedDevices)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_NonStdCompletedDevice_ToWorkOrder");
            });

            modelBuilder.Entity<OnHandQuantity>(entity =>
            {
                entity.Property(e => e.LotStatus).HasDefaultValueSql("('Active')");

                entity.HasOne(d => d.ProductionLine)
                    .WithMany(p => p.OnHandQuantities)
                    .HasForeignKey(d => d.ProductionLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnHandQuantity_ProductionLine");
            });

            modelBuilder.Entity<OracleOnHandQuantity>(entity =>
            {
                entity.ToView("OracleOnHandQuantity", "MSPWIP");
            });

            modelBuilder.Entity<OracleStation>(entity =>
            {
                entity.ToView("OracleStation", "MSPWIP");
            });

            modelBuilder.Entity<OutageMsg>(entity =>
            {
                entity.Property(e => e.OutageMsgId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Pallet>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Pallets)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_Pallet_WorkOrder");
            });

            modelBuilder.Entity<PreviewLabel>(entity =>
            {
                entity.Property(e => e.Key).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.PreviewLabels)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_PreviewLabel_ToWorkOrder");
            });

            modelBuilder.Entity<ProductCategorySet>(entity =>
            {
                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.ProductCategorySets)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_ProductCategorySet_WorkOrder");
            });

            modelBuilder.Entity<RePrintReason>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ReasonCode>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RegularExpression>(entity =>
            {
                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ResLabelSpec>(entity =>
            {
                entity.Property(e => e.SubLabelFlag).IsFixedLength();
            });

            modelBuilder.Entity<ResPrinter>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ResLabelSpec)
                    .WithMany(p => p.ResPrinters)
                    .HasForeignKey(d => d.ResLabelSpecId)
                    .HasConstraintName("FK_ResPrinter_ResLabelSpec");
            });

            modelBuilder.Entity<ReservedParentSerial>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.ReservedParentSerials)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_ReservedParentSerial_ToWorkOrder");
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
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

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.Routings)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_Routing_WorkOrder");
            });

            modelBuilder.Entity<ScrappedDevice>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.ScrappedDevices)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_ScrappedWorkOrder_ToWorkOrder");
            });

            modelBuilder.Entity<ScrappedDeviceView>(entity =>
            {
                entity.ToView("ScrappedDeviceView", "MSPWIP");
            });

            modelBuilder.Entity<SerialGeneration>(entity =>
            {
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

                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.SerialisedUnits)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_SerialisedUnits_WorkOrder");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
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
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.SignatureLogs)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_SignatureLog_ToWorkOrder");
            });

            modelBuilder.Entity<SpecificationRule>(entity =>
            {
                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.SpecificationRules)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specification_SpecificationRule");
            });

            modelBuilder.Entity<SpecificationRuleExt>(entity =>
            {
                entity.HasOne(d => d.SpecificationRule)
                    .WithMany(p => p.SpecificationRuleExts)
                    .HasForeignKey(d => d.SpecificationRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecificationRule_SpecificationRuleExt");
            });

            modelBuilder.Entity<SpecificationRuleHistory>(entity =>
            {
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
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("(getdate())");

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
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.StationClearances)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_StationClearance_ToWorkOrder");
            });

            modelBuilder.Entity<Tdp>(entity =>
            {
                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.Tdps)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_TDP_WorkOrder");
            });

            modelBuilder.Entity<TestCompletedDevice>(entity =>
            {
                entity.HasKey(e => e.CompletedDeviceId)
                    .HasName("PK_CompletedDevice");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.TestCompletedDevices)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_TestCompletedDevice_ToWorkOrder");
            });

            modelBuilder.Entity<UnitCheck>(entity =>
            {
                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.UnitChecks)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_UnitCheck_ToWorkOrder");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
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
            });

            modelBuilder.Entity<WorkOrderAttachment>(entity =>
            {
                entity.Property(e => e.Key).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.WorkOrderNumberNavigation)
                    .WithMany(p => p.WorkOrderAttachments)
                    .HasPrincipalKey(p => p.WorkOrderNumber)
                    .HasForeignKey(d => d.WorkOrderNumber)
                    .HasConstraintName("FK_WorkOrderAttachment_WorkOrder");
            });

            modelBuilder.Entity<WorkOrderAttribute>(entity =>
            {
                entity.HasOne(d => d.WipworkOrder)
                    .WithMany(p => p.WorkOrderAttributes)
                    .HasForeignKey(d => d.WipworkOrderId)
                    .HasConstraintName("FK_WorkOrderAttribute_WorkOrder");
            });

            modelBuilder.Entity<WorkOrderComment>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Key).HasDefaultValueSql("(newsequentialid())");

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
