using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility
{
    public abstract class ChiperBaseModel : IChiperBaseModel
    {
        public string TextFromConsole { get; set; }

        public string TextAfterChiperManipulations { get; set; }
    }
}
