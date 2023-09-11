using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("StationClearance", Schema = "MSPWIP")]
    [Index(nameof(StationName), Name = "nc_FK_StationClearance_ToStation")]
    [Index(nameof(WorkOrderNumber), Name = "nc_FK_StationClearance_ToWorkOrder")]
    public partial class StationClearance
    {
        [Key]
        [Column("StationClearanceID")]
        public int StationClearanceId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [StringLength(30)]
        public string StationName { get; set; }
        public bool IsLastStation { get; set; }
        [StringLength(150)]
        public string StationClearedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StationClearedOn { get; set; }
        public bool StationCleared { get; set; }
        [StringLength(150)]
        public string StationClearanceInstruction { get; set; }
        public bool IsPaused { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
