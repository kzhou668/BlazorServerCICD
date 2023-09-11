using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("CloseShortReason", Schema = "MSPWIP")]
    public partial class CloseShortReason
    {
        [Key]
        public int CloseShortReasonId { get; set; }
        [Required]
        [StringLength(50)]
        public string Reason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
