using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CellTextCharacterFactory
    {
        Dictionary<string, CellTextCharacter> textCharacters;

        public CellTextCharacterFactory() 
        {
            textCharacters = new Dictionary<string, CellTextCharacter>();
        }

        public CellTextCharacter GetCellTextCharacter(string fontFamily, int fontSize, bool isBold)
        {
            if (textCharacters.ContainsKey(fontFamily + fontSize + isBold)) 
            {
                return textCharacters[fontFamily + fontSize + isBold];
            }

            var newTextCharacter = new CellTextCharacter(fontFamily, fontSize, isBold);
            textCharacters.Add(fontFamily + fontSize + isBold, newTextCharacter);
            return newTextCharacter;
        }
    }
}
