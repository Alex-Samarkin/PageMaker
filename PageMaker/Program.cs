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
            Console.WriteLine(About.Step2);
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

            /// просмотрите класс параграф в файле Paragraph
            Paragraph paragraph = new Paragraph();
            paragraph.Text = "— Не представляю себе, — произнес Швейк, " +
                             "— чтобы невинного осудили на десять лет. " +
                             "Правда, однажды невинного приговорили к пяти годам — такое я слышал, " +
                             "но на десять — это уж, пожалуй, многовато!";
            Paragraph paragraph1 = new Paragraph()
            {
                Text = "— Кто любит говорить двусмысленности, сначала должен их обдумать. " +
                       "Откровенный человек, у которого что на уме, то и на языке, " +
                       "редко получает по морде. " +
                       "А если уж получит, так потом вообще предпочтёт на людях держать язык за зубами. " +
                       "Правда, про такого человека думают, " +
                       "что он коварный и ещё бог весть какой, " +
                       "и тоже не раз отлупят как следует, " +
                       "но это всё зависит от его рассудительности и самообладания."
            };
            // output and waiting for Enter key
            Console.WriteLine(paragraph);
            Console.WriteLine(paragraph1);
            Console.ReadLine();
        }
    }
}
