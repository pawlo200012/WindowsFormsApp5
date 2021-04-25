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
    public partial class klasy : Form
    {
        public klasy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = File.AppendText("klasy.txt"))
            {

                writer.WriteLine(textBox1.Text);


            }

           
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           



        }

        private void klasy_Load(object sender, EventArgs e)
        {

            string[] wybor = File.ReadAllLines("klasy.txt");
            foreach (var test in wybor)
            {
                comboBox1.Items.Add(test);



            }

        }

        private void klasy_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();

            if (!Directory.Exists(Path.Combine(currentPath, comboBox1.SelectedItem.ToString())))
                Directory.CreateDirectory(Path.Combine(currentPath, comboBox1.SelectedItem.ToString()));

            

            //comboBox1.SelectedValue.ToString();

            var test = new wyborucznia(comboBox1.SelectedItem.ToString());
            test.Location = this.Location;
            test.StartPosition = FormStartPosition.Manual;
            test.FormClosing += delegate { this.Show(); };
            test.Show();
            this.Hide();





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
