using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Подключаем библиотеку классов, которая предварительно добавлена в ссылки / references
using PageMakerLib;

namespace PageMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // output and waiting for Enter key
            Console.WriteLine(About.Description);
            Console.ReadLine();
        }
    }
}
