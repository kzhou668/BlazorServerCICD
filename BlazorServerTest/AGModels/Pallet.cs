using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Pallet", Schema = "MSPWIP")]
    [Index("PalletNumber", "ReleaseBy", Name = "nc_Pallet_PalletNumber_ReleaseBy")]
    [Index("WorkOrderNumber", Name = "unc_Pallet_workOrderNumber")]
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
        [Unicode(false)]
        public string? PalletNumber { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        public bool IsPacked { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PackedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackedOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ReleaseBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseOn { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Instruction { get; set; }
        public bool IsParked { get; set; }
        public bool IsSubmitted { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
        [InverseProperty("Pallet")]
        public virtual ICollection<Shipper> Shippers { get; set; }
    }
}
