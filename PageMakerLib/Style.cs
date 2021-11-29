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

        public void Title()
        {
            Font.Size = Font.FontSize.Colossal;
            Font.Face = Font.FontFace.sans_serif;
            Align.AlignP = Align.AlignKind.center;
        }
        public void SubTitle()
        {
            Font.Size = Font.FontSize.VeryBig;
            Font.Face = Font.FontFace.sans_serif;
            Align.AlignP = Align.AlignKind.center;
        }
        /// <summary>
        /// заголовк уровня i, если не попадает в интервал 1-4, то корректируется
        /// </summary>
        /// <param name="i"></param>
        public void H(int i = 2)
        {
            if (i > 4)
            {
                i = 4;
            }

            if (i < 0)
            {
                i = 0;
            }

            Font.Size = Font.FontSize.Colossal - i;
            Font.Face = Font.FontFace.serif;
            Align.AlignP = Align.AlignKind.left;
        }

        public void OrdinaryJustify()
        {
            Font.Size = Font.FontSize.Normal;
            Font.Color = Font.FontWebColor.navy;
            Font.Face = Font.FontFace.serif;
            Align.AlignP = Align.AlignKind.justify;
        }

        public void Autor()
        {
            Font.Size = Font.FontSize.Small;
            Font.Color = Font.FontWebColor.lime;
            Font.Face = Font.FontFace.cursive;
            Align.AlignP = Align.AlignKind.right;
        }
    }
}
