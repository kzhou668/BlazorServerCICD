using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("AreaClearance", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_FK_AreaClearance_ToWorkOrder")]
    public partial class AreaClearance
    {
        [Key]
        [Column("AreaClearanceID")]
        public int AreaClearanceId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
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
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
