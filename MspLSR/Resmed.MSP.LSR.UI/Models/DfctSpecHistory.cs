using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("DfctSpecHistory", Schema = "MSPWIP")]
    public partial class DfctSpecHistory
    {
        [Key]
        public int HistoryId { get; set; }
        public Guid Version { get; set; }
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
        public byte[] Image { get; set; }
        [StringLength(100)]
        public string ImageName { get; set; }
        [StringLength(50)]
        public string ChangeNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public int? ImageHeight { get; set; }
        [Column("XGrids")]
        public int? Xgrids { get; set; }
    }
}
