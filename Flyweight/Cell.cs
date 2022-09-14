using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private String content;
        public CellTextCharacter _cellTextCharacter { get; set; }        

        public Cell(int row, int column, CellTextCharacter cellTextCharacter) 
        {
            this.row = row;
            this.column = column;
            this._cellTextCharacter = cellTextCharacter;
        }

        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }



        public void render()
        {
            Console.WriteLine($"({row}, {column}): {content} [{_cellTextCharacter._fontFamily}]\n");
        }
    }
}
