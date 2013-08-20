using System;
using System.Drawing;
using ApprovalTestKoans.Helpers;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestKoans.Lesson01
{
	/**
 * How to do Koans:
 * Step 1: Run Test Ctrl+R, (Not Ctrl)T (This is very cursor dependent)
 * Step 2: Read the name of the Method that Failed
 * Step 3: Fill in the blank (___) to make it pass
 * Step 4: Repeat Until Enlightenment
 * Do not change anything except the blank (___)
 */

	[UseReporter(typeof (MsTestReporter))]
	[TestClass]
	public class GettingStarted : Koans
	{
		[TestMethod]
		public void NormalAsserts()
		{
			Assert.AreEqual("Small String", ___);
		}

		[TestMethod]
		public void ApprovalHidesTheExpectation()
		{
			Approvals.Verify(___);
			// Hint: If you double click the 1st line of the Failure Trace a diff tool will open
		}

		[TestMethod]
		public void ApprovalFileName()
		{
			var namer = Approvals.GetDefaultNamer();
			Assert.AreEqual(namer.Name, ___);
		}

		[TestMethod]
		public void _____()
		{
			var namer = Approvals.GetDefaultNamer();
			Assert.AreEqual(namer.Name, "GettingStarted.UsesMethodName");
		}

		[TestMethod]
		public void FileNames()
		{
			var namer = Approvals.GetDefaultNamer();
			string className = ___;
			string methodName = "FileNames";
			string approvalName = className + "." + methodName;
			Assert.AreEqual(namer.Name, approvalName);
		}

		[TestMethod]
		public void ChangingTheGoldenMaster()
		{
			Approvals.Verify("This is the golden master");
			//Hint: What is the name of the file where the blank is?
		}

		[TestMethod]
		public void VerifyObjects()
		{
			Rectangle r = new Rectangle();
			r.Width = 40;
			r.Height = 100;
			r.X = ____;
			r.Y = 200;
			Approvals.Verify(r);
		}

		[TestMethod]
		public void SometimeYouNeedABetterToString()
		{
			var p = new Person("Jayne", "Cobb", true, 38);
			string format = "Person\n  FirstName:{0}\n  LastName:{1}\n  Sex:{2}\n  Age:{3}\n";
			string custom = String.Format(format, p.FirstName, ___, p.IsMale ? "Male" : "Female", p.Age);
			Approvals.Verify(custom);
		}
	}
}