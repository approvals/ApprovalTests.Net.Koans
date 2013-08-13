using System;
using ApprovalTestKoans.Helpers;
using ApprovalTestKoans.Lesson01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestKoans.Tests
{
	[TestClass]
	public class TestKoans
	{
		[TestMethod]
		public void TestGettingStarted()
		{
			//verify koan
			verifyKoan<GettingStarted>(k => k.NormalAsserts, "Small String");
		}

		private void verifyKoan<T>(Func<T, Action> method, string answer) where T:Koans, new()
		{
			//make sure the test fails
			Assert.IsTrue(RunKoan(method, new T()));
			//make sure the test succeeds
			var k = new T();
			k.___= answer;
			Assert.IsFalse(RunKoan(method, k));

		}

		private static bool RunKoan<T>(Func<T, Action> method, T k) where T : Koans, new()
		{
			var failed = false;
			try
			{
				method(k).Invoke();
			}
			catch (Exception)

			{
				failed = true;
			}
			return failed;
		}
	}
}
