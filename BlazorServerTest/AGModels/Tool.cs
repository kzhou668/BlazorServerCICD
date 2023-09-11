using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Tool", Schema = "MSPLSR")]
    public partial class Tool
    {
        [Key]
        public int ToolId { get; set; }
        [StringLength(50)]
        public string? PartNo { get; set; }
        [StringLength(200)]
        public string ToolNo { get; set; } = null!;
        [StringLength(400)]
        public string? ToolDesc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
    }
}
