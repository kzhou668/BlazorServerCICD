using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("EmailUser", Schema = "MSP")]
    public partial class EmailUser
    {
        [Key]
        public int EmailUserId { get; set; }
        public int? TypeId { get; set; }
        public int? UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [ForeignKey("TypeId")]
        [InverseProperty("EmailUsers")]
        public virtual EmailType? Type { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("EmailUsers")]
        public virtual User? User { get; set; }
    }
}
