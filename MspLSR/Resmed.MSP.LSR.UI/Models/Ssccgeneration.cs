using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("SSCCGeneration", Schema = "MSPWIP")]
    [Index(nameof(Ssccnumber), Name = "NC_SSCCGeneration_Rowlock")]
    public partial class Ssccgeneration
    {
        [Key]
        [Column("SSCCGeneration")]
        public int Ssccgeneration1 { get; set; }
        [Column("SSCCNumber")]
        public int Ssccnumber { get; set; }
    }
}
