using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("EmailUser", Schema = "MSP")]
    public partial class EmailUser
    {
        [Key]
        public int EmailUserId { get; set; }
        public int? TypeId { get; set; }
        public int? UserId { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(EmailType.EmailUsers))]
        public virtual EmailType Type { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("EmailUsers")]
        public virtual User User { get; set; }
    }
}
