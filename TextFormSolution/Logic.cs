using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormSolution
{
    public interface ILogic
    {
        public bool IsExist(string filepath);
        public void SaveFile(string filepath);
        public string OpenFile(string filepath);
    }
    class Logic : ILogic
    {
        public bool IsExist(string filepath)
        {
            bool IsExist = File.Exists(filepath);
                return IsExist;
        }

        public string OpenFile(string filepath)
        {
            using(var smth = new StreamReader(filepath))
            {
                var text = smth.ReadToEnd();
                return text;
            }
        }

        public void SaveFile(string filepath)
        {
            throw new NotImplementedException();
        }
    }
}
