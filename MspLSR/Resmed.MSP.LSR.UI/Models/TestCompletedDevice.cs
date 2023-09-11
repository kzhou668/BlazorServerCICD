using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("TestCompletedDevice", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_TestCompletedDevice_WorkOrderNumber")]
    [Index(nameof(UnitIdentifier), nameof(WorkOrderNumber), Name = "unc_TestCompleted_UnitIdentifier", IsUnique = true)]
    public partial class TestCompletedDevice
    {
        [Key]
        [Column("CompletedDeviceID")]
        public int CompletedDeviceId { get; set; }
        [Required]
        [StringLength(40)]
        public string UnitIdentifier { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
