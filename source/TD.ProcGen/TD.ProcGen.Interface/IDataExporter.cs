using TD.ProcGen.Data;

namespace TD.ProcGen.Interface
{
    public interface IDataExporter
    {
        public void Export(ProcGenData data, string directory, string name);
    }
}
