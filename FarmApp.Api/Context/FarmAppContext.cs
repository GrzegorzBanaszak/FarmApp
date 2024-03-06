using FarmApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmApp.Api.Context
{
    public class FarmAppContext : DbContext
    {
        public FarmAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Machine> Machines { get; set; }

    }
}
