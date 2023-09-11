using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("UnitCheck", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_UnitCheck_WorkOrderNumber")]
    public partial class UnitCheck
    {
        [Key]
        public int UnitCheckId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string UnitIdentifier { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string UnitCheckType { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? CheckedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CheckedOn { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Instruction { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
