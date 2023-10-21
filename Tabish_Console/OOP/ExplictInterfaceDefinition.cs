using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Console.OOP
{
    interface I1
    {
        void add();
    }
    interface I2
    {
        void add();
    }

    class calculation : I1, I2
    {

        void I1.add()
        {
        
        }

        void I2.add()
        {

        }

    }
}
