using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ReservedParentSerial", Schema = "MSPWIP")]
    [Index("ParentSerialNumber", Name = "nc_ReservedParentSerial_PSN")]
    [Index("WorkOrderNumber", "ParentSerialNumber", Name = "nc_ReservedParentSerial_WO_PSN")]
    public partial class ReservedParentSerial
    {
        [Key]
        public int ReservedParentSerialId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string ParentSerialNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string ChildSerialNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string PartNumber { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string TraceStatus { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? DeviceValidationNumber { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
