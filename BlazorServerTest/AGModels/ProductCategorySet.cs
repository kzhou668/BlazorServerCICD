using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ProductCategorySet", Schema = "MSPWIP")]
    [Index("ProductCategoryName", "ProductCategoryValue", Name = "nc_ProductCategorySet_ID")]
    [Index("WipworkOrderId", Name = "nc_ProductCategorySet_WIPWorkOrderID")]
    public partial class ProductCategorySet
    {
        [Key]
        [Column("ProductCategoryID")]
        public int ProductCategoryId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ProductCategoryName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ProductCategoryValue { get; set; } = null!;
        public int ProductCategorySequence { get; set; }

        [ForeignKey("WipworkOrderId")]
        [InverseProperty("ProductCategorySets")]
        public virtual WorkOrder WipworkOrder { get; set; } = null!;
    }
}
