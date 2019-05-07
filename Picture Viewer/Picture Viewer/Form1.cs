using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show the open file dialog box
            if (ShowPicture.ShowDialog() == DialogResult.OK)
            {
                //Load the picture into the picture box
                pictureBox1.Image = Image.FromFile(ShowPicture.FileName);
                //Show the name of the fle in the forms caption
                this.Text = string.Concat("Picture Viewer(" + ShowPicture.FileName + ")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
