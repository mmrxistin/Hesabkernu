// Bismillahir Rahmanir Rahim
// Elhamdulillah, Elhamdulillah, Elhamdulillah
// Elhamdulillahi Rabbil Alamin
// Es selatu ve selamun ala Resulina Muhammedin
// SuphanAllah, Elhamdulillah, Allahu Akbar
// La ilahe illallah, Muhammaden Resulullah
// Allah u Ekber, Allahu Akbar, Allahu Akbar, La ilahe illallah
// Hasbuna Allahu ve ni'mel Vekil, ve ni'mel mevla

using Hesabker.Models;   // 🔑 Burada doğru namespace eklenmeli
using System.Collections.Generic;
using System.Linq;

namespace Hesabker.Data
{
    public class ProductRepository
    {
        private readonly NeonDbContext _db;

        public ProductRepository(NeonDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAllProducts() => _db.Products.ToList();

        public void AddProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
    }
}
