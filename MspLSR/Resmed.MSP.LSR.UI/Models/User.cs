using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("User", Schema = "MSP")]
    public partial class User
    {
        public User()
        {
            EmailUsers = new HashSet<EmailUser>();
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserAdName { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        [Required]
        [StringLength(5)]
        public string OrgId { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [InverseProperty(nameof(EmailUser.User))]
        public virtual ICollection<EmailUser> EmailUsers { get; set; }
        [InverseProperty(nameof(UserRole.User))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
