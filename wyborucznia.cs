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
    public partial class wyborucznia : Form
    {

        string klasa;

        public wyborucznia(string klasa)
        {

            this.klasa = klasa;

            InitializeComponent();
        }

        private void wyborucznia_Load(object sender, EventArgs e)
        {



            string currentPath = Directory.GetCurrentDirectory();
            string nowy = currentPath + "\\" + klasa + "\\przedmioty_klasy.txt";
            string nowy2 = currentPath + "\\" + klasa + "\\spis_uczniow.txt";





            if (File.Exists(nowy))
            {




                string[] wybor = File.ReadAllLines(nowy);
                foreach (var test in wybor)
                {
                    comboBox2.Items.Add(test);



                }

            }

            if (File.Exists(nowy2))
            {

                string[] wybor2 = File.ReadAllLines(nowy2);
                foreach (var test in wybor2)
                {


                    comboBox1.Items.Add(test.Replace(',', ' '));



                }

            }

            

           



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string currentPath = Directory.GetCurrentDirectory();

            if (!Directory.Exists(Path.Combine(currentPath, klasa)))
                Directory.CreateDirectory(Path.Combine(currentPath, klasa));

            string nowy = currentPath + "\\" + klasa + "\\spis_uczniow.txt";
            using(StreamWriter writer = File.AppendText(nowy))
            {

                writer.WriteLine(textBox1.Text+","+textBox2.Text);
                string folder = currentPath + "\\" + klasa;
                if (!Directory.Exists(Path.Combine(folder, textBox1.Text + "_" + textBox2.Text)))
                    Directory.CreateDirectory(Path.Combine(folder, textBox1.Text + "_" + textBox2.Text));

            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            string currentPath = Directory.GetCurrentDirectory();
            string nowy = currentPath + "\\" + klasa + "\\przedmioty_klasy.txt";
            using (StreamWriter writer = File.AppendText(nowy))
            {

                writer.WriteLine(textBox3.Text);
                
                

            }





        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var test = new uczen(klasa, comboBox1.SelectedItem.ToString());
            test.Location = this.Location;
            test.StartPosition = FormStartPosition.Manual;
            test.FormClosing += delegate { this.Show(); };
            test.Show();
            this.Hide();

        }
    }
}
