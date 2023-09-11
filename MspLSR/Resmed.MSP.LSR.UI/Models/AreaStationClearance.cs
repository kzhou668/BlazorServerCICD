using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("AreaStationClearance", Schema = "MSPWIP")]
    [Index(nameof(StationId), Name = "nc_AreaStationClearance_StationID")]
    [Index(nameof(WorkOrderNumber), Name = "nc_AreaStationClearance_WorkOrderNumber")]
    public partial class AreaStationClearance
    {
        [Key]
        [Column("AreaStationClearanceID")]
        public int AreaStationClearanceId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        public int? StationId { get; set; }
        public bool IsLastStation { get; set; }
        [StringLength(150)]
        public string StationClearedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StationClearedOn { get; set; }
        public bool StationCleared { get; set; }
        [StringLength(150)]
        public string StationClearanceInstruction { get; set; }
        [StringLength(150)]
        public string AreaClearedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AreaClearedOn { get; set; }
        [StringLength(150)]
        public string AreaClearanceInstruction { get; set; }
        public bool AreaCleared { get; set; }
        public bool IsPaused { get; set; }

        [ForeignKey(nameof(StationId))]
        [InverseProperty("AreaStationClearances")]
        public virtual Station Station { get; set; }
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
