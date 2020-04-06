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
        private WordDetail wordDetail;

        public WordSearch(List<char[]> charArrListMatrix)
        {
            this.matrix = charArrListMatrix;
        }

        /// <summary>
        /// Search word from left to right horizontally
        /// </summary>
        
        public List<XY> HorizontalSearch(string word)
        {
            List<XY> res = new List<XY>();

            wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == firstCharXY.Y && c.X == res.Last().X + 1)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word from right to left horizontally
        /// </summary>
        /// 
        public List<XY> HorizontalReverseSearch(string word)
        {
            List<XY> res = new List<XY>();

            wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == firstCharXY.Y && c.X == res.Last().X - 1)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word vertically from top to bottom
        /// </summary>

        public List<XY> VerticalDownwardSearch(string word)
        {
            List<XY> res = new List<XY>();

            wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == res.Last().Y + 1 && c.X == firstCharXY.X)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word vertically from bottom to top
        /// </summary>

        public List<XY> VerticalUpwardSearch(string word)
        {
            List<XY> res = new List<XY>();

            this.wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == res.Last().Y - 1 && c.X == firstCharXY.X)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word diagonally downward from left to right
        /// </summary>

        public List<XY> DiagonalDownwardSearch(string word)
        {
            List<XY> res = new List<XY>();

            this.wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == res.Last().Y + 1 && c.X == res.Last().X + 1)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word diagonally upward from right to left
        /// </summary>

        public List<XY> DiagonalUpwardSearch(string word)
        {
            List<XY> res = new List<XY>();

            this.wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == res.Last().Y - 1 && c.X == res.Last().X - 1)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word diagonally downward from right to left
        /// </summary>

        public List<XY> Diagonal2DownwardSearch(string word)
        {
            List<XY> res = new List<XY>();

            this.wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == res.Last().Y + 1 && c.X == res.Last().X - 1)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// Search word diagonally upward from left to right
        /// </summary>

        public List<XY> Diagonal2UpwardSearch(string word)
        {
            List<XY> res = new List<XY>();

            this.wordDetail = this.wordDetail ?? new WordDetail(matrix, word);

            foreach (var firstCharXY in wordDetail.CharDetails[0].XYs)
            {
                res = new List<XY>
                {
                    firstCharXY
                };

                for (int i = 1; i < wordDetail.CharDetails.Count; i++)
                {
                    var items = wordDetail.CharDetails[i].XYs
                        .Where(c => c.Y == res.Last().Y - 1 && c.X == res.Last().X + 1)
                        .ToList();

                    if (items.Count() == 1)
                    {
                        res.Add(items[0]);
                    }
                    else
                    {
                        break;
                    }
                }

                // break and return for the first word found
                if (res.Count == wordDetail.CharDetails.Count)
                {
                    break;
                }
            }

            return res;
        }
    }

    public class CharDetail
    {
        public List<XY> XYs { get; set; }
        public char Character { get; set; }
        public CharDetail(List<char[]> matrix, char c)
        {
            Character = c;
            XYs = new List<XY>();
            for (int y = 0; y < matrix.Count; y++)
            {
                for (int x = 0; x < matrix[y].Length; x++)
                {
                    if (matrix[y][x] == c)
                    {
                        XYs.Add(new XY(x,y));
                    }
                }
            }
        }
    }
    public class WordDetail
    {
        public List<CharDetail> CharDetails { get; set; }
        public string Word { get; set; }
        public WordDetail(List<char[]> matrix, string word)
        {
            Word = word;
            CharDetails = new List<CharDetail>();
            foreach (char c in word)
            {
                CharDetails.Add(new CharDetail(matrix, c));
            }
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
