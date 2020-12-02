using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Tests
{
    class Task1_test
    {
        [TestCase(new object[] { 1, 2, "a", "b" }, new object[] { 1, 2 })]
        [TestCase(new object[] { "asf", "2", "345", 1, 2, "a", "b", "asf", "2", "345", 1 }, new object[] { 1, 2, 1 })]
        [TestCase(new object[] { "1", 2, "345", 1, 2, "a", "b", "asf", "2", 345, 1 }, new object[] { 2, 1, 2, 345, 1})]

        public void GetIntegerFromListTest(object[] input_list, object[] output_list)
        {
            var res = Lab1.Task1.GetIntegerFromList(input_list.ToList());
            Assert.AreEqual(res, output_list.ToList());
        }
    }
    class Task2_test
    {
        [TestCase("sExs", 'E')]
        [TestCase("s", "s")]
        [TestCase("ssaa", "")]
        public void first_non_repeating_letter_Test(string input_str, char output_char)
        {
            var res = Lab1.Task2.First_non_repeating_letter(input_str);
            Assert.AreEqual(res, output_char);
        }
    }
    class Task3_test
    {
        [TestCase(22, 4)]
        [TestCase(493193, 2)]

        public void DigitalRootTest(int input, int output)
        {
            var res = Lab1.Task3.DigitalRoot(input);
            Assert.AreEqual(res, output);
        }
    }
    class Task4_test
    {
        [TestCase(new int[] { 1, 4, 2, 2, 3, 0, 5, 6 }, 4, 5)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 11, 2, 10, 3, 9, 4, 8 }, 4, 12)]

        public void NumberOfPairsTest(int[] input_array, int output, int turgetnumber = 5)
        {
            var res = Lab1.Task4.NumberOfPairs(input_array, turgetnumber);
            Assert.AreEqual(res, output);
        }
    }
    class Task5_test
    {
        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill", "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("", "")]

        public void MeetingTest(string input_str, string output_str)
        {
            var res = Lab1.Task5.Meeting(input_str);
            Assert.AreEqual(res, output_str);
        }
    }
    class ExtraTask1_test
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(9, -1)]
        [TestCase(111, -1)]
        [TestCase(531, -1)]

        public void nextBiggerTest(int input, int output)
        {
            var res = Lab1.ExtraTask1.nextBigger(input);
            Assert.AreEqual(res, output);
        }
    }
}
