using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            Orange o = new Orange();
            Ionatan i = new Ionatan();

            Ionatan i1 = new Ionatan();
            Console.WriteLine(i1.getCalories());

            Apple a1 = new Ionatan();
            Console.WriteLine(a1.getCalories());

            Fruit fr = new Ionatan();
            Console.WriteLine(fr.getCalories());

            Apple mar = new Apple();
            Ionatan marIonatan = new Ionatan();
            FruitBascket frBasket = new FruitBascket();
            frBasket.addFruit(mar);
            frBasket.addFruit(marIonatan);
         
            Console.ReadKey();
        }
    }
}
