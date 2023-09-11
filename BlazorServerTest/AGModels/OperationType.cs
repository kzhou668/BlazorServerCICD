using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("OperationType", Schema = "MSPWIP")]
    [Index("OperationType1", "OperationDescription", Name = "unc_operationType_OptType_optDesc", IsUnique = true)]
    public partial class OperationType
    {
        public OperationType()
        {
            Stations = new HashSet<Station>();
        }

        [Key]
        [Column("OperationTypeID")]
        public int OperationTypeId { get; set; }
        [Column("OperationType")]
        [StringLength(30)]
        [Unicode(false)]
        public string OperationType1 { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string OperationDescription { get; set; } = null!;

        [InverseProperty("OperationType")]
        public virtual ICollection<Station> Stations { get; set; }
    }
}
