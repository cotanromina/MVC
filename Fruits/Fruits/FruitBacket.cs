using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    class FruitBascket
    {
        public List<Fruit> listaFructe;
        public FruitBascket()
        {
            listaFructe = new List<Fruit>();
        }
        public void addFruit(Fruit fruit)
        {
            listaFructe.Add(fruit);
        }
        public void displayFruitCalories()
        {
            foreach(var fr in listaFructe)
            {
                Console.WriteLine("Lista de fructe");
            }
        }
    }
}
