using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Role", Schema = "MSP")]
    [Index(nameof(Role1), Name = "unc_Role_Role", IsUnique = true)]
    public partial class Role
    {
        public Role()
        {
            RoleFunctions = new HashSet<RoleFunction>();
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public int RoleId { get; set; }
        [Required]
        [Column("Role")]
        [StringLength(3)]
        public string Role1 { get; set; }
        [Required]
        [StringLength(100)]
        public string RoleDescription { get; set; }
        public bool IsMandatory { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [InverseProperty(nameof(RoleFunction.Role))]
        public virtual ICollection<RoleFunction> RoleFunctions { get; set; }
        [InverseProperty(nameof(UserRole.Role))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
