using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("TNLegacyProductCode", Schema = "MSPWIP")]
    [Index("ProductCode", Name = "unc_TNLegacyProductCode", IsUnique = true)]
    public partial class TnlegacyProductCode
    {
        [Key]
        [Column("TNLegacyProductCodeID")]
        public int TnlegacyProductCodeId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
    }
}
