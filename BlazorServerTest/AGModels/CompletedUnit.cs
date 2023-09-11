using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("CompletedUnit", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_CompletedUnit_WorkOrderNumber")]
    [Index("UnitIdentifier", "WorkOrderNumber", Name = "unc_CompletedUnit_UnitIdentifier", IsUnique = true)]
    public partial class CompletedUnit
    {
        [Key]
        [Column("CompletedUnitID")]
        public int CompletedUnitId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string UnitIdentifier { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
