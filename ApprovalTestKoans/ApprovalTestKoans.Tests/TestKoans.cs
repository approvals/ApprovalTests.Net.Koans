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
			verifyKoan<GettingStarted>(k => k.NormalAsserts, "Small String");
			verifyKoan<GettingStarted>(k => k.ApprovalHidesTheExpectation, "This is in the approved file");
			verifyKoan<GettingStarted>(k => k.ApprovalFileName, "GettingStarted.ApprovalFileName");
		}

		private void verifyKoan<T>(Func<T, Action> method, string answer) where T : Koans, new()
		{
			RunKoan(method, new T(), pass: false);
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