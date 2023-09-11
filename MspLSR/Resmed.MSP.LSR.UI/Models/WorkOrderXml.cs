using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("WorkOrderXML", Schema = "MSPWIP")]
    [Index(nameof(WipworkOrderId), Name = "nc_WorkOrderXML_WIPWorkOrderID")]
    public partial class WorkOrderXml
    {
        [Key]
        [Column("WorkOrderXMLID")]
        public int WorkOrderXmlid { get; set; }
        [Column("WIPWorkOrderID")]
        public int? WipworkOrderId { get; set; }
        [Column("WorkOrderXML", TypeName = "xml")]
        public string WorkOrderXml1 { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.WorkOrderXmls))]
        public virtual WorkOrder WipworkOrder { get; set; }
    }
}
