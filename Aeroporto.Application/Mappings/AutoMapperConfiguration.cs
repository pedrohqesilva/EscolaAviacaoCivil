using AutoMapper;

namespace Aeroportos.Application.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.AddMaps(new[]
            {
                "Aeroportos.Application",
                //"Aeroportos.AntiCorruptionLayer"
            }));

            //Mapper.AssertConfigurationIsValid();
        }
    }
}