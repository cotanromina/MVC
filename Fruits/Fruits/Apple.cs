using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    class Apple : Fruit
    {
        string color;
        public Apple()
        {
            Console.WriteLine("This is an apple");
        }
        public int getCalories()
        {
            return 2;
        }
    }
}
