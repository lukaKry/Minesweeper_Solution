using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper_ClassLibrary
{
    public class Cell
    {
        //properties
        public bool IsBomb { get; set; }
        public bool IsCounter { get; set; }
        public bool IsHidden { get; set; }

        public int BombCounter { get; set; }

        //constructor
        public Cell()
        {
            IsCounter = true;
            IsHidden = true;
            IsBomb = false;
            BombCounter = 0;
        }

        //mehtods
        public void revealCell()
        {
            IsHidden = false;
        }

    }
}
