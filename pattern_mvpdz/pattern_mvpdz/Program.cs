using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPV_END
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            Form1 form1 = new Form1();
            Presenter presenter = new Presenter(model, form1);
            Application.Run(new Form1());

            Form1 form = new Form1();
            IModel model1 = new Model();
            Presenter presenter1 = new Presenter(model, form);
            Application.Run(form);

        }
    }
}
