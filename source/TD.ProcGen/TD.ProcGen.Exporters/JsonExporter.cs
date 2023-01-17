using Microsoft.Extensions.Logging;
using System.IO.Abstractions;
using System.Text.Json;
using TD.ProcGen.Data;
using TD.ProcGen.Interface;

namespace TD.ProcGen.Exporters
{
    public class JsonExporter : IDataExporter
    {
        private readonly ILogger _logger;
        private readonly IFileSystem _fileSystem;

        public JsonExporter(IFileSystem fileSystem, ILogger<JsonExporter> logger)
        {
            _logger = logger;
            _fileSystem = fileSystem;

        }

        public void Export(ProcGenData data, string directory, string name)
        {
            var json = JsonSerializer.Serialize(data);

            var fileName = Path.Join(directory, $"{name}.json");
            _fileSystem.File.WriteAllText(fileName, json);
        }
    }
}