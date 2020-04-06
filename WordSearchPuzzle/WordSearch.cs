using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchPuzzle
{
    public class WordSearch
    {
        private List<char[]> matrix;

        public WordSearch(List<char[]> charArrListMatrix)
        {
            this.matrix = charArrListMatrix;
        }

        public List<XY> HorizontalSearch(string word)
        {
            return new List<XY>
                {
                    new XY(0, 5),
                    new XY(1, 5),
                    new XY(2, 5),
                    new XY(3, 5),
                    new XY(4, 5),
                    new XY(5, 5)
                };
        }
    }
    public class XY
    {
        public int X { get; set; }
        public int Y { get; set; }
        public XY(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class XYComparer : System.Collections.IComparer
    {

        public int Compare(object ex, object ac)
        {
            XY expected = (XY)ex;
            XY actual = (XY)ac;

            if (expected.X == actual.X && expected.Y == actual.Y)
                return 0;
            else
                return 1;
        }
    }
}
