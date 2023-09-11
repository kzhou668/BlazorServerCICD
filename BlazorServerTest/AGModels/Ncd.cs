using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("NCD", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_Ncd_WorkOrderNumber")]
    public partial class Ncd
    {
        [Key]
        public int NcdId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? NcdNumber { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string? Status { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
