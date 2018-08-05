namespace LeieveTea.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentType")]
    public partial class PaymentType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentTypeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
