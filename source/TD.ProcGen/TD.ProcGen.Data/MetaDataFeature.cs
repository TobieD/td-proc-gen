namespace TD.ProcGen.Data
{
    public class MetaDataFeature : ProcGenFeature
    {
        public override string? Type { get => "MetaData"; }

        public string Version { get; set; }
        public string Generator { get; set; }
    }
}
