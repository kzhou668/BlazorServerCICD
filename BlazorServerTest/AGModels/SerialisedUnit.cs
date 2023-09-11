using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SerialisedUnit", Schema = "MSPWIP")]
    [Index("SerialNumber", "DeviceValidationNumber", "CreatedOn", Name = "nc_SerialisedUnit_SN_DVN_CO")]
    [Index("WipworkOrderId", "SerialNumber", "CreatedOn", Name = "nc_SerialisedUnit_WO_SN_CO")]
    [Index("SerialNumber", Name = "unc_SerialisedUnit_SerialNumber_ALL")]
    [Index("WipworkOrderId", "SerialNumber", Name = "unc_SerialisedUnit_WIPWorkOrderID_SerialNumber", IsUnique = true)]
    public partial class SerialisedUnit
    {
        [Key]
        [Column("SerialsedUnitID")]
        public int SerialsedUnitId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [StringLength(5)]
        [Unicode(false)]
        public string? DeviceValidationNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }

        [ForeignKey("WipworkOrderId")]
        [InverseProperty("SerialisedUnits")]
        public virtual WorkOrder WipworkOrder { get; set; } = null!;
    }
}
