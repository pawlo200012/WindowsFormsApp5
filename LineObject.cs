using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class LineObject
    { 
        public static void SendLineToFile(PreparedLineFormatFile preparedLineFormatFile)
        {
            string path = "DataFile.txt";
            StreamWriter sw = new StreamWriter(path, true);

            sw.Write(preparedLineFormatFile.ID);
            sw.Write(",");
            sw.Write(preparedLineFormatFile.Name);
            sw.Write(",");
            sw.Write(preparedLineFormatFile.SchoolClass);
            sw.Write(",");
            sw.Write(preparedLineFormatFile.SchoolSubject);
            sw.Write(",");
            sw.Write(preparedLineFormatFile.Grade);
            sw.WriteLine();

            sw.Close();
        }


        //usuwa jeden, nie wszystkie te same
        public static void DeleteLineFromFile(PreparedLineFormatFile pLFF)
        {
            var list = GetDataFromFile.GetData();
            const string path = "DataFile.txt";

            //czyszcze plik bo się nadpisze podwojnie
            StreamWriter sw1 = new StreamWriter(path, false);
            sw1.Close();

            var listNew = new List<PreparedLineFormatFile>();

            StreamReader sr = new StreamReader(path);
            int counter = 0; //licznik by tylko 1 linia została pobrana

            foreach (var x in GetDataFromFile.GetData())
            {
                //jeśli linie są różne, wiec nie usuwamy
                if (!((x.ID == pLFF.ID) && (x.SchoolSubject == pLFF.SchoolSubject) && (x.Grade == pLFF.Grade)))
                {
                    listNew.Add(x);
                }
                ///jesli są te same
                else if (counter == 0)
                {
                    counter++;
                }
                else
                {
                    listNew.Add(x);
                }
            }
            sr.Close();

            foreach (var x in listNew)
            {
                SendLineToFile(x);
            }
        }

        //usuwa jeden, nie wszystkie te same
        public static void DeleteLineFromFile(int ID, SchoolSubject schoolSubject, int grade)
        {
            var list = GetDataFromFile.GetData();
            const string path = "DataFile.txt";

            //czyszcze plik bo się nadpisze podwojnie
            StreamWriter sw1 = new StreamWriter(path, false);
            sw1.Close();

            var listNew = new List<PreparedLineFormatFile>();

            StreamReader sr = new StreamReader(path);
            int counter = 0; //licznik by tylko 1 linia została pobrana


            foreach (var x in list)
            {
                //jeśli linie są różne, wiec nie usuwamy
                if (!((x.ID == ID) && (x.SchoolSubject == schoolSubject) && (x.Grade == grade)))
                {
                    listNew.Add(x);
                }
                ///jesli są te same
                else if (counter == 0)
                {
                    counter++;
                }
                else
                {
                    listNew.Add(x);
                }
            }
            sr.Close();

            foreach (var x in listNew)
            {
                SendLineToFile(x);
            }

        }
    }
}
