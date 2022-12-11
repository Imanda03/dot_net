using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        [DisplayName("Category Name")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
