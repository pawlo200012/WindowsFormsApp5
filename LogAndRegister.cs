using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    static class LogAndRegister
    {
        public static bool Log(string login, string password)
        {
            string nameOfFile = "plik.txt";

            StreamReader sr = File.OpenText(nameOfFile);

            if (File.Exists(nameOfFile))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] tab = new string[2];
                    tab = line.Split(',');

                    if ((tab[0] == login) && (tab[1] == password))
                    {
                        sr.Close();
                        return true;
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }

            sr.Close();
            return false;
        }

        public static bool Register(string login, string password)
        {
            string nameOfFile = "plik.txt";

            if (login.Contains(',')) return false;
            if (password.Contains(',')) return false;
            if (Log(login, password)) return false;

            StreamWriter sw = new StreamWriter(nameOfFile, true);
            sw.Write(login);
            sw.Write(",");
            sw.Write(password);
            sw.WriteLine();
            sw.Close();

            return true;
        }

    }
}
