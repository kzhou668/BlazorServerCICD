using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("OutageMsg", Schema = "MSPWIP")]
    public partial class OutageMsg
    {
        [Key]
        [Column("OutageMsgID")]
        public int OutageMsgId { get; set; }
        [Required]
        [StringLength(60)]
        public string Message { get; set; }
        public int PreDisplayHours { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        [StringLength(40)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
    }
}
