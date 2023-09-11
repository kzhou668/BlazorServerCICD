using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("RePrintReason", Schema = "MSPWIP")]
    public partial class RePrintReason
    {
        [Key]
        public int RePrintReasonId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Reason { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
