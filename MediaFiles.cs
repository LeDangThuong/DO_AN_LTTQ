using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DO_AN_LTTQ
{
    internal class MediaFiles
    {
        private string filePath; // Tạo đường dẫn file
        internal MediaFiles (string filePath)
        {
            this.filePath = filePath;
        }

        internal string FileName { get => Path.GetFileName(filePath); }
        internal string FilePath { get => filePath; }
    }
}
