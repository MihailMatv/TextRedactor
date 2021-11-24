using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFormSolution
{
    public interface IMessage
    {
        public void Inform();
        public void Error();
    }

    public class Message : IMessage
    {
        public void Error()
        {
            MessageBox.Show("This file is not exists", "Error", MessageBoxButtons.OK);
        }

        public void Inform()
        {
            MessageBox.Show("File save", "Information", MessageBoxButtons.OK);
        }
    }
}
