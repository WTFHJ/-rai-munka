using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace gyakorlas.Data
{
    public class Reservation
    {
        public string Name { get; set; }
        public string Start {  get; set; }
        public string End { get; set; }
        public string Method { get; set; } = "Kártya";
        public bool Extra { get; set; }
        public int people;

        public string People
        {
            get { return people.ToString(); }
            set { people = ConvertToIntSafe(value); }
        }
        private int ConvertToIntSafe(string s)
        {
            try
            {
                int num = Convert.ToInt32(s);
                return num;
            }
            catch
            {
                return 0;
            }


        }

        public void Auteur()
        {
            MessageBox.Show($"{Name}, {Start}, {End}, {Method}, {Extra}, {people}");
            StreamWriter writer = new StreamWriter("adatok.txt", true, Encoding.UTF8);
            if (Extra == false)
            {
                writer.Write(Name + ";" + Start + ";" + End + ";" + Method + ";0");
            }
            else
            {
                writer.Write(Name + ";" + Start + ";" + End + ";" + Method + ";" + people);
            }
            writer.Write("\n");
            writer.Close();
        }
    }
}
