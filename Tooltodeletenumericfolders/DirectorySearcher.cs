using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tooltodeletenumericfolders
{
    public static class DirectorySearcher
    {
        static public DirectoryInfo[] GetDirectories(string rootDirectory,DateTime date)
        {
            Regex regex = new Regex("^[0-9]+$");



            var directories = System.IO.Directory.GetDirectories(rootDirectory).Select(directory => new DirectoryInfo(directory))
                 .Where(directory => (regex.IsMatch(directory.Name) && (directory.LastAccessTime<date)));

            return directories.ToArray();
        }

    }
}
