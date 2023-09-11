using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("StationClearance", Schema = "MSPWIP")]
    [Index("StationName", Name = "nc_FK_StationClearance_ToStation")]
    [Index("WorkOrderNumber", Name = "nc_FK_StationClearance_ToWorkOrder")]
    public partial class StationClearance
    {
        [Key]
        [Column("StationClearanceID")]
        public int StationClearanceId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? StationName { get; set; }
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
        public bool IsPaused { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
