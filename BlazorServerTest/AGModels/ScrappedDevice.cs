using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ScrappedDevice", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", "SerialNumber", Name = "nc_WorkOrder_SerialNumber")]
    [Index("WorkOrderNumber", "CutShort", Name = "nc_WorkOrer_CutShort")]
    public partial class ScrappedDevice
    {
        [Key]
        [Column("ScrappedDeviceID")]
        public int ScrappedDeviceId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? Reason { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string ScrappedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ScrappedOn { get; set; }
        public bool? CutShort { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Instruction { get; set; }
        public bool Approved { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? ApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApprovedOn { get; set; }
        public Guid? ScrapRequestGuid { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
