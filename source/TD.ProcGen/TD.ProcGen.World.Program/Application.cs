using TD.ProcGen.Interface;

namespace TD.ProcGen.Program
{
    public interface IApplication
    {
        public void Run(string type);
    }

    public class Application : IApplication
    {
        private readonly IGeneratorFactory _generatorFactory;
        private readonly IDataExporter _exporter;

        public Application(IGeneratorFactory generatorFactory, IDataExporter exporter)
        {
            _generatorFactory = generatorFactory;
            _exporter = exporter;
        }

        public void Run(string type)
        {
            var generator = _generatorFactory.GetGeneratorForKey(type);
            
            //generate
            var data = generator.Generate();

            //Export data
            _exporter.Export(data, @"C:\temp\worldbuilderDebug", @"test");
        }
    }
}
