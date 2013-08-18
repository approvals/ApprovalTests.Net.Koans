using System;
using System.Collections.Generic;
using ApprovalTestKoans.Helpers;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestKoans.Lesson02
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

	[UseReporter(typeof (DiffReporter))]
	[TestClass]
	public class Collections : Koans
	{
		[TestMethod]
		public void SimpleArrays()
		{
			string[] approvalsIsPortedTo = {___, "Java", "Perl", "Ruby", "Php", "Node.js"};
			Approvals.VerifyAll(approvalsIsPortedTo, "Language");
		}

		[TestMethod]
  public void ListsWorkTheSameAsArrays() 
  {
    var approvalsIsGoodFor = new List<string>();
    approvalsIsGoodFor.Add("Strings");
    approvalsIsGoodFor.Add("Objects");
    approvalsIsGoodFor.Add("Log Files");
    approvalsIsGoodFor.Add("WinForms");
    approvalsIsGoodFor.Add("WPF");
    approvalsIsGoodFor.Add("RDLC Reports");
    approvalsIsGoodFor.Add("ASP Pages");
    approvalsIsGoodFor.Add("ASP.MVC Pages");
    approvalsIsGoodFor.Add("ASP Routes");
    approvalsIsGoodFor.Add("Entity Framework Queries");
    approvalsIsGoodFor.Add(___);
    approvalsIsGoodFor.Add("Xml");
    approvalsIsGoodFor.Add("Html");
    approvalsIsGoodFor.Add("Json");
    approvalsIsGoodFor.Add("Email");
    Approvals.VerifyAll( approvalsIsGoodFor,"Good For");
  }
		[TestMethod]
		public void DictionariesAreSortedBeforeDisplay()
  {
    var m = new Dictionary<int, string>();
    m[1000]= "M";
    m[10]= "X";
    m[1]= "I";
    m[100]= "C";
    m[5]= "V";
    m[500]= "D";
    m[50]= ___;
    Approvals.VerifyAll(m);
  }
		[TestMethod]
  public void TheUseOfTheLabel() 
  {
    string[] greatTv = {
        "Firefly", "Game of Throne", "Futurama", "Arrested Development", "Big Bang Theory", "Better Off Ted"};
    Approvals.VerifyAll( greatTv,___);
  }
//  @Test
//  public void ApprovalHelpShowWhenThingsHaveBeenRemoved() throws Exception
//  {
//    HashMap<String, String> m = new HashMap<String, String>();
//    m.put("Miss Scarlet", "Conservitory");
//    m.put("Colonel Mustard", "Kitchen");
//    m.put("Mrs. White", "Billiard Room");
//    m.put("Mr. Green", "Library");
//    m.put("Mrs. Peacock", "Dining Room");
//    m.put("Professor Plum", "Study");
//    m.remove(___);
//    Approvals.verify(m);
//  }
//  @Test
//  public void ApprovalHelpShowWhenThingsHaveBeenAdded() throws Exception
//  {
//    HashMap<String, String> punch = new HashMap<String, String>();
//    punch.put("Orange Juice", "2 cups");
//    punch.put("Lime Juice", "1/2 cup");
//    punch.put("Fruit Juice", "1 cup");
//    punch.put("Strawberries", "20");
//    punch.put("Mint leaves", "3");
//    punch.put("Sprite", "2 cups");
//    //punch.put(___,___); // <-- Uncomment Line to solve
//    Approvals.verify(punch);
//  }
//  @Test
//  public void HeadersHelpExplainTheContextWhenThingsAreConfusing() throws Exception
//  {
//    String header = ___;
//    Integer[] values = {1, 2, 6, 9, 11};
//    Approvals.verifyAll(header, values, new Sequence());
//  }
//  @Test
//  public void TransformingArraysManually() throws Exception
//  {
//    int[] numbers = {1, 3, ____, 10, 12, 16};
//    StringBuffer b = new StringBuffer();
//    for (int i : numbers)
//    {
//      b.append(String.format("%s^2 = %s\n", i, i * i));
//    }
//    Approvals.verify(b);
//  }
//  @Test
//  public void TransformingArraysWithFunctions() throws Exception
//  {
//    Integer[] numbers = {1, 3, 5, 10, 12, 16};
//    Approvals.verifyAll("Squares", numbers, new Function1<Integer, String>()
//    {
//      public String call(Integer i)
//      {
//        return ___;
//      }
//    });
//  }
//  @Test
//  public void TransformingArraysWithLambdas() throws Exception
//  {
//    // This requires java8
//    Integer[] numbers = {1, 3, 5, 10, 12, 16};
//    Approvals.verifyAll("Squares", numbers, n -> ___);
//  }
	}
}