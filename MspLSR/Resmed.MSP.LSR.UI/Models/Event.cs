using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Event", Schema = "MSPWIP")]
    public partial class Event
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [StringLength(50)]
        public string RoutingStep { get; set; }
        [StringLength(50)]
        public string StationName { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("EventTypeID")]
        public int EventTypeId { get; set; }
        [Column("EventReferenceColumnTypeID")]
        public int EventReferenceColumnTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string EventReferenceColumnValue { get; set; }

        [ForeignKey(nameof(EventReferenceColumnTypeId))]
        [InverseProperty("Events")]
        public virtual EventReferenceColumnType EventReferenceColumnType { get; set; }
        [ForeignKey(nameof(EventTypeId))]
        [InverseProperty("Events")]
        public virtual EventType EventType { get; set; }
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
