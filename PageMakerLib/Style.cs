using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMakerLib
{
    /// <summary>
    /// стиль абзаца - выравнивание и шрифт
    /// </summary>
    public class Style
    {
        /// <summary>
        /// выравнивание абзаца
        /// </summary>
        public Align Align { get; set; } = new Align();

        /// <summary>
        /// шрифт абзаца
        /// </summary>
        public Font Font { get; set; } = new Font();

        /// <summary>
        /// строка начала абзаца, формируется по свойствам Align и Font
        /// символ => заменяет get
        /// </summary>
        public string Start => Align.ToString() + Font.ToString();

        /// <summary>
        /// завершение абзаца - закрываем тег шрифта и тег абзаца
        /// </summary>
        public string End => "</font></p>";


    }
}
