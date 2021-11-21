using System;
using System.Windows.Forms;

namespace TextFormSolution
{
    public interface IDesignForm
    {
        public string Content { get; set; }
        public string FilePath { get; }
        public event Action OpenFile;
        public event Action SaveFile;
    }

    public partial class DesignForm : Form, IDesignForm
    {
        public DesignForm()
        {
            InitializeComponent();
            butOpenFile.Click += ButOpenFile_Click;
            butSaveFile.Click += ButSaveFile_Click;
            butSelectFile.Click += ButSelectFile_Click;
        }

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = ".txt|*.txt|All files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldFilePath.Text = dlg.FileName;
                OpenFile?.Invoke();
            }
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile?.Invoke();
        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile?.Invoke();
        }

        public string Content
        { 
          get { return fldFileText.Text; } 
          set { fldFileText.Text = value; } 
        }
        public string FilePath 
        { 
          get { return fldFilePath.Text; }
        }
        public event Action OpenFile;
        public event Action SaveFile;

    }
}
