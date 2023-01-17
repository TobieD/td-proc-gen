using TD.ProcGen.Interface;

namespace TD.ProcGen.Inject
{
    internal class GeneratorFactory : IGeneratorFactory
    {
        private Dictionary<string, IGenerator> _lookup;

        public GeneratorFactory(IEnumerable<IGenerator> generators)
        {
            _lookup = new Dictionary<string, IGenerator>();

            foreach (var generator in generators)
            {
                _lookup.Add(generator.Key.ToLower(), generator);
            }
        }

        public IGenerator GetGeneratorForKey(string key)
        {
            //This can be cleaner but POC ;) 
            return _lookup[key];
        }
    }
}
