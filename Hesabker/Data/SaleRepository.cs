// Bismillahir Rahmanir Rahim
// Elhamdulillah, Elhamdulillah, Elhamdulillah
// Elhamdulillahi Rabbil Alamin
// Es selatu ve selamun ala Resulina Muhammedin
// SuphanAllah, Elhamdulillah, Allahu Akbar
// La ilahe illallah, Muhammaden Resulullah
// Allah u Ekber, Allahu Akbar, Allahu Akbar, La ilahe illallah
// Hasbuna Allahu ve ni'mel Vekil, ve ni'mel mevla

using System.Collections.Generic;
using System.Linq;
using Hesabker.Models;

namespace Hesabker.Data
{
    public class SaleRepository
    {
        private readonly NeonDbContext _db;

        public SaleRepository(NeonDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Sale> GetAllSales() => _db.Sales.ToList();

        public void AddSale(Sale sale)
        {
            _db.Sales.Add(sale);
            _db.SaveChanges();
        }
    }
}
