using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextSearcher.Models
{
    static class FileLoader
    {

        public static List<string> GetFileNames(string path, string pattern, bool isGetFilesInAllDirectoris)
        {
            List<string> fileNames;
            if(isGetFilesInAllDirectoris)
            {
                fileNames = Directory.GetFiles(path, pattern, SearchOption.AllDirectories).ToList();
            }
            else
            {
                fileNames = Directory.GetFiles(path, pattern).ToList();
            }

            return fileNames;
        }


    }
}
