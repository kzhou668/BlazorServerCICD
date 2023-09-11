using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("attrep_truncation_safeguard")]
    public partial class AttrepTruncationSafeguard
    {
        [Key]
        [Column("latchTaskName")]
        [StringLength(128)]
        [Unicode(false)]
        public string LatchTaskName { get; set; } = null!;
        [Key]
        [Column("latchMachineGUID")]
        [StringLength(40)]
        [Unicode(false)]
        public string LatchMachineGuid { get; set; } = null!;
        [Key]
        [StringLength(1)]
        [Unicode(false)]
        public string LatchKey { get; set; } = null!;
        [Column("latchLocker", TypeName = "datetime")]
        public DateTime LatchLocker { get; set; }
    }
}
