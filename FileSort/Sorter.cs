using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSort
{
    class Sorter
    {
        string[] extensions;
        string fromFolderPath;
        string toFolderPath;
        public Sorter(string extensions, string fromFolderPath, string toFolderPath)
        {
            this.extensions = extensions.Split();
            this.fromFolderPath = fromFolderPath;
            this.toFolderPath = toFolderPath;
        }
        public void Sort() 
        {
            List<string> Files = new List<string>();
            List<string> array = new List<string>();
            foreach (var ext in extensions)
            {
                array = Directory.GetFiles($@"{fromFolderPath}").Where(x => x.EndsWith(ext)).ToList();
                foreach (var a in array)
                {
                    Files.Add(a);
                }
            }
            foreach (var file in Files)
            {
                File.Move(file, Path.Combine(toFolderPath, Path.GetFileName(file)));
            }

        }
    }
}
