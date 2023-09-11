using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Pallet", Schema = "MSPWIP")]
    [Index(nameof(PalletNumber), nameof(ReleaseBy), Name = "nc_Pallet_PalletNumber_ReleaseBy")]
    [Index(nameof(WorkOrderNumber), Name = "unc_Pallet_workOrderNumber")]
    public partial class Pallet
    {
        public Pallet()
        {
            Shippers = new HashSet<Shipper>();
        }

        [Key]
        [Column("PalletID")]
        public int PalletId { get; set; }
        [StringLength(20)]
        public string PalletNumber { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        public bool IsPacked { get; set; }
        [StringLength(50)]
        public string PackedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackedOn { get; set; }
        [StringLength(50)]
        public string ReleaseBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseOn { get; set; }
        [StringLength(150)]
        public string Instruction { get; set; }
        public bool IsParked { get; set; }
        public bool IsSubmitted { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
        [InverseProperty(nameof(Shipper.Pallet))]
        public virtual ICollection<Shipper> Shippers { get; set; }
    }
}
