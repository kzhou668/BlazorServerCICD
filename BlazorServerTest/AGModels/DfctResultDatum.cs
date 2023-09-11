using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DfctResultData", Schema = "MSPWIP")]
    public partial class DfctResultDatum
    {
        [Key]
        public int DfctResultDataId { get; set; }
        public int DfctResultId { get; set; }
        public int DfctId { get; set; }
        public int DfctTypeId { get; set; }
        public int DfctCategoryId { get; set; }
        public bool IsLocation { get; set; }
        public bool IsCavity { get; set; }
        public int Quantity { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? DfctPosition { get; set; }
        public int? Cavity { get; set; }

        [ForeignKey("DfctResultId")]
        [InverseProperty("DfctResultData")]
        public virtual DfctResult DfctResult { get; set; } = null!;
    }
}
