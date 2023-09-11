using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Shipper", Schema = "MSPWIP")]
    [Index("PalletId", Name = "nc_Shipper_PalletID")]
    [Index("SerialNumber", Name = "nc_Shipper_SerialNumber")]
    [Index("ShipperNumber", Name = "nc_Shipper_ShipperNumber")]
    [Index("StationId", Name = "nc_Shipper_StationID")]
    [Index("WorkOrderNumber", "SerialNumber", Name = "unc_Shipper_workOrderNumber_SerialNumber", IsUnique = true)]
    public partial class Shipper
    {
        [Key]
        [Column("ShipperID")]
        public int ShipperId { get; set; }
        [Column("PalletID")]
        public int? PalletId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? ShipperNumber { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string SerialNumber { get; set; } = null!;
        [Column("StationID")]
        public int StationId { get; set; }
        public bool IsPacked { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PackedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackedOn { get; set; }

        [ForeignKey("PalletId")]
        [InverseProperty("Shippers")]
        public virtual Pallet? Pallet { get; set; }
        [ForeignKey("StationId")]
        [InverseProperty("Shippers")]
        public virtual Station Station { get; set; } = null!;
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
