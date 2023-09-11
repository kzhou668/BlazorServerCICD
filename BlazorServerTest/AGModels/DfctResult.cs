using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DfctResult", Schema = "MSPWIP")]
    public partial class DfctResult
    {
        public DfctResult()
        {
            DfctResultData = new HashSet<DfctResultDatum>();
        }

        [Key]
        public int DfctResultId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string ToolNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [InverseProperty("DfctResult")]
        public virtual ICollection<DfctResultDatum> DfctResultData { get; set; }
    }
}
