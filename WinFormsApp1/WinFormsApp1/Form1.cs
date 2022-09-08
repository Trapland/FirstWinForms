using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class MyWindow : Form
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Info.txt", false);
            sw.WriteLine(FIO.Text);
            sw.WriteLine(Email.Text);
            sw.WriteLine(Number.Text);
            sw.Close();
        }
    }
}
