using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
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
        [Required]
        [StringLength(30)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string ComponentPartCode { get; set; }
        [Required]
        [StringLength(40)]
        public string ToolNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }

        [InverseProperty(nameof(DfctResultDatum.DfctResult))]
        public virtual ICollection<DfctResultDatum> DfctResultData { get; set; }
    }
}
