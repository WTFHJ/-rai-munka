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
        public string Method { get; set; }
        public bool Extra { get; set; }
        public int people;

        public string People
        {
            get { return people.ToString(); }
            set { people = Convert.ToInt32(value); }
        }

        public void Auteur()
        {
            MessageBox.Show($"{Name}, {Start}, {End}, {Method}, {Extra}, {people}");
            StreamWriter writer = new StreamWriter("adatok.txt", false, Encoding.UTF8);
            if (Extra == false)
            {
                writer.WriteLine(Name + ";" + Start + ";" + End + ";" + Method + ";0");
            }
            else
            {
                writer.WriteLine(Name + ";" + Start + ";" + End + ";" + Method + ";" + people);
            }
            writer.Close();
        }
    }
}
