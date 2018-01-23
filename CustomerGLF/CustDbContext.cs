using Microsoft.EntityFrameworkCore;

namespace CustomerGLF
{
    public class CustDbContext : DbContext
    {
        public CustDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}