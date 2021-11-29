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

            HTMLDoc htmlDoc = new HTMLDoc();
            htmlDoc.Add(paragraph);
            htmlDoc.Add(paragraph1);

            htmlDoc.GenerateHTML();
            Console.WriteLine(htmlDoc.StringBuilder.ToString());

            Paragraph t = new Paragraph();
            t.Style.Title();
            t.Text = "Похождения бравого солдата Швейка";
            
            Paragraph t1 = new Paragraph();
            t1.Style.SubTitle();
            t1.Text = "Ярослав Гашек";
            htmlDoc.Insert(t);
            htmlDoc.Insert(t1,1);

            Paragraph h2 = new Paragraph() { Text = "Мысли и размышления бравого солдата" };
            h2.Style.H(2);
            htmlDoc.Insert(h2, 2);

            // добавляем автора
            Paragraph auth = new Paragraph() { Text = "Писано Р.Б. Гашеком лета 1642 своею рукой" };
            auth.Style.Autor();
            htmlDoc.Insert(auth, 2);
            htmlDoc.Add(auth);
            Console.ReadLine();

        }
    }
}
