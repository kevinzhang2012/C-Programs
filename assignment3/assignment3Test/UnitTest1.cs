using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using assignment3;

namespace assignment3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTeamFields()
        {
            var form = new Form1();
            Assert.AreEqual("", form.team1);
            Assert.AreEqual("", form.team2);
        }

        [TestMethod]
        public void TestTeam1Try()
        {
            var form = new Form1();
            form.Team1Try();
            int expected = 5;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t1_try_num);
        }

        [TestMethod]
        public void TestTeam2Try()
        {
            var form = new Form1();
            form.Team2Try();
            int expected = 5;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t2_try_num);
        }

        [TestMethod]
        public void TestTeam1Coversion()
        {
            var form = new Form1();
            form.Team1Conversion();
            int expected = 2;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t1_conversion_num);
        }

        [TestMethod]
        public void TestTeam2Coversion()
        {
            var form = new Form1();
            form.Team2Conversion();
            int expected = 2;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t2_conversion_num);
        }

        [TestMethod]
        public void TestTeam1Penalty()
        {
            var form = new Form1();
            form.Team1Penalty();
            int expected = 3;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t1_penalty_num);
        }

        [TestMethod]
        public void TestTeam2Penalty()
        {
            var form = new Form1();
            form.Team2Penalty();
            int expected = 3;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t2_penalty_num);
        }

        [TestMethod]
        public void TestTeam1DropKick()
        {
            var form = new Form1();
            form.Team1DropKick();
            int expected = 3;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t1_dropkick_num);
        }

        [TestMethod]
        public void TestTeam2DropKick()
        {
            var form = new Form1();
            form.Team2DropKick();
            int expected = 3;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, form.t2_dropkick_num);
        }

        [TestMethod]
        public void TestTimer()
        {
            var form = new Form1();
            form.Timer();
            int expected_sec = 1;
            int actual_sec = form.sec;
            int expected_min = 0;
            int actual_min = form.min;
            Assert.AreEqual(expected_sec, actual_sec);
            Assert.AreEqual(expected_min, actual_min);
        }
    }
}
