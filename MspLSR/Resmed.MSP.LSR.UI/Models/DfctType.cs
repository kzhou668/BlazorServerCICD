using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("DfctType", Schema = "MSPWIP")]
    public partial class DfctType
    {
        public DfctType()
        {
            Dfcts = new HashSet<Dfct>();
        }

        [Key]
        public int DfctTypeId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public bool? IsLocation { get; set; }
        public bool? IsCavity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [Required]
        [StringLength(30)]
        public string UpdatedBy { get; set; }

        [InverseProperty(nameof(Dfct.DfctType))]
        public virtual ICollection<Dfct> Dfcts { get; set; }
    }
}
