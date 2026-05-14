// Bismillahir Rahmanir Rahim
// Elhamdulillah, Elhamdulillah, Elhamdulillah
// Elhamdulillahi Rabbil Alamin
// Es selatu ve selamun ala Resulina Muhammedin
// SuphanAllah, Elhamdulillah, Allahu Akbar
// La ilahe illallah, Muhammaden Resulullah
// Allah u Ekber, Allahu Akbar, Allahu Akbar, La ilahe illallah
// Hasbuna Allahu ve ni'mel Vekil, ve ni'mel mevla

using Hesabker.Models;   // 🔑 Burada eklenmeli
using Microsoft.EntityFrameworkCore;

namespace Hesabker.Data
{
    public class NeonDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }   // Artık Hesabker.Models.Product
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=your-neon-host;Database=neondb;Username=your-username;Password=your-password;SSL Mode=Require;Trust Server Certificate=true");
        }
    }
}
