namespace TextSearcher.Views
{
    interface ITxtSearcher
    {
        string RootDirectory { get; set; }
        string PatternFileName { get; set; }
        string Pattern { get; set; }
        int CountProcessingFile { get; set; }
        string FoundFiles { get; set; }
        string SearchStatus { get; set; }
        string ElapsedTime { get; set; }
    }
}
