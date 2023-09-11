using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ResLabelSpec", Schema = "MSPWIP")]
    [Index(nameof(OrgId), nameof(Component), Name = "unc_ResLabelSpec_OrgID_Component", IsUnique = true)]
    public partial class ResLabelSpec
    {
        public ResLabelSpec()
        {
            ResPrinters = new HashSet<ResPrinter>();
        }

        [Key]
        public int ResLabelSpecId { get; set; }
        [Column("ComponentID")]
        public int ComponentId { get; set; }
        [Required]
        [Column("OrgID")]
        [StringLength(3)]
        public string OrgId { get; set; }
        [Required]
        [StringLength(40)]
        public string Component { get; set; }
        [Column("QCQuantity")]
        public int Qcquantity { get; set; }
        [StringLength(1)]
        public string SubLabelFlag { get; set; }

        [InverseProperty(nameof(ResPrinter.ResLabelSpec))]
        public virtual ICollection<ResPrinter> ResPrinters { get; set; }
    }
}
