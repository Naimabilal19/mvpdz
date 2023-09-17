using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPV_END
{
    public interface IView
    {
        string name { set; get; }
        string age { set; get; }

        event EventHandler<EventArgs> buttonsave;
        event EventHandler<EventArgs> show;

        void AddItemToListBox(string item);
        void ShowInfoPersone(string name, string age);
    }
}
