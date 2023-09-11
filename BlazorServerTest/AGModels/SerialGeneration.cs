using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SerialGeneration", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "idx_rowlock")]
    public partial class SerialGeneration
    {
        [Key]
        [Column("SerialGenerationID")]
        public int SerialGenerationId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        public int Sequence { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
