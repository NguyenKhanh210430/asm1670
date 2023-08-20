using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPTBook.Models
{
    public class BookModel
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public double Cost { get; set; }
        public string Author { get; set; }

        public string CategoryID { get; set; }

        [NotMapped]
        public string CategoryName { get; set; }
        public CategoryModel Category { get; set; }

        public string ImageURL { get; set; }
        public string Description { get; set; }

        public string StoreID { get; set; }

        [NotMapped]
        public string StoreName { get; set; }
        public StoreModel Store { get; set; }
    }
}
