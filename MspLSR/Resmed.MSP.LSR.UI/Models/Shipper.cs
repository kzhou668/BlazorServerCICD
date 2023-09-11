using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Shipper", Schema = "MSPWIP")]
    [Index(nameof(PalletId), Name = "nc_Shipper_PalletID")]
    [Index(nameof(SerialNumber), Name = "nc_Shipper_SerialNumber")]
    [Index(nameof(ShipperNumber), Name = "nc_Shipper_ShipperNumber")]
    [Index(nameof(StationId), Name = "nc_Shipper_StationID")]
    [Index(nameof(WorkOrderNumber), nameof(SerialNumber), Name = "unc_Shipper_workOrderNumber_SerialNumber", IsUnique = true)]
    public partial class Shipper
    {
        [Key]
        [Column("ShipperID")]
        public int ShipperId { get; set; }
        [Column("PalletID")]
        public int? PalletId { get; set; }
        [StringLength(20)]
        public string ShipperNumber { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Column("StationID")]
        public int StationId { get; set; }
        public bool IsPacked { get; set; }
        [StringLength(50)]
        public string PackedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackedOn { get; set; }

        [ForeignKey(nameof(PalletId))]
        [InverseProperty("Shippers")]
        public virtual Pallet Pallet { get; set; }
        [ForeignKey(nameof(StationId))]
        [InverseProperty("Shippers")]
        public virtual Station Station { get; set; }
        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
