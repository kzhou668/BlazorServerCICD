using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Event", Schema = "MSPWIP")]
    public partial class Event
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? RoutingStep { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? StationName { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("EventTypeID")]
        public int EventTypeId { get; set; }
        [Column("EventReferenceColumnTypeID")]
        public int EventReferenceColumnTypeId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? EventReferenceColumnValue { get; set; }

        [ForeignKey("EventReferenceColumnTypeId")]
        [InverseProperty("Events")]
        public virtual EventReferenceColumnType EventReferenceColumnType { get; set; } = null!;
        [ForeignKey("EventTypeId")]
        [InverseProperty("Events")]
        public virtual EventType EventType { get; set; } = null!;
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
