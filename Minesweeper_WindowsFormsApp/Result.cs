using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_WindowsFormsApp
{
    public class Result : IComparable
    {
        public Result(string nick, int score)
        {
            Nick = nick;
            Score = score;
        }

        public string Nick { get; set; }
        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            Result other = (Result)obj;
            return Score.CompareTo(other.Score);
        }

        public override string ToString()
        {
            return Nick + "   " +  Score;
        }
    }
}
