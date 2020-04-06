using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WordSearchPuzzle;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // search word

        [TestMethod]
        public void Search()
        {

            // arrange

            // act

            // assert
            Assert.Fail();
        }

        // horizontal search test

        [DataTestMethod]
        [DataRow("SCOTTY", DisplayName = "SCOTTY")]
        public void Search_Horizontal(string word)
        {
            // Arrange 

            List<XY> expectedPoints = new List<XY>
            {
                new XY(0, 5),
                new XY(1, 5),
                new XY(2, 5),
                new XY(3, 5),
                new XY(4, 5),
                new XY(5, 5)
            };

            // Act

            WordSearch wordSearch = new WordSearch(GetMatrix());
            List<XY> actualPoints = wordSearch.HorizontalSearch(word);
            XYComparer xYComparer = new XYComparer();

            // Assert

            CollectionAssert.AreEqual(expectedPoints, actualPoints, xYComparer);
        }

        // horizontal reverse search test

        // vertical search test

        // vertical reverse search test

        // diagonal search test

        // diagonal reverse search test

        // diagonal2 search test

        // diagonal2 reverse search test


        // other private methods

        // search space
        private List<char[]> GetMatrix()
        {
            return new List<char[]>
            {
                "U,M,K,H,U,L,K,I,N,V,J,O,C,W,E".Split(',').Select(c=>c[0]).ToArray(),
                "L,L,S,H,K,Z,Z,W,Z,C,G,J,U,Y,G".Split(',').Select(c=>c[0]).ToArray(),
                "H,S,U,P,J,P,R,J,D,H,S,B,X,T,G".Split(',').Select(c=>c[0]).ToArray(),
                "B,R,J,S,O,E,Q,E,T,I,K,K,G,L,E".Split(',').Select(c=>c[0]).ToArray(),
                "A,Y,O,A,G,C,I,R,D,Q,H,R,T,C,D".Split(',').Select(c=>c[0]).ToArray(),
                "S,C,O,T,T,Y,K,Z,R,E,P,P,X,P,F".Split(',').Select(c=>c[0]).ToArray(),
                "B,L,Q,S,L,N,E,E,E,V,U,L,F,M,Z".Split(',').Select(c=>c[0]).ToArray(),
                "O,K,R,I,K,A,M,M,R,M,F,B,A,P,P".Split(',').Select(c=>c[0]).ToArray(),
                "N,U,I,I,Y,H,Q,M,E,M,Q,R,Y,F,S".Split(',').Select(c=>c[0]).ToArray(),
                "E,Y,Z,Y,G,K,Q,J,P,C,Q,W,Y,A,K".Split(',').Select(c=>c[0]).ToArray(),
                "S,J,F,Z,M,Q,I,B,D,B,E,M,K,W,D".Split(',').Select(c=>c[0]).ToArray(),
                "T,G,L,B,H,C,B,E,C,H,T,O,Y,I,K".Split(',').Select(c=>c[0]).ToArray(),
                "O,J,Y,E,U,L,N,C,C,L,Y,B,Z,U,H".Split(',').Select(c=>c[0]).ToArray(),
                "W,Z,M,I,S,U,K,U,R,B,I,D,U,X,S".Split(',').Select(c=>c[0]).ToArray(),
                "K,Y,L,B,Q,Q,P,M,D,F,C,K,E,A,B".Split(',').Select(c=>c[0]).ToArray()
            };
        }

    }
}
