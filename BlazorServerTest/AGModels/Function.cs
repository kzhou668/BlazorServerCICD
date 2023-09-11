using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
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
        [StringLength(30)]
        [Unicode(false)]
        public string FunctionCode { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? FunctionName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? FunctionDesciption { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? FunctionGroup { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        [InverseProperty("Function")]
        public virtual ICollection<RoleFunction> RoleFunctions { get; set; }
    }
}
