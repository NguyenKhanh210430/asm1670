namespace FPTBook.Models
{
    public class OrderDetailModel
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public OrderModel Order { get; set; }

        public string BookISBN { get; set; }
        public BookModel Book { get; set; }

        public int Quantity { get; set; }

    }
}
