using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("SpecificationHistory", Schema = "MSPWIP")]
    [Index(nameof(ComponentPartCode), nameof(Revision), Name = "nc_SpecHistory_ComponentPartCode_Revision")]
    public partial class SpecificationHistory
    {
        [Key]
        [Column("HistoryID")]
        public int HistoryId { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [StringLength(3)]
        public string Revision { get; set; }
        [Required]
        [StringLength(20)]
        public string SpecificationStatus { get; set; }
        [Required]
        [StringLength(30)]
        public string VerificationType { get; set; }
        [Required]
        [StringLength(5000)]
        public string Instruction { get; set; }
        [StringLength(50)]
        public string ChangeNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
    }
}
