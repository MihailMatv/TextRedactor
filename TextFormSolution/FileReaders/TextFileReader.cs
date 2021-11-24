using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Base;
using TextFormSolution.FileReaders.Results;
using TextFormSolution.FileReaders.Results.Base;

namespace TextFormSolution.FileReaders
{
    public class TextFileReader : IFileReader
    {
        public FileReaderResult Read(string filepath)
        {
            using (var file = new StreamReader(filepath))
            {
                return new TextReaderResult()
                {
                    Text = file.ReadToEnd()
                };

            }
        }
    }
}
