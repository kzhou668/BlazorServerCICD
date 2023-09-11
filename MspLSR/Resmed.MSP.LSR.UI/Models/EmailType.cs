using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("EmailType", Schema = "MSP")]
    [Index(nameof(Type), Name = "unc_EmailType_Type", IsUnique = true)]
    public partial class EmailType
    {
        public EmailType()
        {
            EmailUsers = new HashSet<EmailUser>();
        }

        [Key]
        public int TypeId { get; set; }
        [Required]
        [StringLength(30)]
        public string Type { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [InverseProperty(nameof(EmailUser.Type))]
        public virtual ICollection<EmailUser> EmailUsers { get; set; }
    }
}
