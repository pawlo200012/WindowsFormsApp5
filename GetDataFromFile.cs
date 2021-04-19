using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{ 
    public static class GetDataFromFile
    {
        public static List<PreparedLineFormatFile> GetData()
        {

            string path = "DataFile.txt";
            StreamReader sr = File.OpenText(path);
            List<PreparedLineFormatFile> allLinesFromFile = new List<PreparedLineFormatFile>();

            if (File.Exists(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] tab = new string[6];
                    tab = line.Split(',');

                    allLinesFromFile.Add(new PreparedLineFormatFile(int.Parse(tab[0]), tab[1],
                        (SchoolClass)Enum.Parse(typeof(SchoolClass), tab[2]),
                        (SchoolSubject)Enum.Parse(typeof(SchoolSubject), tab[3]), int.Parse(tab[4])));
                }

                sr.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
            return allLinesFromFile;
        }
    }
}
