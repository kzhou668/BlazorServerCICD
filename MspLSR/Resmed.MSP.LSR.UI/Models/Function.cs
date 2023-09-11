using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Function", Schema = "MSP")]
    public partial class Function
    {
        public Function()
        {
            RoleFunctions = new HashSet<RoleFunction>();
        }

        [Key]
        public int FunctionId { get; set; }
        [Required]
        [StringLength(30)]
        public string FunctionCode { get; set; }
        [StringLength(100)]
        public string FunctionName { get; set; }
        [StringLength(100)]
        public string FunctionDesciption { get; set; }
        [StringLength(20)]
        public string FunctionGroup { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [InverseProperty(nameof(RoleFunction.Function))]
        public virtual ICollection<RoleFunction> RoleFunctions { get; set; }
    }
}
