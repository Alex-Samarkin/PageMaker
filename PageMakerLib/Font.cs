using System;
using System.Collections.Generic;
// надо для Description
using System.ComponentModel;
// надо для GetDescription()
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMakerLib
{
    public class Font
    {
        /// <summary>
        /// размеры шрифта Normal - по умолчанию
        /// </summary>
        public enum FontSize
        {
            VerySmall =1,
            Small = 2,
            Normal = 3,
            Bigger = 4,
            Big = 5,
            VeryBig = 6,
            Colossal = 7
        }

        /// <summary>
        /// Размер шрифта, из возможного набора
        /// </summary>
        public FontSize Size { get; set; } = FontSize.Normal;

        /// <summary>
        /// если нужны пропущенные цвета, то раскоментируйте строки с цветом
        /// </summary>
        public enum FontWebColor
        {
            aqua,
            black,
            blue,
//            fuchsia,
            gray,
            green,
            lime,
//            maroon,
            navy,
//            olive,
//            purple,
            red,
            silver,
//            teal,
            white,
            yellow
        }

        /// <summary>
        /// цвет шрифта из доступного выше списка
        /// </summary>
        public FontWebColor Color { get; set; } = FontWebColor.navy;

        /// <summary>
        /// serif — шрифты с засечками (антиквенные), типа Times;
        /// sans-serif — рубленные шрифты (шрифты без засечек или гротески), типичный представитель — Arial;
        /// cursive — курсивные шрифты;
        /// fantasy — декоративные шрифты;
        /// monospace — моноширинные шрифты, ширина каждого символа в таком семействе одинакова.
        /// </summary>
        public enum FontFace
        {
            serif,
            sans_serif,
            cursive,
            fantasy,
            monospace
        }

        /// <summary>
        /// гарнитура шрифта, переводится в строку как
        /// </summary>
        public FontFace Face { get; set; } = FontFace.serif;

        /// <summary>
        /// необходимо сформировать строку вида:
        /// <font size="5" color="red" face="Arial">
        /// внутренние кавычки экранируются символом \
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"<font size=\"{(int)Size}\" color=\"{Color}\" face=\"{Face}\">";
        }
    }
}
