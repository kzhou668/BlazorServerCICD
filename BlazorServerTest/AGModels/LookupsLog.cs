using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("LookupsLog", Schema = "MSPLSR")]
    public partial class LookupsLog
    {
        [Key]
        public long AutoId { get; set; }
        public long? ItemId { get; set; }
        [StringLength(50)]
        public string? AppName { get; set; }
        [StringLength(50)]
        public string? LookupType { get; set; }
        [StringLength(50)]
        public string? LookupCode { get; set; }
        [StringLength(250)]
        public string? DisplayText { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(10)]
        public string? Operation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string? CreatedBy { get; set; }
    }
}
