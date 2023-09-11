using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
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
        [StringLength(40)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public int DfctTypeId { get; set; }
        public int DfctCategoryId { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string UpdatedBy { get; set; } = null!;

        [ForeignKey("DfctCategoryId")]
        [InverseProperty("Dfcts")]
        public virtual DfctCategory DfctCategory { get; set; } = null!;
        [ForeignKey("DfctTypeId")]
        [InverseProperty("Dfcts")]
        public virtual DfctType DfctType { get; set; } = null!;
        [InverseProperty("Dfct")]
        public virtual ICollection<DfctLink> DfctLinks { get; set; }
    }
}
