using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility
{
    public abstract class ChiperBaseModel : ICiperBaseModel
    {
        public string TextFromConsole { get; set; }

        public string TextAfterCiperManipulations { get; set; }
    }
}
