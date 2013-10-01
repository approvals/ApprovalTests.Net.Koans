namespace ApprovalTestKoans.Lesson05
{
    using System;
    using ApprovalTests.Combinations;
    using ApprovalTests.Reporters;
    using Helpers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /**
            * How to do Koans:
            * Step 1: Run Test Ctrl+R, (Not Ctrl)T (Click on the method to only run that test)
            * TroubleShoot : Ctrl+R, Ctrl+T will run in debug mode.
            * Step 2: Read the name of the Method that Failed, try to run 1 at a time.
            * Step 3: Fill in the blank (___) to make it pass
            * TroubleShoot: Do not change anything except the blank (___)
            * Step 4: Reflect for Enlightenment
          * Step 5: Continue
            *
            * NOTE: Each example builds on one another
            *
            */

    [UseReporter(typeof(VisualStudioReporter))]
    [TestClass]
    public class DataDrivenCombinations : Koans
    {
        [TestMethod]
        public void OneDimensionalInputIsTheSameAsArray()
        {
            string[] letters = { "a", "b", "c", ___, "e" };
            CombinationApprovals.VerifyAllCombinations(a => a, letters);
        }

        [TestMethod]
        public void TwoDimensionalInputGoesByTheSquare()
        {
            int[] small = { 1, 2, 3 };
            int[] big = { 11, ____, 55 };

            CombinationApprovals.VerifyAllCombinations((a, b) => a * b, small, big);
        }

        [TestMethod]
        public void ExceptionsAreOk()
        {
            int[] numerator = { 60, 126, 42 };
            int[] denominator1 = { 3, 2 };
            int[] denominator2 = { -1, ____, 1 };

            CombinationApprovals.VerifyAllCombinations((a, b, c) => a / (b + c), numerator, denominator1, denominator2);
        }

        [TestMethod]
        public void WorkingWithALambda()
        {
            var newMillenium = new DateTime(2000, 1, 1, 0, 0, 0);
            string[] years = { "yy", "yyyy" };
            string[] months = { "M", "MMM", "MMMM" };
            string[] days = { "dd", "dddd" };

            CombinationApprovals.VerifyAllCombinations((y, m, d) => newMillenium.ToString(y + "/" + ___ + "/" + d), years, months, days);
        }

        public DataDrivenCombinations()
        {
            ___ = "'" + ___ + "'";
        }
    }
}