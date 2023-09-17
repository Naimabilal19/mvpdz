using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPV_END
{
    public class Presenter
    {
        public readonly IModel model;
        public readonly IView view;
        public Presenter() { }
        public Presenter(IModel _model, IView _view)
        {
            model = _model;
            view = _view;

            view.buttonsave += View_buut;
            view.show += View_buut_print;


        }

        private void View_buut_print(object sender, EventArgs e)
        {
            model.name = view.name;
            model.age = view.age;

            string item = $"Name={model.name},Age={model.age}";

            view.AddItemToListBox(item);

        }



        private void View_buut(object sender, EventArgs e)
        {

            model.Name_P = view.Name_P;
            model.Age_P = view.Age_P;

            model.AddInfoFile_P();

        }
    }
}
