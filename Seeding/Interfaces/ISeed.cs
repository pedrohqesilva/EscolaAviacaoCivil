using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Context.Seeding.Interfaces
{
    public interface ISeed
    {
        void Seed(ModelBuilder modelBuilder);
    }
}