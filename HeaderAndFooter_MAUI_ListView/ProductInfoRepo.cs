using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderAndFooter_MAUI_ListView
{
	public class ProductInfoRepo
	{
		public ObservableCollection<ProductInfo> Products { get; set; }
		public ProductInfoRepo()
		{
			GenerateBookInfo();
		}
		internal void GenerateBookInfo()
		{
			Products = new ObservableCollection<ProductInfo>();
			Products.Add(new ProductInfo() { ProductName = "Fashion", ProductDescription = "Browse through our collection of fashionable clothing and accessories to add some style to your wardrobe. Add your favorite items to your cart, or buy now to purchase immediately." });
			Products.Add(new ProductInfo() { ProductName = "Electronics", ProductDescription = "From the latest smartphones and laptops to home appliances and gaming consoles, our electronics section has everything you need. Add to cart or buy now to purchase immediately." });
			Products.Add(new ProductInfo() { ProductName = "Home and Kitchen", ProductDescription = "Browse our selection of home and kitchen products, including cookware, utensils, and home decor. Add to cart or buy now to purchase immediately." });
			Products.Add(new ProductInfo() { ProductName = "Sports", ProductDescription = "Get ready to hit the field or gym with our selection of sports equipment and apparel. Add your favorite items to your cart, or buy now to purchase immediately." });
			Products.Add(new ProductInfo() { ProductName = "Kids", ProductDescription = "Shop for your little ones with our selection of kids' clothing, toys, and accessories. Add to cart or buy now to purchase immediately." });
			Products.Add(new ProductInfo() { ProductName = "Beauty and Personal Care", ProductDescription = "Keep your skin looking radiant with moisturizers, toners, and cleansers tailored to your skin type.Enhance your appeal with a range of perfumes, body sprays, and deodorants that cater to different moods and occasions." });
			Products.Add(new ProductInfo() { ProductName = "Pet Supplies", ProductDescription = "Purchase items for pets, such as food, toys, beds, and grooming supplies." });
			Products.Add(new ProductInfo() { ProductName = "Automotive", ProductDescription = "Browse our items for cars and other vehicles, such as car parts, accessories, and tools." });
			Products.Add(new ProductInfo() { ProductName = "Books and Media", ProductDescription = "Browse our selection of books, e-books, audiobooks, movies, TV shows, and music." });
			Products.Add(new ProductInfo() { ProductName = "Food and Beverages", ProductDescription = "Get ready to enjoy our food and drinks, such as groceries, snacks, wine, beer, and other beverages." });
		}

	}
}
