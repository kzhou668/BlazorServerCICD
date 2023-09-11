using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ReservedParentSerial", Schema = "MSPWIP")]
    [Index(nameof(ParentSerialNumber), Name = "nc_ReservedParentSerial_PSN")]
    [Index(nameof(WorkOrderNumber), nameof(ParentSerialNumber), Name = "nc_ReservedParentSerial_WO_PSN")]
    public partial class ReservedParentSerial
    {
        [Key]
        public int ReservedParentSerialId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string ParentSerialNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string ChildSerialNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(1)]
        public string TraceStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(5)]
        public string DeviceValidationNumber { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
