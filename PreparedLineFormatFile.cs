using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class PreparedLineFormatFile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SchoolClass SchoolClass { get; set; }
        public SchoolSubject SchoolSubject { get; set; }
        public int Grade { get; set; }
        public PreparedLineFormatFile(int id, string name, SchoolClass schoolClass, SchoolSubject schoolSubject, int grade)
        {
            ID = id;
            Name = name;
            SchoolClass = schoolClass;
            SchoolSubject = schoolSubject;
            Grade = grade;
        }
    }
}
