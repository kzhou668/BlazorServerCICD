using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
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
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [StringLength(3)]
        public string Revision { get; set; }
        [Required]
        [StringLength(20)]
        public string DfctStatus { get; set; }
        public int NoCavity { get; set; }
        [StringLength(100)]
        public string ImageName { get; set; }
        public byte[] Image { get; set; }
        [StringLength(50)]
        public string ChangeNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public int? ImageHeight { get; set; }
        [Column("XGrids")]
        public int? Xgrids { get; set; }

        [InverseProperty(nameof(DfctLink.DfctSpec))]
        public virtual ICollection<DfctLink> DfctLinks { get; set; }
    }
}
