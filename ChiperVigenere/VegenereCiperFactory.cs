using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegenereCiper
{
    public static class VegenereCiperFactory
    {
        public static VegenereCiperMain CreateCiperMain()
        { 
            return new VegenereCiperMain();
        }

        

    }
}
