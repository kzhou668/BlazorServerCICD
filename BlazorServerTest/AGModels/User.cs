using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
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
        [StringLength(50)]
        [Unicode(false)]
        public string UserAdName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string FullName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<EmailUser> EmailUsers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
