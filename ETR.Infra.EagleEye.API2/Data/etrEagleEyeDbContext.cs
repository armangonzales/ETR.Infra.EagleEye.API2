using ETR.Infra.EagleEye.API2.Models;
using Microsoft.EntityFrameworkCore;

namespace ETR.Infra.EagleEye.API2.Data
{
    public class etrEagleEyeDbContext : DbContext
    {
        public etrEagleEyeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<PulseLogs> PulseLog { get; set; }
    }
}
