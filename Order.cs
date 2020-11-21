namespace Petrean_Beatrice_Lab6
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int? CustId { get; set; }

        public int? CarId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Iventory Iventory { get; set; }
    }
}
