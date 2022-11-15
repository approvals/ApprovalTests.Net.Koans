package org.approvaltests.koans.lesson03;

import org.approvaltests.Approvals;
import org.approvaltests.reporters.ClipboardReporter;
import org.approvaltests.reporters.DiffReporter;
import org.approvaltests.reporters.FileLauncherReporter;
import org.approvaltests.reporters.QuietReporter;
import org.approvaltests.reporters.UseReporter;
import org.junit.Test;

/**
 * To solve these puzzles, follow the directions
 */
public class ApprovingTheResult
{
  @Test
  @UseReporter(QuietReporter.class)
  public void RenameTheApproved() throws Exception
  {
    // Directions: 
    // 1)Run the test
    // 2)Manually rename The .received. File to .approved.  
    // Hint: remember to refresh the file list
    Approvals.verify("Manually Renamed");
  }
  @Test
  @UseReporter(FileLauncherReporter.class)
  public void SaveAsApproved() throws Exception
  {
    // Directions: 
    // 1)Run the test
    // 2)Save the launched file as .approved.  
    Approvals.verify("Saved as golden master");
  }
  @Test
  @UseReporter(ClipboardReporter.class)
  public void MoveTheFileViaCommandLine() throws Exception
  {
    // Directions: 
    // 1)Run the test
    // 2) The Open a command line (terminal), and paste the command the move command from your clipboard  
    Approvals.verify("Moved by command line");
  }
  @Test
  @UseReporter(DiffReporter.class)
  public void UseWholeFileInADiffReporter() throws Exception
  {
    // Directions: 
    // You will need to have a diff reporter installed on you system to do this.
    // 1)Run the test
    // 2) Right click the result in your diff tool and select use whole file.
    /*
     * Currently supported Diff Tools are
     * Mac:
     * DiffMerge
     * TkDiff
     * Kaleidoscope
     * 
     * Windows:
     * BeyondCompare
     * TortoiseDiff
     * WinMerge
     */
    Approvals.verify("Moved over in a diff tool");
  }
}
