using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TextSearcher.Models
{
    public class TxtSearcher
    {
        public string RootDirectory { get; set; }
        public string PatternFileName { get; set; }
        public string Pattern { get; set; }
        public string CurProcessingFileName { get; private set; }
        public int CountProcessingFile { get; private set; }
        public string FoundFileNames { get; private set; } = "";
        public string SearchStatus { get; private set; } = "Stopped";
        public TimeSpan SpendTime { get; private set; }

        public TxtSearcher(string path,string patternFileName, string pattern)
        {
            RootDirectory = path;
            PatternFileName = patternFileName;
            Pattern = pattern;
        }

        public TxtSearcher()
        {

        }

        public void PauseSearch()
        {
            SearchStatus = "Pause";
        }

        public void StopSearch()
        {
            SearchStatus = "Stopped";
        }
   
        public void Search()
        {
            Stopwatch stopWatch = new Stopwatch();

            if(SearchStatus != "Pause")
            {
                FoundFileNames = "";
                CountProcessingFile = 0;
            }
            SearchStatus = "Running";

            RegexOptions options = RegexOptions.IgnoreCase;
            Regex regex = new Regex(Pattern, options);
            

            List<string> files = FileLoader.GetFileNames(RootDirectory, PatternFileName, true);

            stopWatch.Start();
            for(int i = CountProcessingFile; i<files.Count;i++)
            {
                if(SearchStatus == "Running")
                {
                    CountProcessingFile++;
                    CurProcessingFileName = files[i];
                    using (StreamReader sr = new StreamReader(files[i],Encoding.Default))
                    {
                        if (regex.IsMatch(sr.ReadToEnd()))
                        {
                            FoundFileNames += files[i] + "\n";
                        }
                    }
                    
                }
                else
                {
                    break;
                }
                
            }
            stopWatch.Stop();
            SpendTime = stopWatch.Elapsed;
            
            if(CountProcessingFile == files.Count)
            {
                StopSearch();
            }
        }

    }
}
