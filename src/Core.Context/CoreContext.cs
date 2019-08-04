using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Core.Context
{
    public class CoreContext : DbContext
    {
        public CoreContext() : base()
        {
        }

        public CoreContext(DbContextOptions options) : base(options)
        {
        }

        public void StringConfiguration(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                property.IsUnicode(true);
            }
        }
    }
}