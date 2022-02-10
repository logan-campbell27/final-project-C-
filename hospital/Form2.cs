using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void indexButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(index_txt.Text) - 1;
            
            Form1 f1 = new Form1();

            f1.receiveData(index);

            

            this.Close();
        }
    }
}
