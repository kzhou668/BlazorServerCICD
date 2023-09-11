using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DfctSpec", Schema = "MSPWIP")]
    public partial class DfctSpec
    {
        public DfctSpec()
        {
            DfctLinks = new HashSet<DfctLink>();
        }

        [Key]
        public int DfctSpecId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string Revision { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string DfctStatus { get; set; } = null!;
        public int NoCavity { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ImageName { get; set; }
        public byte[]? Image { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ChangeNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        public int? ImageHeight { get; set; }
        [Column("XGrids")]
        public int? Xgrids { get; set; }

        [InverseProperty("DfctSpec")]
        public virtual ICollection<DfctLink> DfctLinks { get; set; }
    }
}
