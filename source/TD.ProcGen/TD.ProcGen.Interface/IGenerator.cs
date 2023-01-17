using TD.ProcGen.Data;

namespace TD.ProcGen.Interface
{
    public interface IGenerator
    {
        public string Key { get; }
        public ProcGenData Generate();
    }
}