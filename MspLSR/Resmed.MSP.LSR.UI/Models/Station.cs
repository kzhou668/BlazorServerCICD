using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Station", Schema = "MSPWIP")]
    [Index(nameof(OperationLocatorId), nameof(StationId), nameof(OrgId), Name = "nc_Station_OLID_StationID_OrgID")]
    [Index(nameof(OperationProductionLineId), Name = "nc_Station_OperationProductionLine")]
    [Index(nameof(OperationTypeId), Name = "nc_Station_OperationtypeID")]
    [Index(nameof(ReviewLocatorId), Name = "nc_Station_ReviewLocationID")]
    [Index(nameof(ReviewProductionLineId), Name = "nc_Station_ReviewProductionLine")]
    [Index(nameof(StationName), nameof(OrgId), Name = "nc_Station_StName_OrgID")]
    public partial class Station
    {
        public Station()
        {
            AreaStationClearances = new HashSet<AreaStationClearance>();
            ComponentTraceSubAssies = new HashSet<ComponentTraceSubAssy>();
            ComponentTraces = new HashSet<ComponentTrace>();
            Shippers = new HashSet<Shipper>();
        }

        [Key]
        [Column("StationID")]
        public int StationId { get; set; }
        [Required]
        [StringLength(30)]
        public string StationName { get; set; }
        [StringLength(30)]
        public string Printer1 { get; set; }
        [StringLength(30)]
        public string Printer2 { get; set; }
        [StringLength(30)]
        public string Printer3 { get; set; }
        [Required]
        [StringLength(3)]
        public string OrgId { get; set; }
        [Column("OperationProductionLineID")]
        public int OperationProductionLineId { get; set; }
        [Column("ReviewProductionLineID")]
        public int ReviewProductionLineId { get; set; }
        [Column("OperationTypeID")]
        public int OperationTypeId { get; set; }
        [Column("OperationLocatorID")]
        public int OperationLocatorId { get; set; }
        [Required]
        [StringLength(30)]
        public string OperationLocator { get; set; }
        [Required]
        [StringLength(30)]
        public string ReviewLocator { get; set; }
        [Column("ReviewLocatorID")]
        public int ReviewLocatorId { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("OracleStationID")]
        public int? OracleStationId { get; set; }

        [ForeignKey(nameof(OperationProductionLineId))]
        [InverseProperty(nameof(ProductionLine.StationOperationProductionLines))]
        public virtual ProductionLine OperationProductionLine { get; set; }
        [ForeignKey(nameof(OperationTypeId))]
        [InverseProperty("Stations")]
        public virtual OperationType OperationType { get; set; }
        [ForeignKey(nameof(ReviewProductionLineId))]
        [InverseProperty(nameof(ProductionLine.StationReviewProductionLines))]
        public virtual ProductionLine ReviewProductionLine { get; set; }
        [InverseProperty(nameof(AreaStationClearance.Station))]
        public virtual ICollection<AreaStationClearance> AreaStationClearances { get; set; }
        [InverseProperty(nameof(ComponentTraceSubAssy.Station))]
        public virtual ICollection<ComponentTraceSubAssy> ComponentTraceSubAssies { get; set; }
        [InverseProperty(nameof(ComponentTrace.Station))]
        public virtual ICollection<ComponentTrace> ComponentTraces { get; set; }
        [InverseProperty(nameof(Shipper.Station))]
        public virtual ICollection<Shipper> Shippers { get; set; }
    }
}
