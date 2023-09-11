using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("WorkOrderAttribute", Schema = "MSPWIP")]
    [Index("Name", Name = "nc_WorkOrderAttribute_Name")]
    [Index("WipworkOrderId", Name = "nc_WorkOrderAttribute_WIPWorkOrderID")]
    public partial class WorkOrderAttribute
    {
        [Key]
        [Column("WorkOrderAttributeID")]
        public int WorkOrderAttributeId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string? Value { get; set; }

        [ForeignKey("WipworkOrderId")]
        [InverseProperty("WorkOrderAttributes")]
        public virtual WorkOrder WipworkOrder { get; set; } = null!;
    }
}
