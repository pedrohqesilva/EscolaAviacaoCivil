using Microsoft.EntityFrameworkCore;

namespace Core.Context.Seeding.Interfaces
{
    public interface ISeed
    {
        void Seed(ModelBuilder modelBuilder);
    }
}