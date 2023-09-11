using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("TDP", Schema = "MSPWIP")]
    [Index("WipworkOrderId", Name = "nc_TDP_WorkOrderID")]
    public partial class Tdp
    {
        [Key]
        [Column("TDPID")]
        public int Tdpid { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Number { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Description { get; set; }

        [ForeignKey("WipworkOrderId")]
        [InverseProperty("Tdps")]
        public virtual WorkOrder WipworkOrder { get; set; } = null!;
    }
}
