using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Results.Base;

namespace TextFormSolution.FileReaders.Base
{
    public interface IFileReader
    {
        FileReaderResult Read(string filepath);
    }
}
