﻿using ApprovalTestKoans.Helpers;
using ApprovalTestKoans.Lesson01;
using ApprovalTestKoans.Lesson02;
using ApprovalTestKoans.Lesson03;
using ApprovalTestKoans.Lesson04;
using ApprovalUtilities.Utilities;


namespace ApprovalTestKoans.Tests
{
    using Lesson05;

    [TestClass]
   
    public class TestKoans
    {
        [TestMethod]
        public void TestGettingStarted()
        {
            VerifyKoan<GettingStarted>(k => k.NormalAsserts, "Small String");
            VerifyKoan<GettingStarted>(k => k.AssertAgainstFileContents, "Small String");
						VerifyKoan<GettingStarted>(k => k.UsingAutomaticFileNames, "Deleted code is debugged code.");
						VerifyKoan<GettingStarted>(k => k.AutomaticallyGeneratedNames, "GettingStarted.AutomaticallyGeneratedNames");
            VerifyKoanIsUnsolved<GettingStarted>(k => k._____);
            VerifyKoan<GettingStarted>(k => k.PiecesOfTheFileName, "GettingStarted");
						VerifyKoan<GettingStarted>(k => k.VerifyingBiggerText, 42);
						VerifyKoan<GettingStarted>(k => k.ApprovalsUsesThisFileNameConvention, "This is in the approved file");
						VerifyKoan<GettingStarted>(k => k.SeeingFilesSideBySide, "This file is called");
            VerifyKoanIsUnsolved<GettingStarted>(k => k.ChangingTheExpectation);
            VerifyKoan<GettingStarted>(k => k.VerifyObjects, 150);
            VerifyKoan<GettingStarted>(k => k.SometimeYouNeedABetterToString, "Cobb");
        }

        [TestMethod]
        public void TestCollections()
        {
            VerifyKoan<Collections>(k => k.SimpleArrays, ".Net");
            VerifyKoan<Collections>(k => k.ListsWorkTheSameAsArrays, "Collections");
            VerifyKoan<Collections>(k => k.DictionariesAreSortedBeforeDisplay, "L");
            VerifyKoan<Collections>(k => k.TheUseOfTheLabel, "TV Show");
            VerifyKoan<Collections>(k => k.ApprovalHelpShowWhenThingsHaveBeenRemoved, "Mr. Green");
            VerifyKoanIsUnsolved<Collections>(k => k.ApprovalHelpShowWhenThingsHaveBeenAdded);
            VerifyKoan<Collections>(k => k.HeadersHelpExplainTheContextWhenThingsAreConfusing,
                                    "Numbers in the Fibonacci sequence");
            VerifyKoan<Collections>(k => k.TransformingArraysManually, 5);
            VerifyKoan<Collections>(k => k.TransformingArraysWithLambdas, "{0}^2 = {1}");
        }

        [TestMethod]
        public void TestApprovingTheResult()
        {
            VerifyKoanIsUnsolved<ApprovingTheResult>(k => k.RenameTheApproved);
            VerifyKoanIsUnsolved<ApprovingTheResult>(k => k.SaveAsApproved);
            VerifyKoanIsUnsolved<ApprovingTheResult>(k => k.MoveTheFileViaCommandLine);
            VerifyKoanIsUnsolved<ApprovingTheResult>(k => k.CopyAndPasteContentInVisualStudio);
            VerifyKoanIsUnsolved<ApprovingTheResult>(k => k.UseWholeFileInADiffReporter);
        }

        [TestMethod]
        public void TestUsingReporters()
        {
            VerifyKoanIsUnsolved<ConfiguringReporters>(k => k.ConfiguringTheFileLauncherReporterAtTheMethodLevel);
            VerifyKoanIsUnsolved<ConfiguringReporters>(k => k.ConfiguringAClassLevelDefault);
            VerifyKoanIsUnsolved<ConfiguringReportersPart2>(k => k.ConfiguringAnAssemblyLevelDefault);

            //	VerifyKoan<UsingReporters>(k => k.UsingTextReportersForInsight, "Forty Two");
            //	VerifyKoan<UsingReporters>(k => k.UsingImageForInsight, "blue");
        }

        [TestMethod]
        public void TestDataDrivenCombinations()
        {
            this.VerifyKoan<DataDrivenCombinations>(k => k.OneDimensionalInputIsTheSameAsArray, "d");
            this.VerifyKoan<DataDrivenCombinations>(k => k.TwoDimensionalInputGoesByTheSquare, 33);
            this.VerifyKoan<DataDrivenCombinations>(k => k.ExceptionsAreOk, -2);
            this.VerifyKoanIsUnsolved<DataDrivenCombinations>(k => k.WorkingWithALambda);
        }

        private void VerifyKoanIsUnsolved<T>(Func<T, Action> method) where T : Koans, new()
        {
            RunKoan(method, new T(), pass: false);
        }

        private void VerifyKoan<T>(Func<T, Action> method, object answer) where T : Koans, new()
        {
            VerifyKoanIsUnsolved(method);
            var k = new T();
            k.___ = answer as string;
            k.____ = (int)(answer is int ? answer : 0);
            RunKoan(method, k, pass: true);
        }

        private static void RunKoan<T>(Func<T, Action> method, T k, bool pass) where T : Koans, new()
        {
            Exception exception = ExceptionUtilities.GetException(() => method(k).Invoke());
            if (pass)
            {
                if (exception != null)
                {
                    throw new Exception("Did Not Pass", exception);
                }
            }
            else
            {
                if (exception == null)
                {
                    Assert.Fail($"The method {method.Method.Name} is already passing");
                }
            }
        }
    }
}