namespace LeieveTea.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal SellingPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Active { get; set; }
    }
}
