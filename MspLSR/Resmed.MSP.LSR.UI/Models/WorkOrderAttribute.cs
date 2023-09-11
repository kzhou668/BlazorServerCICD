using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("WorkOrderAttribute", Schema = "MSPWIP")]
    [Index(nameof(WipworkOrderId), Name = "nc_WorkOrderAttribute_WIPWorkOrderID")]
    public partial class WorkOrderAttribute
    {
        [Key]
        [Column("WorkOrderAttributeID")]
        public int WorkOrderAttributeId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(240)]
        public string Name { get; set; }
        [StringLength(240)]
        public string Value { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.WorkOrderAttributes))]
        public virtual WorkOrder WipworkOrder { get; set; }
    }
}
