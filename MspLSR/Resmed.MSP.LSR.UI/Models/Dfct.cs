using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Dfct", Schema = "MSPWIP")]
    public partial class Dfct
    {
        public Dfct()
        {
            DfctLinks = new HashSet<DfctLink>();
        }

        [Key]
        public int DfctId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public int DfctTypeId { get; set; }
        public int DfctCategoryId { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [Required]
        [StringLength(30)]
        public string UpdatedBy { get; set; }

        [ForeignKey(nameof(DfctCategoryId))]
        [InverseProperty("Dfcts")]
        public virtual DfctCategory DfctCategory { get; set; }
        [ForeignKey(nameof(DfctTypeId))]
        [InverseProperty("Dfcts")]
        public virtual DfctType DfctType { get; set; }
        [InverseProperty(nameof(DfctLink.Dfct))]
        public virtual ICollection<DfctLink> DfctLinks { get; set; }
    }
}
