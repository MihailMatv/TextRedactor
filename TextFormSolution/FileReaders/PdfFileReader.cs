using iTextSharp.text.pdf.parser;
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
    public class PdfFileReader : IFileReader
    {
        public FileReaderResult Read(string filepath)
        {
            var pdfReader = new iTextSharp.text.pdf.PdfReader(filename: filepath);
            var stringBuilder = new StringBuilder(); 
            for (int i = 1; i <= pdfReader.NumberOfPages; i++)
            {
                stringBuilder.Append(PdfTextExtractor.GetTextFromPage(pdfReader, pageNumber: i));
            }
            return new TextReaderResult()
            {
                Text = stringBuilder.ToString()
            };
           
        }
    }
}
