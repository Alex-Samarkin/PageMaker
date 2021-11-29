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
            //Console.WriteLine(About.Description);
            Console.WriteLine(About.Step1);
            Console.ReadLine();

            /// просмотрите класс Font
            /// задайте цвет по умолчанию black
            Font fntFont = new Font();
            Console.WriteLine(fntFont);
            Console.ReadLine();

            /// просмотрите класс Align
            /// добавьте к перечислению выравнивание по ширине
            /// сделайте выравнивание по ширине выравниванием по умолчанию
            Align align = new Align();
            Console.WriteLine(align);
            Console.ReadLine();

            /// просмотрите класс Style
            /// он комбинирует свойства абзаца (выравнивание) и шрифта
            /// Style выдает строку, которую надо задать перед абзацем - Start
            /// и строку, завершающую абзац End
            Style style = new Style();
            Console.WriteLine(style.Start);
                Console.WriteLine("Этот текст будет отображаться в браузере в соответствии с настройками стиля");
            Console.WriteLine(style.End);
            Console.ReadLine();


        }
    }
}
