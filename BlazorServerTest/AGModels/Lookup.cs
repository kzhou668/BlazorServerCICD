using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Lookups", Schema = "MSPLSR")]
    public partial class Lookup
    {
        [Key]
        public long AutoId { get; set; }
        [StringLength(50)]
        public string? AppName { get; set; }
        [StringLength(50)]
        public string LookupType { get; set; } = null!;
        [StringLength(50)]
        public string LookupCode { get; set; } = null!;
        [StringLength(250)]
        public string DisplayText { get; set; } = null!;
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
    }
}
