using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("SerialisedUnit", Schema = "MSPWIP")]
    [Index(nameof(SerialNumber), nameof(DeviceValidationNumber), nameof(CreatedOn), Name = "nc_SerialisedUnit_SN_DVN_CO")]
    [Index(nameof(WipworkOrderId), nameof(SerialNumber), nameof(CreatedOn), Name = "nc_SerialisedUnit_WO_SN_CO")]
    [Index(nameof(SerialNumber), Name = "unc_SerialisedUnit_SerialNumber_ALL")]
    [Index(nameof(WipworkOrderId), nameof(SerialNumber), Name = "unc_SerialisedUnit_WIPWorkOrderID_SerialNumber", IsUnique = true)]
    public partial class SerialisedUnit
    {
        [Key]
        [Column("SerialsedUnitID")]
        public int SerialsedUnitId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [StringLength(5)]
        public string DeviceValidationNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.SerialisedUnits))]
        public virtual WorkOrder WipworkOrder { get; set; }
    }
}
