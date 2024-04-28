namespace OutfitDisable
{
    public sealed class OutfitOverrideList
    {
        public bool Default { get; set; } = false;
        public Dictionary<string, bool> ExceptionsList { get; set; } = new Dictionary<string, bool>();
    }
}