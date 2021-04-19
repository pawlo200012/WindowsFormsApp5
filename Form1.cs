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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxPESEL.Text == "")||(textBoxNazwisko.Text == "")||(textBoxImie.Text == ""))
            {
                MessageBox.Show("Nie prowadzono danej w polu PESEL, Imie lub Nazwisko!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();
            }

            int grade = int.Parse(checkedListBoxOcena.SelectedItem.ToString());
            SchoolSubject schoolSubject = (SchoolSubject)Enum.Parse(typeof(SchoolSubject),checkedListBoxPrzedmiot.SelectedItem.ToString(),false);
            SchoolClass schoolClass = (SchoolClass)Enum.Parse(typeof(SchoolClass), checkedListBoxClass.SelectedItem.ToString(), false);
            string name = textBoxImie.Text;
            string secondName = textBoxNazwisko.Text;
            string id = textBoxPESEL.Text;
            int idInt;

            //MessageBox.Show(grade + ""+ schoolClass +""+ schoolSubject + name + secondName + id);

            //sprawdzenie czy pesel jest liczba, jesli nie = komunikat
            if (!int.TryParse(id,out idInt))
            {
                MessageBox.Show("Pesel nie zawiera samych liczb, czyżby nastąpił błąd?","Uwaga", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }

            //tworzenie obiektu
            PreparedLineFormatFile preparedLineFormatFile = new PreparedLineFormatFile(idInt,name+secondName,schoolClass,schoolSubject,grade);
            //wysylanie do pliku
            LineObject.SendLineToFile(preparedLineFormatFile);

            
            Reset();

        }

        private void Reset()
        {
            textBoxPESEL.Text = "";
            textBoxNazwisko.Text = "";
            textBoxImie.Text = "";
            for (int i = 0; i < checkedListBoxOcena.Items.Count; i++)
            {
                checkedListBoxOcena.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxOcena.ClearSelected();
            }
            for (int i = 0; i < checkedListBoxPrzedmiot.Items.Count; i++)
            {
                checkedListBoxPrzedmiot.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxPrzedmiot.ClearSelected();
            }
            for (int i = 0; i < checkedListBoxClass.Items.Count; i++)
            {
                checkedListBoxClass.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxClass.ClearSelected();
            }

        }
    }
}
