using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SpecificationHistory", Schema = "MSPWIP")]
    [Index("ComponentPartCode", "Revision", Name = "nc_SpecHistory_ComponentPartCode_Revision")]
    public partial class SpecificationHistory
    {
        [Key]
        [Column("HistoryID")]
        public int HistoryId { get; set; }
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
        public DateTime CreatedDate { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
    }
}
