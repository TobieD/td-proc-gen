using TD.ProcGen.Data;
using TD.ProcGen.Interface;

namespace TD.ProcGen.World
{
    public class WorldMapGenerator : IGenerator
    {
        public string Key => "World";

        private const string Version = "0.0.0.1-alpha";

        public ProcGenData Generate()
        {
            var result = new ProcGenData();
            result.Features.Add(new MetaDataFeature()
            {
                Version= Version,
                Generator = Key,
                Id = Guid.NewGuid().ToString(),

            });

            //Actual generation logic here

            return result;
        }
    }
}