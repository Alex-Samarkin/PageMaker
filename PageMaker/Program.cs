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
            // Console.WriteLine(About.Description);
            // Console.WriteLine(About.Step1);
            // Console.WriteLine(About.Step2);
            Console.WriteLine(About.Step3);
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

            HTMLDoc htmlDoc = new HTMLDoc();
            htmlDoc.Add(paragraph);
            htmlDoc.Add(paragraph1);

            htmlDoc.GenerateHTML();
            // output and waiting for Enter key
            Console.WriteLine(htmlDoc.StringBuilder.ToString());

            // создаем файл и отправляем его в браузер
            htmlDoc.WriteFile();
            Console.ReadLine();

            // добавляем название
            Paragraph t = new Paragraph();
            t.Style.Title();
            t.Text = "Похождения бравого солдата Швейка";
            Paragraph t1 = new Paragraph();
            t1.Style.SubTitle();
            t1.Text = "Ярослав Гашек";
            htmlDoc.Insert(t);
            htmlDoc.Insert(t1,1);
            htmlDoc.WriteFile();

            // добавляем заголовок главы
            Paragraph h2 = new Paragraph() { Text = "Мысли и размышления бравого солдата" };
            h2.Style.H(2);
            htmlDoc.Insert(h2, 2);
            htmlDoc.WriteFile();
            Console.ReadLine();

            // добавляем автора
            Paragraph auth = new Paragraph() { Text = "Писано Р.Б. Гашеком лета 1642 своею рукой" };
            auth.Style.Autor();
            htmlDoc.Insert(auth, 2);
            htmlDoc.Add(auth);
            htmlDoc.WriteFile();
            Console.ReadLine();

        }
    }
}
