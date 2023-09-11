using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Lookups", Schema = "MSPLSR")]
    public partial class Lookup
    {
        [Key]
        public long AutoId { get; set; }
        [StringLength(50)]
        public string AppName { get; set; }
        [StringLength(50)]
        public string FieldName { get; set; }
        [StringLength(50)]
        public string FieldValue { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
