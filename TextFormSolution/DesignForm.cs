using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextFormSolution
{
    public interface IDesignForm
    {
        public string TextContent { get; set; }
        public Image BitMapContent { get; set; }
        public string FilePath { get; }
        public bool PictureBoxVisibility { get; set; }
        public bool TextBoxVisibility { get; set; }
        public event Action OpenFile;
        public event Action SaveFile;
        public string Count { get; set; }
    }

    public partial class DesignForm : Form, IDesignForm
    {
        public DesignForm()
        {
            InitializeComponent();
            butOpenFile.Click += ButOpenFile_Click;
            butSaveFile.Click += ButSaveFile_Click;
            butSelectFile.Click += ButSelectFile_Click;
            //pictureBox.Visible = false;
        }

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = ".txt|*.txt|.pdf|*.pdf|.jpg|*.jpg|.docx|*.docx|All files|*.*";
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

        public string TextContent
        { 
          get { return fldFileText.Text; } 
          set { fldFileText.Text = value; } 
        }
        public Image BitMapContent
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }
        public string FilePath 
        { 
          get { return fldFilePath.Text; }
        }
        public bool TextBoxVisibility
        { 
          get { return fldFileText.Visible; } 
          set { fldFileText.Visible = value; } 
        }
        public bool PictureBoxVisibility
        {
            get { return pictureBox.Visible; }
            set { pictureBox.Visible = value; }
        }
        public event Action OpenFile;
        public event Action SaveFile;
        public string Count
        {
            get { return lblSymbolCount.Text; }
            set { lblSymbolCount.Text = value; }
        }
    }
}
