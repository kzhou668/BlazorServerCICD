using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("AreaStationClearance", Schema = "MSPWIP")]
    [Index("StationId", Name = "nc_AreaStationClearance_StationID")]
    [Index("WorkOrderNumber", Name = "nc_AreaStationClearance_WorkOrderNumber")]
    public partial class AreaStationClearance
    {
        [Key]
        [Column("AreaStationClearanceID")]
        public int AreaStationClearanceId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        public int? StationId { get; set; }
        public bool IsLastStation { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? StationClearedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StationClearedOn { get; set; }
        public bool StationCleared { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? StationClearanceInstruction { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? AreaClearedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AreaClearedOn { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? AreaClearanceInstruction { get; set; }
        public bool AreaCleared { get; set; }
        public bool IsPaused { get; set; }

        [ForeignKey("StationId")]
        [InverseProperty("AreaStationClearances")]
        public virtual Station? Station { get; set; }
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
