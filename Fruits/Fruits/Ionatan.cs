using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    class Ionatan : Apple
    {
        public Ionatan()
        {
            Console.WriteLine("This is an ionatan apple");
        }
        public virtual int getCalories()
        {
            return 3;
        }
    }
}
