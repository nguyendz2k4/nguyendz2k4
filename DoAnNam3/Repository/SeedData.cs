using Microsoft.EntityFrameworkCore;

namespace DoAnNam3.Repository
{
    public class SeedData
    {
        public static void SeedingData(DbContext _context)
        {
            _context.Database.Migrate();
            
        }
    }
}
