using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Specification", Schema = "MSPWIP")]
    public partial class Specification
    {
        public Specification()
        {
            SpecificationRuleHistories = new HashSet<SpecificationRuleHistory>();
            SpecificationRules = new HashSet<SpecificationRule>();
        }

        [Key]
        [Column("SpecificationID")]
        public int SpecificationId { get; set; }
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
        public DateTime UploadedOn { get; set; }

        [InverseProperty(nameof(SpecificationRuleHistory.Specification))]
        public virtual ICollection<SpecificationRuleHistory> SpecificationRuleHistories { get; set; }
        [InverseProperty(nameof(SpecificationRule.Specification))]
        public virtual ICollection<SpecificationRule> SpecificationRules { get; set; }
    }
}
