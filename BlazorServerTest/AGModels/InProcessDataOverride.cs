using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("InProcessDataOverride", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", "ComponentPartCode", Name = "UX_InProcessDataOverrideUnique", IsUnique = true)]
    public partial class InProcessDataOverride
    {
        [Key]
        public int InProcessDataOverrideId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(80)]
        [Unicode(false)]
        public string OverriddenBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime OverriddenOn { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
