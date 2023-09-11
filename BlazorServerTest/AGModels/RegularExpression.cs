using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("RegularExpression", Schema = "MSPWIP")]
    [Index("PartCode", Name = "ncu_RegularExpression_PartCode", IsUnique = true)]
    public partial class RegularExpression
    {
        [Key]
        public int RegularExpressionId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string PartCode { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string RegexPattern { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? TypeId { get; set; }
    }
}
