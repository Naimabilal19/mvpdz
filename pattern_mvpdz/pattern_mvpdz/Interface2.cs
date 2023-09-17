using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPV_END
{
    public interface IModel
    {
        string name { set; get; }
        string age { set; get; }

        void AddInfo();
        void RaedFile();
    }
}
