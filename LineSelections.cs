using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class LineSelections
    {
        public static List<PreparedLineFormatFile> SelectByID(List<PreparedLineFormatFile> list, int id)
        {
            List<PreparedLineFormatFile> newList = new List<PreparedLineFormatFile>();

            foreach (PreparedLineFormatFile x in list)
            {
                if (x.ID == id)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }
        public static List<PreparedLineFormatFile> SelectByGrade(List<PreparedLineFormatFile> list, int grade)
        {
            List<PreparedLineFormatFile> newList = new List<PreparedLineFormatFile>();

            foreach (PreparedLineFormatFile x in list)
            {
                if (x.ID == grade)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }
        public static List<PreparedLineFormatFile> SelectBySchoolClass(List<PreparedLineFormatFile> list, SchoolClass @class, int anything)
        {
            List<PreparedLineFormatFile> newList = new List<PreparedLineFormatFile>();

            foreach (PreparedLineFormatFile x in list)
            {
                if (x.SchoolClass == @class)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }
        public static List<PreparedLineFormatFile> SelectBySchoolClass(List<PreparedLineFormatFile> list, SchoolSubject @class, string anything)
        {
            List<PreparedLineFormatFile> newList = new List<PreparedLineFormatFile>();

            foreach (PreparedLineFormatFile x in list)
            {
                if (x.SchoolSubject == @class)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }
        public static List<PreparedLineFormatFile> SelectByName(List<PreparedLineFormatFile> list, string name, char anything)
        {
            List<PreparedLineFormatFile> newList = new List<PreparedLineFormatFile>();

            foreach (PreparedLineFormatFile x in list)
            {
                if (x.Name == name)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }

        public static double AverageGradeValue(List<PreparedLineFormatFile> list)
        {
            int d = 0;
            foreach (var x in list)
            {
                d += x.Grade;
            }
            return d / (double)list.Count;
        }
    }
}
