using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Role", Schema = "MSP")]
    [Index("Role1", Name = "unc_Role_Role", IsUnique = true)]
    public partial class Role
    {
        public Role()
        {
            RoleFunctions = new HashSet<RoleFunction>();
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public int RoleId { get; set; }
        [Column("Role")]
        [StringLength(3)]
        [Unicode(false)]
        public string Role1 { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string RoleDescription { get; set; } = null!;
        public bool IsMandatory { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [InverseProperty("Role")]
        public virtual ICollection<RoleFunction> RoleFunctions { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
