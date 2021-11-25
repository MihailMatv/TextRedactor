using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using TextFormSolution.FileReaders.Factory;
using TextFormSolution.FileReaders.Results.Base;

namespace TextFormSolution
{
    public interface ILogic
    {
        public bool IsExist(string filepath);
        public void SaveFile(string filepath, string content);
        public FileReaderResult OpenFile(string filepath);
    }
    class Logic : ILogic
    {
        public bool IsExist(string filepath)
        {
            bool IsExist = File.Exists(filepath);
            return IsExist;
        }

        public FileReaderResult OpenFile(string filepath)
        {
            var extension = System.IO.Path.GetExtension(filepath);
            var fabric = new FileReaderFactory();
            var reader = fabric.CreateFileReader(extension);
            var a =  reader.Read(filepath);
            return a;
        }

        public void SaveFile(string filepath, string content)
        {
            using (var file = new StreamWriter(filepath))
            {
                file.WriteLine(content);
            }
        }

    }
}
