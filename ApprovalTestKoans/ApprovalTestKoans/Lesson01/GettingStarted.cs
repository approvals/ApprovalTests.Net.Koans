using ApprovalTestKoans.Helpers;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestKoans.Lesson01
{
	/**
 * How to do Koans:
 * Step 1: Press the Run Button (Place cursor on the Method name to run a single method)
 * PC: Ctrl+F11
 * Mac: Command+fn+F11
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

//		@Test
//		public
//		void ApprovalHidesTheExpectation 
//		()
//		throws
//		Exception
//		{
//			Approvals.verify(___);
//			// Hint: If you double click the 1st line of the Failure Trace a diff tool will open
//		}
//		@Test
//		public
//		void ApprovalFileName 
//		()
//		throws
//		Exception
//		{
//			ApprovalNamer namer = Approvals.createApprovalNamer();
//			Assert.assertEquals(namer.getApprovalName(), ___);
//		}
//		@Test
//		public
//		void ___ 
//		()
//		throws
//		Exception
//		{
//			ApprovalNamer namer = Approvals.createApprovalNamer();
//			Assert.assertEquals(namer.getApprovalName(), "GettingStarted.UsesMethodName");
//		}
//		@Test
//		public
//		void FileNames 
//		()
//		throws
//		Exception
//		{
//			ApprovalNamer namer = Approvals.createApprovalNamer();
//			String className = ___;
//			String methodName = "FileNames";
//			String approvalName = className + "." + methodName;
//			Assert.assertEquals(namer.getApprovalName(), approvalName);
//		}
//		@Test
//		public
//		void ChangingTheGoldenMaster 
//		()
//		throws
//		Exception
//		{
//			Approvals.verify("This is the golden master");
//		}
//		@Test
//		public
//		void VerifyObjects 
//		()
//		throws
//		Exception
//		{
//			Rectangle r = new Rectangle();
//			r.width = 40;
//			r.height = 100;
//			r.x = ____;
//			r.y = 200;
//			Approvals.verify(r);
//		}
//		@Test
//		public
//		void SometimeYouNeedABetterToString 
//		()
//		throws
//		Exception
//		{
//			Person p = new Person("jane", "smith", true, 38);
//			String format = "Person\n  FirstName:%s\n  LastName:%s\n  Sex:%s\n  Age:%s\n";
//			String custom = String.format(format, p.getFirstName(), ___, p.isMale() ? "Male" : "Female", p.getAge());
//			Approvals.verify(custom);
//		}
//	}
	}
}