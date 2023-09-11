using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ScrappedDevice", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), nameof(SerialNumber), Name = "nc_WorkOrder_SerialNumber")]
    [Index(nameof(WorkOrderNumber), nameof(CutShort), Name = "nc_WorkOrer_CutShort")]
    public partial class ScrappedDevice
    {
        [Key]
        [Column("ScrappedDeviceID")]
        public int ScrappedDeviceId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [StringLength(100)]
        public string Reason { get; set; }
        [Required]
        [StringLength(150)]
        public string ScrappedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ScrappedOn { get; set; }
        public bool? CutShort { get; set; }
        [StringLength(500)]
        public string Instruction { get; set; }
        public bool Approved { get; set; }
        [StringLength(150)]
        public string ApprovedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApprovedOn { get; set; }
        public Guid? ScrapRequestGuid { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
