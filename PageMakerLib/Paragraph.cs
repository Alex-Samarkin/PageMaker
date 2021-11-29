using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PageMakerLib
{
    /// <summary>
    /// параграф HTML
    /// </summary>
    public class Paragraph
    {
        /// <summary>
        /// стиль абзаца
        /// </summary>
        public Style Style { get; set; } = new Style();

        /// <summary>
        /// содержание
        /// </summary>
        public string Text { get; set; } = "";

        /// <summary>
        /// вывод абзаца как параграфа HTML
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Style.Start+" "+Text+" "+Style.End;
        }

    }
}
