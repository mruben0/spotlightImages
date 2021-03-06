﻿using System;
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
    public partial class form : Form
    {
       
        public static string user = Environment.UserName;

        public static string place = @"C:\Users\" + user + @"\Desktop\WindowsPics";

              

        public form()
        {
            InitializeComponent();
            textBox1.Text = place;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        private void getImgs_Click(object sender, EventArgs e)
        {
            
            PicManager picManager = new PicManager(user, place);
            if (agree.Checked)
            {
                try
                {
                    picManager.GetImages();
                    DoneMessage done = new DoneMessage(place);
                    done.Show();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
                
                
              
          
            }
            else MessageBox.Show("You should be agree");   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (agree.Checked)
            {
                getImgs.BackColor = Color.Azure;
            }
            else getImgs.BackColor = Color.LightGray;
            
        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult reslt = browser.ShowDialog();
            if (reslt == DialogResult.OK)
            {
                place = browser.SelectedPath;
                textBox1.Text = place;
            }
            else MessageBox.Show("If you wont choose destination, pictures will be saved in desktop >> WindowsPics");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            place = textBox1.Text;
        }

        private void conditions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just joking, there aren't any, Ha Ha Ha.");
        }

        private void footer_Click(object sender, EventArgs e)
        {
            Process.Start("https://mruben0.github.io/");
        }
    }
}
