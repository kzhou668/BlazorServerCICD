using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Station", Schema = "MSPWIP")]
    [Index("OperationLocatorId", "StationId", "OrgId", Name = "nc_Station_OLID_StationID_OrgID")]
    [Index("OperationProductionLineId", Name = "nc_Station_OperationProductionLine")]
    [Index("OperationTypeId", Name = "nc_Station_OperationtypeID")]
    [Index("ReviewLocatorId", Name = "nc_Station_ReviewLocationID")]
    [Index("ReviewProductionLineId", Name = "nc_Station_ReviewProductionLine")]
    [Index("StationName", "OrgId", Name = "nc_Station_StName_OrgID")]
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
        [StringLength(30)]
        [Unicode(false)]
        public string StationName { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? Printer1 { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Printer2 { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Printer3 { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [Column("OperationProductionLineID")]
        public int OperationProductionLineId { get; set; }
        [Column("ReviewProductionLineID")]
        public int ReviewProductionLineId { get; set; }
        [Column("OperationTypeID")]
        public int OperationTypeId { get; set; }
        [Column("OperationLocatorID")]
        public int OperationLocatorId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string OperationLocator { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string ReviewLocator { get; set; } = null!;
        [Column("ReviewLocatorID")]
        public int ReviewLocatorId { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("OracleStationID")]
        public int? OracleStationId { get; set; }

        [ForeignKey("OperationProductionLineId")]
        [InverseProperty("StationOperationProductionLines")]
        public virtual ProductionLine OperationProductionLine { get; set; } = null!;
        [ForeignKey("OperationTypeId")]
        [InverseProperty("Stations")]
        public virtual OperationType OperationType { get; set; } = null!;
        [ForeignKey("ReviewProductionLineId")]
        [InverseProperty("StationReviewProductionLines")]
        public virtual ProductionLine ReviewProductionLine { get; set; } = null!;
        [InverseProperty("Station")]
        public virtual ICollection<AreaStationClearance> AreaStationClearances { get; set; }
        [InverseProperty("Station")]
        public virtual ICollection<ComponentTraceSubAssy> ComponentTraceSubAssies { get; set; }
        [InverseProperty("Station")]
        public virtual ICollection<ComponentTrace> ComponentTraces { get; set; }
        [InverseProperty("Station")]
        public virtual ICollection<Shipper> Shippers { get; set; }
    }
}
