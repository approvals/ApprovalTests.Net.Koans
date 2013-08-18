using System;
using ApprovalTestKoans.Helpers;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Approvals = ApprovalTests.Approvals;

namespace ApprovalTestKoans.Lesson04
{
	[TestClass]
	public class UsingReporters : Koans
	{
		[TestMethod]
		[UseReporter(typeof (_____))]
		public void ConfiguringTheFileLauncherReporter()
		{
			var reporter = Approvals.GetReporter();
			Assert.IsInstanceOfType(reporter, typeof (FileLauncherReporter));
		}

//  [TestMethod]
//  public void ConfiguringAClassLevelDefault() 
//  {
//    var reporter = ReporterFactory.getFromAnnotation();
//    Assert.assertTrue(reporter.getClass().getName(), reporter instanceof _____);
//  }
//  [TestMethod]
// [UseReporter(typeof({ClipboardReporter.class, ImageWebReporter.class, TortoiseImageDiffReporter.class})
//  public void ConfiguringMultipleReporters() 
//  {
//    var  reporter = ReporterFactory.getFromAnnotation();
//    MultiReporter multi = (MultiReporter) reporter;
//    var  second = multi.getReporters()[1];
//    Assert.assertTrue(second.getClass().getName(), second instanceof _____);
//  }
//  [TestMethod]
// [UseReporter(typeof(FileLauncherReporter))]
//  public void UsingTextReportersForInsight() 
//  {
//    if (!decode("=fikpKnf").equals(____))
//    {
//      var  reporter = ReporterFactory.getFromAnnotation();
//      reporter.report(getPath("Insight.txt"), "");
//      Assert.fail("Please fill in the blank");
//    }
//  }
//  [TestMethod]
// [UseReporter(typeof(ImageWebReporter))]
//  public void UsingImageForInsight() 
//  {
//    String whatWasTheOldColor = ___;
//    if (!decode("Ycl\\").equals(whatWasTheOldColor.toLowerCase()))
//    {
//      var  reporter = ReporterFactory.getFromAnnotation();
//      reporter.report(getPath("NewImage.png"), getPath("OldImage.png"));
//      Assert.fail("Please fill in the blank");
//    }
//  }
	}

	public class _____ : IApprovalFailureReporter
	{
		public void Report(string approved, string received)
		{
			throw new NotImplementedException();
		}
	}
}