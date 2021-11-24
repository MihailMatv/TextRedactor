using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Base;

namespace TextFormSolution.FileReaders.Factory
{
    public class FileReaderFactory
    {
        public IFileReader CreateFileReader(string extension)
        {
            switch (extension)
            {
                case ".txt":
                    return new TextFileReader();
                case ".pdf":
                    return new PdfFileReader();
                case ".jpg":
                    return new JpgReader();
            }
            return default;
        }
    }
}
