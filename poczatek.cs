using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class poczatek : Form
    {
        Form form;
        public poczatek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = new loginihaslo();
            test.Location = this.Location;
            test.StartPosition = FormStartPosition.Manual;
            test.FormClosing += delegate { this.Show(); };
            test.Show();
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
