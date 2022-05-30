using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //как тебя зовут, сколько тебе лет, какого цвета у тебя волосы, какого цвета глаза 
            string name;
            string age;
            string colorHair;
            string colorEyes;

            Console.WriteLine("Как тебя зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?");
            age = Console.ReadLine();
            Console.WriteLine("Какого цвета твои волосы?");
            colorHair = Console.ReadLine();
            Console.WriteLine("Какого цвета твои глаза?");
            colorEyes = Console.ReadLine();

            Console.WriteLine("Здравствуй, {0}, тебе {1}, у тебя {2} волосы и {3} глаза", name, age, colorHair, colorEyes);
        }
    }
}
