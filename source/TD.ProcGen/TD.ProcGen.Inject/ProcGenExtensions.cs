using Microsoft.Extensions.DependencyInjection;
using TD.ProcGen.Interface;
using TD.ProcGen.World;

namespace TD.ProcGen.Inject
{
    public static class ProcGenExtensions
    {
        public static IServiceCollection AddProcGen(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped<IGenerator, WorldMapGenerator>();

            serviceCollection.AddScoped<IGeneratorFactory, GeneratorFactory>();

            return serviceCollection;
        }
    }
}