using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayfairCiper
{
    public static class PlayfairCiperFactory
    {
        public static PlayfairCiperMain CreatePlayfairMain()
        {
            return new PlayfairCiperMain();
        }

    }
}
