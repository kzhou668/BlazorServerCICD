using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Keyless]
    [Table("OutageMsg", Schema = "MSPWIP")]
    public partial class OutageMsg
    {
        [Column("OutageMsgID")]
        public int OutageMsgId { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string Message { get; set; } = null!;
        public int PreDisplayHours { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
    }
}
