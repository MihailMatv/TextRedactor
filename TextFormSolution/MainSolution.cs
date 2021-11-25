using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormSolution.FileReaders.Results;

namespace TextFormSolution
{
    class MainSolution
    {
        public IDesignForm design;
        public ILogic logic;
        public IMessage message;

        public MainSolution(IDesignForm design, ILogic logic, IMessage message)
        {
            this.design = design;
            this.logic = logic;
            this.message = message;

            design.OpenFile += Design_OpenFile;
            design.SaveFile += Design_SaveFile;
        }

        private void Design_SaveFile()
        {
            string filepath = design.FilePath;
            string content = design.TextContent;
            logic.SaveFile(filepath, content);
            message.Inform();
        }

        private void Design_OpenFile()
        {
            string filepath = design.FilePath;
            bool exists = logic.IsExist(filepath);
            if(!exists)
            {
                message.Error();
                return;
            }
            var fileReaderResult = logic.OpenFile(filepath);
            if (fileReaderResult is TextReaderResult result)
            {
                design.PictureBoxVisibility = false;
                design.TextBoxVisibility = true;
                design.TextContent = result.Text;
                design.Count = Convert.ToString(result.Text.Length);
            }
            if(fileReaderResult is ImageReaderResult imageResult)
            {
                design.TextBoxVisibility = false;
                design.PictureBoxVisibility = true;
                design.BitMapContent = imageResult.Image;
            }

        }
    }
}
