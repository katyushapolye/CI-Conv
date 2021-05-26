using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvIC_1._0_Alpha
{
    public partial class ConvIC : Form
    {
                     
                
        public ConvIC()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
           
            Program.RunCovIC(checkBox1.Checked);

        }

        private void Select_File_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                FileSelect.ShowDialog();
                textBox1.Text = FileSelect.FileName;
                Program.FileAdress = FileSelect.FileName;


            }
            else
            {
                //do an alteration hero, to just redirect the dialoguebox to the folder previously selected
                FileSelect.ShowDialog();
                Program.FileAdress = FileSelect.FileName;
                textBox1.Text = FileSelect.FileName;
            }

        }

        private void ConvIC_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Alpha Version","Disclaimer");
        }

    }
}
 