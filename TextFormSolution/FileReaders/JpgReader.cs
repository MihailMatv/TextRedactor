using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Base;
using TextFormSolution.FileReaders.Results;
using TextFormSolution.FileReaders.Results.Base;

namespace TextFormSolution.FileReaders
{
    public class JpgReader : IFileReader
    {
        public FileReaderResult Read(string filepath)
        {
            return new ImageReaderResult()
            {
                Image = new System.Drawing.Bitmap(filepath)
            };
        }
    }
}
