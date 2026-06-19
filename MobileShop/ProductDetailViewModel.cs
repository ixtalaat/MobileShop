using MobileShop.Models;

namespace MobileShop;

public class ProductDetailViewModel
{
    // The main product being viewed
    public Product Product { get; set; } = null!;

    // A list of similar products (e.g., from the same brand or category)
    public List<Product> RelatedProducts { get; set; } = new List<Product>();

    // Used to toggle the heart icon if the user has already saved this item
    public bool IsInWishlist { get; set; }
}
