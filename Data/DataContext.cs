using efcoreApp.Data;
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    public class DataContext: DbContext
    {
            public DataContext(DbContextOptions<DataContext> options): base(options)
            {
                
            }
        public DbSet<Kurs> Kurslar => Set<Kurs>();
        public DbSet<Ogrenci> Ogrenciler =>Set<Ogrenci>();
        public DbSet<KursKayit> KursKayitleri => Set<KursKayit>();
        public DbSet<Ogretmen> Ogretmenler => Set<Ogretmen>();
    }
}