using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Context.Seeding.Interfaces
{
    public interface ISeed
    {
        void Configure(ModelBuilder modelBuilder);
    }
}