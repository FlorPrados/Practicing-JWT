using Jwt.Models;

namespace Jwt.Constants
{
    public class ProductConstants
    {
        public static List<Product> products = new List<Product>()
        {
            new Product() {Name = "Ergonimic chair", Description = "Comfortable chair for large hours of work "},
            new Product() {Name = "Monitor", Description = "Monitor to have a bigger view and a better experience"},
            new Product() {Name = "Notebook", Description = "Work tool"}
        };
    }
}
