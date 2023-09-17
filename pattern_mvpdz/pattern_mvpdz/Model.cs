using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MPV_END
{
    public class Model : IModel
    {
        public string PathFile = "Person.txt";
        public string name { set; get; }
        public string age { set; get; }

        public Model() { }
        public void AddInfo()
        {
            using (StreamWriter writet = new StreamWriter(PathFile, true))
            {

                writet.WriteLine($"Name:{name}\tAge:{age}");
                writet.Close();
                MessageBox.Show("Вы добавили пользователь!");
            }
        }
        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader(PathFile, true))
            {
                string items;
                while (true)
                {

                    items = reader.ReadToEnd();
                }

            }
        }

    }
}
