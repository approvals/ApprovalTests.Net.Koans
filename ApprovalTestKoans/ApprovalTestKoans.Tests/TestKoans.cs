using System;
using ApprovalTestKoans.Helpers;
using ApprovalTestKoans.Lesson01;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestKoans.Tests
{
	[TestClass]
	public class TestKoans
	{
		[TestMethod]
		public void TestGettingStarted()
		{
			VerifyKoan<GettingStarted>(k => k.NormalAsserts, "Small String");
			VerifyKoan<GettingStarted>(k => k.ApprovalHidesTheExpectation, "This is in the approved file");
			VerifyKoan<GettingStarted>(k => k.ApprovalFileName, "GettingStarted.ApprovalFileName");
			VerifyKoanIsUnsolved<GettingStarted>(k => k.ApprovalFileName);
			VerifyKoan<GettingStarted>(k => k.FileNames, "GettingStarted");
		}

		private void VerifyKoanIsUnsolved<T>(Func<T, Action> method) where T : Koans, new()
		{
			RunKoan(method, new T(), pass: false);
		}

		private void VerifyKoan<T>(Func<T, Action> method, string answer) where T : Koans, new()
		{
			VerifyKoanIsUnsolved(method);
			var k = new T();
			k.___ = answer;
			RunKoan(method, k, pass: true);
		}


		private static void RunKoan<T>(Func<T, Action> method, T k, bool pass) where T : Koans, new()
		{
			Exception exception = ExceptionUtilities.GetException(() => method(k).Invoke());
			if (pass)
			{
				if (exception != null)
				{
					throw exception;
				}
			}
			else
			{
				if (exception == null)
				{
					Assert.Fail("The method {0} is already passing".FormatWith(method.Method.Name));
				}
			}
		}
	}
}