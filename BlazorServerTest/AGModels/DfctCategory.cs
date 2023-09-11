using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DfctCategory", Schema = "MSPWIP")]
    public partial class DfctCategory
    {
        public DfctCategory()
        {
            Dfcts = new HashSet<Dfct>();
        }

        [Key]
        public int DfctCategoryId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string UpdatedBy { get; set; } = null!;

        [InverseProperty("DfctCategory")]
        public virtual ICollection<Dfct> Dfcts { get; set; }
    }
}
