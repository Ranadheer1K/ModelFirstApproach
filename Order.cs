namespace ModelFirstApproach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int order_no { get; set; }

        public int qty_order { get; set; }

        [Column(TypeName = "date")]
        public DateTime order_date { get; set; }

        public int? customer_id { get; set; }
    }
}
