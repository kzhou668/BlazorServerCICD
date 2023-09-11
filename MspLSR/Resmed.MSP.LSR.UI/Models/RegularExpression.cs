using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("RegularExpression", Schema = "MSPWIP")]
    [Index(nameof(PartCode), Name = "ncu_RegularExpression_PartCode", IsUnique = true)]
    public partial class RegularExpression
    {
        [Key]
        public int RegularExpressionId { get; set; }
        [Required]
        [StringLength(30)]
        public string PartCode { get; set; }
        [Required]
        [StringLength(200)]
        public string RegexPattern { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
        [StringLength(40)]
        public string TypeId { get; set; }
    }
}
