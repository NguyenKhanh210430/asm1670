namespace FPTBook.Models
{
    public class CartModel
    {   
        public string Id { get; set; }
        public string UserId { get; set; }
        public AppUserModel User { get; set; }
        public string BookISBN { get; set; }
        public BookModel Book { get; set; }
        public int Quantity { get; set; }
    }
}
