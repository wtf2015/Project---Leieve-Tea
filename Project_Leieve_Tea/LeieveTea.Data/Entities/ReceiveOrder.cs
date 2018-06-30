namespace LeieveTea.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveOrder")]
    public partial class ReceiveOrder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CouponID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime OrderDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string City { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string Province { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(7)]
        public string PostalCode { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(14)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string DeliveryType { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal GST { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal DeliveryFee { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal PaymentType { get; set; }
    }
}
