using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Results.Base;

namespace TextFormSolution.FileReaders.Results
{
    public class TextReaderResult : FileReaderResult
    {
        protected override FileTypes FileType => FileTypes.TextFile;
        public string Text { get; set; }
    }
}
