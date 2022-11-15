using ApprovalTestKoans.Helpers;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace ApprovalTestKoans.Lesson03
{
	/// To solve these puzzles, follow the directions
	[TestClass]
	public class ApprovingTheResult : Koans
	{
		[TestMethod]
		[UseReporter(typeof (QuietReporter))]
		public void RenameTheApproved()
		{
			// Directions: 
			// 1)Run the test
			// 2)Manually rename The .received. File to .approved.  
			// Hint: Use the "Open Folder In File Explorer" option when you right click on your solution
			Approvals.Verify("Manually Renamed");
		}

		[TestMethod]
		[UseReporter(typeof (FileLauncherReporter))]
		public void SaveAsApproved()
		{
			// Directions: 
			// 1)Run the test
			// 2)Save the launched file as .approved.  
			Approvals.Verify("Saved as golden master");
		}

		[TestMethod]
		[UseReporter(typeof (ClipboardReporter))]
		public void MoveTheFileViaCommandLine()
		{
			// Directions: 
			// 1)Run the test
			// 2) The Open a command line (CMD), and paste (right mouse click) the command the move command from your clipboard  
			Approvals.Verify("Moved by command line");
		}

		[TestMethod]
		[UseReporter(typeof (VisualStudioReporter))]
		public void CopyAndPasteContentInVisualStudio()
		{
			// Directions: 
			// 1)Run the test
			// 2) The Open a command line (CMD), and paste (right mouse click) the command the move command from your clipboard  
			Approvals.Verify("Copied & Pasted Via Visual Studio");
		}

		[TestMethod]
		[UseReporter(typeof (DiffReporter))]
		public void UseWholeFileInADiffReporter()
		{
			// Directions: 
			// You will need to have a diff reporter installed on you system to do this.
			// 1)Run the test
			// 2) Right click the result in your diff tool and select use whole file.

			/*
       * Currently supported Diff Tools are
       * Windows:
       * AraxisMerge
		   * BeyondCompare
       * CodeCompare
			 * KDiff
			 * P4Merge
       * TortoiseDiff
       * WinMerge
			 */

			Approvals.Verify("Moved over in a diff tool");
		}
	}
}