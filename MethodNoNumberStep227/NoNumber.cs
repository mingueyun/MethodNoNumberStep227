using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodNoNumberStep227
{
    class NoNumber
    {
        public void NoIntOption(int required, int optionalint = 2)
        {
            Console.WriteLine(required + optionalint);

        }
    }
}
