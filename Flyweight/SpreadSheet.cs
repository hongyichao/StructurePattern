using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class SpreadSheet
    {
        private static readonly int MAX_ROWS = 3;
        private static readonly int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private readonly String fontFamily = "Times New Roman";
        private readonly int fontSize = 12;
        private readonly bool isBold = false;

        private CellTextCharacterFactory cellTextCharacterFactory;

        private Cell[,] cells = new Cell[MAX_ROWS, MAX_COLS];

        public SpreadSheet()
        {
            cellTextCharacterFactory = new CellTextCharacterFactory();
            generateCells();

        }

        public void setContent(int row, int col, String content)
        {
            ensureCellExists(row, col);

            cells[row, col].setContent(content);
        }

        public void setFontFamily(int row, int col, String fontFamily)
        {
            ensureCellExists(row, col);

            var cell = cells[row, col];

            var currentCharacter = cell._cellTextCharacter;

            var newCellTextCharacter = cellTextCharacterFactory.GetCellTextCharacter(fontFamily, 
                currentCharacter._fontSize, currentCharacter._isBold);

            cell._cellTextCharacter = newCellTextCharacter;
        }

        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new Exception();

            if (col < 0 || col >= MAX_COLS)
                throw new Exception();
        }

        private void generateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col, cellTextCharacterFactory.GetCellTextCharacter(fontFamily, fontSize, isBold));
                    cells[row, col] = cell;
                }
        }

        public void render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row, col].render();
        }
    }
}
