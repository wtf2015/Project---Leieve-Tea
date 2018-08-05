namespace LeieveTea.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coupon")]
    public partial class Coupon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CouponID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CouponName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Discount { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Active { get; set; }
    }
}
