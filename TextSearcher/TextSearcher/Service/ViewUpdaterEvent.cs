using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSearcher.Service
{
    public class ViewUpdaterEvent:EventArgs
    {
        public ViewUpdaterEvent(string curProcessingFileName, int countProcessingFile, int percentProgress, string foundFileNames )
        {
            CurProcessingFileName = curProcessingFileName;
            CountProcessingFile = countProcessingFile;
            FoundFileNames = foundFileNames;
            PercentProgress = percentProgress;
        }

        public string CurProcessingFileName { get; private set; }
        public int CountProcessingFile { get; private set; }
        public string FoundFileNames { get; private set; }
        public int PercentProgress { get; set; }
    }
}
