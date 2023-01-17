namespace TD.ProcGen.Interface
{
    public interface IGeneratorFactory
    {
        public IGenerator GetGeneratorForKey(string key);
    }
}