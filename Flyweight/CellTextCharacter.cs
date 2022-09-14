using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CellTextCharacter
    {
        public string _fontFamily { get; set; }
        public int _fontSize { get; set; }
        public bool _isBold { get; set; }

        public CellTextCharacter(string fontFamily, int fontSize, bool isBold) 
        {
            this._fontFamily = fontFamily;
            this._fontSize = fontSize; 
            this._isBold = isBold;
        }
    }
}
