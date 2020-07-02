using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public class InjureEventsArgs : EventArgs
    {
        public Coach C { get; set; }
        public Player P { get; set; }
        public Team T { get; set; }

    }
}
