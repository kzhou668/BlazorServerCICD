using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ReasonCode", Schema = "MSPWIP")]
    public partial class ReasonCode
    {
        [Key]
        public int ReasonCodeId { get; set; }
        [Column("OracleReasonID")]
        public int? OracleReasonId { get; set; }
        [Required]
        [StringLength(50)]
        public string Reason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
