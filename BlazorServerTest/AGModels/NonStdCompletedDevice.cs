using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("NonStdCompletedDevice", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", "SerialNumber", Name = "IX_WorkOrder_SerialNumber")]
    public partial class NonStdCompletedDevice
    {
        [Key]
        [Column("NonStdCompletedDeviceID")]
        public int NonStdCompletedDeviceId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [Column("NCDNumber")]
        [StringLength(30)]
        [Unicode(false)]
        public string? Ncdnumber { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string RemovedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime RemovedOn { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Instruction { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
