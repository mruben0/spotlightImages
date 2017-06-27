using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GetImagesightImages
{
    public partial class DoneMessage : Form
    {
        public string Path;
        public DoneMessage(string labeltext)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            label.Text = $"Done, Your Pictures are saved in {labeltext}";
            Path = labeltext;
        }
        
        private void DoneMessage_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path))
            {
                Process.Start(Path);
            } else
            {
                Directory.CreateDirectory(Path);
                Process.Start(Path);
            }
           
        }
    }
}
