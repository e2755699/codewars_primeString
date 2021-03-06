﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codewars_primeString
{
    [TestClass]
    public class PrimeStringTest
    {
        [TestMethod]
        public void InputIsEmpty_ShouldBeReturnIsFalse()
        {
            var expected = false;
            var input = "";
            AccumShouldBe(expected, input);
        }

        private static void AccumShouldBe(bool expected, string input)
        {
            var actual = Actual(input);

            Assert.AreEqual(expected, actual);
        }

        private static bool Actual(string input)
        {
            var sut = new PrimeString();
            bool actual = sut.Accum(input);
            return actual;
        }

        [TestMethod]
        public void Input_a_shouldReturnIsTure()
        {
            var input = "a";
            var expected = true;
            AccumShouldBe(expected, input);
        }

        [TestMethod]
        public void Input_aa_shouldBeReturnIsFalse()
        {
            var input = "aa";
            var expected = false;

            AccumShouldBe(expected, input);
        }

        [TestMethod]
        public void Input_abaa_shoudBeReturnIsTure()
        {
            var input = "abab";
            var expected = false;

            AccumShouldBe(expected, input);
        }

        [TestMethod]
        public void Input_abcaddabcadd_shouldBeReturnIsFasle()
        {
            var input = "abcaddabcadd";
            var expected = false;

            AccumShouldBe(expected, input);
        }

        [TestMethod]
        public void Input_fdsyffdsyffdsyffdsyffdsyf_shouldBeReturnIsFasle()
        {
            var input = "fdsyffdsyffdsyffdsyffdsyf";
            var expected = false;

            AccumShouldBe(expected, input);
        }

        [TestMethod]
        public void Input_utdutdtdutd_shouldBeReturnIsFasle()
        {
            var input = "utdutdtdutd";
            var expected = true;

            AccumShouldBe(expected, input);
        }

        [TestMethod]
        public void Input_abba_shouldBeReturnIsFasle()
        {
            var input = "abba";
            var expected = true;

            AccumShouldBe(expected, input);
        }

    }
}
