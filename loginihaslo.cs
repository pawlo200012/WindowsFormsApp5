using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class loginihaslo : Form
    {
        public loginihaslo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            char login;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            char haslo;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string nazwa = "plik.txt";
            if (!File.Exists(nazwa)) return;
            TextReader tr = null;
            string linia = "";
            tr = new StreamReader(nazwa);
            while (!string.IsNullOrEmpty(linia = tr.ReadLine()))
            {
                string[] test = linia.Split(',');
                if(test[0] == textBox1.Text && test[1] == textBox2.Text)
                {

                    var przeniesienie = new klasy();
                    przeniesienie.Location = this.Location;
                    przeniesienie.StartPosition = FormStartPosition.Manual;
                    przeniesienie.FormClosing += delegate { this.Show(); };
                    przeniesienie.Show();
                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    break;


                }


            }
            */



        }
    }
}
