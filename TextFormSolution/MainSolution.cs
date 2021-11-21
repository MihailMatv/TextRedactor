using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormSolution
{
    class MainSolution
    {
        public IDesignForm design;
        public ILogic logic;

        public MainSolution(IDesignForm design, ILogic logic)
        {
            this.design = design;
            this.logic = logic;

            design.OpenFile += Design_OpenFile;
            design.SaveFile += Design_SaveFile;
        }

        private void Design_SaveFile()
        {
            throw new NotImplementedException();
        }

        private void Design_OpenFile()
        {
            string filepath = design.FilePath;
            bool exists = logic.IsExist(filepath);
            if(!exists)
            {
                Console.WriteLine("Такого пути не существует");
            }
            var text = logic.OpenFile(filepath);
            design.Content = text;
        }
    }
}
