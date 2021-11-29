using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMakerLib
{
    public class Align
    {
        /// <summary>
        /// <p align="left | right | center | justify">
        /// </summary>
        public enum AlignKind
        {
            left,
            right,
            center
        }

        /// <summary>
        /// выравнивание параграфа
        /// </summary>
        public AlignKind AlignP { get; set; } = AlignKind.left;

        public override string ToString()
        {
            return $"<p align= \"{AlignP}\">";
        }
    }
}
