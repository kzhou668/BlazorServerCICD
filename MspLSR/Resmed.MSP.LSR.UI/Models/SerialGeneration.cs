using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("SerialGeneration", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "idx_rowlock")]
    public partial class SerialGeneration
    {
        [Key]
        [Column("SerialGenerationID")]
        public int SerialGenerationId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        public int Sequence { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
