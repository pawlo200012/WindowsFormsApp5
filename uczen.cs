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
    public partial class uczen : Form
    {

        string klasa, imie;
        public uczen(string klasa, string imie)
        {
            this.klasa = klasa;
            this.imie = imie;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {









        }

        private void button1_Click(object sender, EventArgs e)
        {


            string currentPath = Directory.GetCurrentDirectory();
            string nowy = currentPath + "\\" + klasa + "\\" + imie.Replace(' ', '_') + "\\" + comboBox1.SelectedItem.ToString() + ".txt";
            using (StreamWriter writer = File.AppendText(nowy))
            {

                writer.WriteLine(textBox1.Text);



            }



        }

        private void uczen_Load(object sender, EventArgs e)
        {

            string currentPath = Directory.GetCurrentDirectory();
            string nowy = currentPath + "\\" + klasa + "\\przedmioty_klasy.txt";
            string nowy2 = currentPath + "\\" + klasa + "\\spis_uczniow.txt";





            if (File.Exists(nowy))
            {




                string[] wybor = File.ReadAllLines(nowy);
                foreach (var test in wybor)
                {
                    comboBox1.Items.Add(test);



                }

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
