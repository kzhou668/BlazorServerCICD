using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Keyless]
    [Table("MspLsr.LookupsTables")]
    public partial class MspLsrLookupsTable
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? AutoId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? AppName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LookupType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LookupCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DisplayText { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DisplayOrder { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? IsActive { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CreatedDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
    }
}
