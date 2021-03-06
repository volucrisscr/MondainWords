﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MondainDeploy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondainDeploy.Tests
{
    [TestClass()]
    public class FullLexiconTests
    {
        //[TestMethod()]
        //public void FullLexiconTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void FullLexiconTest1()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetWordCountTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetAlphagramCountTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetRandomQuizEntriesTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetBlankBingoEntriesTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void RemoveRandomLetterTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void ReturnOneLetterStealsTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void AlphagramifyStringTest()
        {
            string original = "ANABAENA";
            string expected = "AAAABENN";
            string actual = FullLexicon.AlphagramifyString(original);
            Assert.AreEqual(expected, actual, false, "AlphagramifyStringTest failed: strings not equal");
        }

    //    [TestMethod()]
    //    public void GetValidAnagramsTest()
    //    {
    //        // this needs ATW or a testing lexicon to work
    //        Assert.Fail();
    //    }
    //    public void GetValidAnagramsTest2()
    //    {
            
    //        Assert.Fail();
    //    }
    //[TestMethod()]
    //    public void LookupKVPForWordTest()
    //    {
    //        Assert.Fail();
    //    }

    //    [TestMethod()]
    //    public void AddCurrentDirToPathTest()
    //    {
    //        Assert.Fail();
    //    }
    }
}