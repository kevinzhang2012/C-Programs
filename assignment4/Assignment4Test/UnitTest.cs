using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment4Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestBuildOccu()
        {
            var list = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var be = new Library.BackEnd();
            var occu = be.BuildOccu(list);
            Assert.AreEqual(1, occu["cc"]);
            Assert.AreEqual(2, occu["aa"]);
            Assert.AreEqual(3, occu.Count);
        }

        [TestMethod]
        public void TestBuildLeng()
        {
            var list = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var be = new Library.BackEnd();
            var leng = be.BuildLeng(list);
            Assert.AreEqual(2, leng["aa"]);
            Assert.AreEqual(2, leng["cc"]);
        }

         [TestMethod]
        public void TestMostCommon()
        {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "Frequency: 3 times\nyyy ";
             var actual = be.MostCommon();
             Assert.AreEqual(expected, actual);
        }

         [TestMethod]
        public void TestLongest()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "Longest: 3 letters.\nyyy ";
             var actual = be.LongestLength();
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestShortest()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "Shorest: 1 letters.\nz ";
             var actual = be.ShortestLength();
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestAverage()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "2.00";
             var actual = be.AverageLength();
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestSearchWord()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "Number of occurrences: 2";
             var actual = be.SearchWord("xx");
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestSearchLength()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "yyy, ";
             var actual = be.SearchLength(3);
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestUnique()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "xx,yyy,z,";
             var actual = be.Unique();
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestWordsCount()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = 6;
             var actual = be.WordsCount();
             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void TestAverageAll()
         {
             var s = "xx yyy yyy xx z yyy";
             var be = new Library.BackEnd(s);
             var expected = "2.33";
             var actual = be.AverageLengthAll();
             Assert.AreEqual(expected, actual);
         }
    }
}
