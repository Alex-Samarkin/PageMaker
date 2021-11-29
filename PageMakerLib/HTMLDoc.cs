using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMakerLib
{
    public class HTMLDoc
    {
        /// <summary>
        /// заголовок окна браузера - для тега title
        /// </summary>
        public string Title { get; set; } = $"Файл сгенерирован программно {DateTime.Now}";

        /// <summary>
        /// имя файла для вывода - в текущую директорию
        /// </summary>
        public string FileName { get; set; } = "index.html";

        /// <summary>
        /// конструктор строк
        /// </summary>
        public StringBuilder StringBuilder { get; set; } = new StringBuilder();

        /// <summary>
        /// базовая стартовая строка для файла стандарта HTML5
        /// строка вынесена наружу для ее возможного изменения
        /// </summary>
        public string Start = "<!DOCTYPE html>\n" +
                              "<html >\n" +
                              "<head >\n" +
                              "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">";

        /// <summary>
        /// создается заголовок файла
        /// </summary>
        private void GenerateStart()
        {
            StringBuilder.AppendLine(Start);
            StringBuilder.AppendLine($"<title>{Title}</title>");
            StringBuilder.AppendLine("</head >");
            StringBuilder.AppendLine("<body >");
        }

        /// <summary>
        /// список абзацев - содержание страницы
        /// </summary>
        public List<Paragraph> Paragraphs { get; set; } = new List<Paragraph>();

        /// НЕОБЯЗАТЕЛЬНО - метод добавления параграфа
        
        /// <summary>
        /// вставка абзаца в хвост списка
        /// </summary>
        /// <param name="paragraph">абзац для добавления</param>
        public void Add(Paragraph paragraph)
        {
            Paragraphs.Add(paragraph);
        }

        /// НЕОБЯЗАТЕЛЬНО - метод добавления параграфа в заданное положение

        /// <summary>
        /// вставка параграфа в указанную позицию (с проверкой)
        /// </summary>
        /// <param name="paragraph">абзац</param>
        /// <param name="index">позиция вставки</param>
        public void Insert(Paragraph paragraph, int index = 0)
        {
            // нормализуем положение вставки
            index = index < 0 ? 0 : index;
            index = index > Paragraphs.Count ? Paragraphs.Count : index;
            Paragraphs.Insert(index,paragraph);
        }

        /// НЕОБЯЗАТЕЛЬНО - можно добавить методы поиска, удаления  и т.п.
        /// у нас учебный пример, поэтому не надо
        ///
        /// можно, например, добавить заголовок строку, которая превращается в параграф Title
        /// и т.д.

        /// <summary>
        /// создается тело файла
        /// </summary>
        private void GenerateText()
        {
            /// проходим по всем параграфам и добавляем их html код в список строк
            foreach (var paragraph in Paragraphs)
            {
                StringBuilder.AppendLine(paragraph.ToString());
            }
        }

        /// <summary>
        /// завершение файла
        /// </summary>
        private void GenerateEnd()
        {
            StringBuilder.AppendLine("</body>");
            StringBuilder.AppendLine("</html>");
        }

        /// <summary>
        /// создание HTML файла как набора строк в StringBuilder
        /// </summary>
        public void GenerateHTML()
        {
            /// чистим старое содержимое
            StringBuilder.Clear();
            /// создаем файл
            GenerateStart();
            GenerateText();
            GenerateEnd();
        }

        /// <summary>
        /// вывод в файл
        /// </summary>
        /// <param name="Regenerate">перегенерировать текст</param>
        public void WriteFile(bool Regenerate = true, bool ShowBrowser = true)
        {
            if(Regenerate) GenerateHTML();

            System.IO.File.WriteAllText(FileName, StringBuilder.ToString());

            /// показать в браузере
            if (ShowBrowser)
            {
                /// или var proc = Process.Start(@"cmd.exe ", @"/c " + pathToHtmlFile); 
                System.Diagnostics.Process.Start(FileName);
            }
        }

    }
}
