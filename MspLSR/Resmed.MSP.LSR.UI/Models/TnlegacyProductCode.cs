using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("TNLegacyProductCode", Schema = "MSPWIP")]
    [Index(nameof(ProductCode), Name = "unc_TNLegacyProductCode", IsUnique = true)]
    public partial class TnlegacyProductCode
    {
        [Key]
        [Column("TNLegacyProductCodeID")]
        public int TnlegacyProductCodeId { get; set; }
        [Required]
        [StringLength(30)]
        public string ProductCode { get; set; }
    }
}
