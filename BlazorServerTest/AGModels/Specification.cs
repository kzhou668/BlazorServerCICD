using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
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
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string Revision { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string SpecificationStatus { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string VerificationType { get; set; } = null!;
        [StringLength(5000)]
        [Unicode(false)]
        public string Instruction { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? ChangeNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UploadedOn { get; set; }

        [InverseProperty("Specification")]
        public virtual ICollection<SpecificationRuleHistory> SpecificationRuleHistories { get; set; }
        [InverseProperty("Specification")]
        public virtual ICollection<SpecificationRule> SpecificationRules { get; set; }
    }
}
