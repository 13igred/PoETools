using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernGui.Core
{
    class FilePathMessage
    {
        public string FileName { get; private set; }

        public FilePathMessage(string fileName)
        {
            FileName = fileName;
        }
    }
}
