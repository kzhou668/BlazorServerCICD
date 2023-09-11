using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("NonStdCompletedDevice", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), nameof(SerialNumber), Name = "IX_WorkOrder_SerialNumber")]
    public partial class NonStdCompletedDevice
    {
        [Key]
        [Column("NonStdCompletedDeviceID")]
        public int NonStdCompletedDeviceId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Column("NCDNumber")]
        [StringLength(30)]
        public string Ncdnumber { get; set; }
        [Required]
        [StringLength(150)]
        public string RemovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RemovedOn { get; set; }
        [StringLength(500)]
        public string Instruction { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
