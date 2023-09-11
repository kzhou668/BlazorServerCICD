using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("UserRole", Schema = "MSP")]
    public partial class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("UserRoles")]
        public virtual Role? Role { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserRoles")]
        public virtual User? User { get; set; }
    }
}
