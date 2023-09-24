using BlazingShop.Models;

namespace BlazingShop.Pages.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string name, string description, string image, double price, int categoryId, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            CategoryId = categoryId;
            Category = category;
        }



        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();

    }
}