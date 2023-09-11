using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ReasonCode", Schema = "MSPWIP")]
    public partial class ReasonCode
    {
        [Key]
        public int ReasonCodeId { get; set; }
        [Column("OracleReasonID")]
        public int? OracleReasonId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Reason { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
