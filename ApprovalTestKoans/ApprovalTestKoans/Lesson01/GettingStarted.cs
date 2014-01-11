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
		public void AssertAgainstFileContents()
		{
			FileAssert.VerifyContentsIsEqual("expected.txt", ___);
		}

		[TestMethod]
		public void UsingAutomaticFileNames()
		{
			var namer = Approvals.GetDefaultNamer();
			FileAssert.VerifyContentsIsEqual(namer.Name + ".txt", ___);
		}

		
		[TestMethod]
		public void AutomaticallyGeneratedNames()
		{
			var namer = Approvals.GetDefaultNamer();
			Assert.AreEqual(namer.Name, ___);
		}

		[TestMethod]
		public void _____()
		{
			var namer = Approvals.GetDefaultNamer();
			Assert.AreEqual("GettingStarted.UsesMethodName", namer.Name);
		}

		[TestMethod]
		public void PiecesOfTheFileName()
		{
			var namer = Approvals.GetDefaultNamer();
			string className = ___;
			string methodName = "PiecesOfTheFileName";
			string approvalName = className + "." + methodName;
			Assert.AreEqual(namer.Name, approvalName);
		}

		[TestMethod]
		public void VerifyingBiggerText()
		{
			Rectangle r = new Rectangle();
			r.Width = 100;
			r.Height = ____;
			r.X = 134;
			r.Y = 162;
			var namer = Approvals.GetDefaultNamer();
			FileAssert.VerifyContentsIsEqual(namer.Name + ".txt", r.ToString());
		}

		[TestMethod]
		public void ApprovalsUsesThisFileNameConvention()
		{
			Approvals.Verify(___);
		}

		[TestMethod]
		[UseReporter(typeof(VisualStudioReporter))]
		public void SeeingFilesSideBySide()
		{
			var namer = Approvals.GetDefaultNamer();
			Approvals.Verify(___ + "\r\n" + namer.Name);
		}

		[TestMethod]
		public void ChangingTheExpectation()
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