using Microsoft.EntityFrameworkCore;

namespace TPLOCAL1.Models
{
    public class TPLOCAL1DbContext : DbContext
    {
        public DbSet<Formulaire> Formulaires { get; set; }

        public TPLOCAL1DbContext(DbContextOptions<TPLOCAL1DbContext> options) : base(options) 
        {
            
        }
    }
}
