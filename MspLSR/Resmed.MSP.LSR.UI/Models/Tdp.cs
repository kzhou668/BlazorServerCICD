using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("TDP", Schema = "MSPWIP")]
    [Index(nameof(WipworkOrderId), Name = "nc_TDP_WorkOrderID")]
    public partial class Tdp
    {
        [Key]
        [Column("TDPID")]
        public int Tdpid { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(100)]
        public string Number { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.Tdps))]
        public virtual WorkOrder WipworkOrder { get; set; }
    }
}
