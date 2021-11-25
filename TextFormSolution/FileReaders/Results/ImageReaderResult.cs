using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Results.Base;

namespace TextFormSolution.FileReaders.Results
{
    public class ImageReaderResult : FileReaderResult
    {
        public Bitmap Image { get; set; }
    }
}
