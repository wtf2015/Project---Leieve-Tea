namespace LeieveTea.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string City { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string Province { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(7)]
        public string PostalCode { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(14)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Points { get; set; }
    }
}
