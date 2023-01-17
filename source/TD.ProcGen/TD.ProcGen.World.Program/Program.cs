using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO.Abstractions;
using TD.ProcGen.Exporters;
using TD.ProcGen.Inject;
using TD.ProcGen.Interface;

namespace TD.ProcGen.Program;

public class Program
{
    static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection
            .AddLogging(configure => configure.AddConsole())
            .Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Trace);

        serviceCollection.AddProcGen();

        serviceCollection.AddScoped<IApplication, Application>();
        serviceCollection.AddScoped<IFileSystem, FileSystem>();
        serviceCollection.AddScoped<IDataExporter, JsonExporter>();

        var provider = serviceCollection.BuildServiceProvider();
        var application = provider.GetService<IApplication>();

        application?.Run("world");

        Console.ReadKey();

    }

}
