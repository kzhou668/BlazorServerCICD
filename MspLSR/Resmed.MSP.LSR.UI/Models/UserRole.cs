using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("UserRole", Schema = "MSP")]
    public partial class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("UserRoles")]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserRoles")]
        public virtual User User { get; set; }
    }
}
