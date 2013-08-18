package org.approvaltests.koans.lesson02;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import org.approvaltests.Approvals;
import org.approvaltests.koans.helpers.Koans;
import org.approvaltests.koans.helpers.Sequence;
import org.approvaltests.reporters.JunitReporter;
import org.approvaltests.reporters.UseReporter;
import org.junit.Test;
import org.lambda.functions.Function1;

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
@UseReporter(JunitReporter.class)
public class Collections extends Koans
{
  @Test
  public void SimpleArrays() throws Exception
  {
    String[] approvalsIsPortedTo = {".Net", ___, "Perl", "Ruby", "Php", "Node.js"};
    Approvals.verifyAll("Language", approvalsIsPortedTo);
  }
  @Test
  public void ListsWorkTheSameAsArrays() throws Exception
  {
    List<String> approvalsIsGoodFor = new ArrayList<String>();
    approvalsIsGoodFor.add("Strings");
    approvalsIsGoodFor.add("Objects");
    approvalsIsGoodFor.add("Log Files");
    approvalsIsGoodFor.add("JPanels");
    approvalsIsGoodFor.add(___);
    approvalsIsGoodFor.add("Xml");
    approvalsIsGoodFor.add("Html");
    approvalsIsGoodFor.add("Json");
    approvalsIsGoodFor.add("Email");
    Approvals.verifyAll("Good For", approvalsIsGoodFor);
  }
  @Test
  public void MapsAreSortedBeforeDisplay() throws Exception
  {
    HashMap<Integer, String> m = new HashMap<Integer, String>();
    m.put(1000, "M");
    m.put(10, "X");
    m.put(1, "I");
    m.put(100, "C");
    m.put(5, "V");
    m.put(500, "D");
    m.put(50, ___);
    Approvals.verify(m);
  }
  @Test
  public void TheUseOfTheLabel() throws Exception
  {
    String[] greatTv = {
        "Firefly", "Game of Throne", "Futurama", "Arrested Development", "Big Bang Theory", "Better Off Ted"};
    Approvals.verifyAll(___, greatTv);
  }
  @Test
  public void ApprovalHelpShowWhenThingsHaveBeenRemoved() throws Exception
  {
    HashMap<String, String> m = new HashMap<String, String>();
    m.put("Miss Scarlet", "Conservitory");
    m.put("Colonel Mustard", "Kitchen");
    m.put("Mrs. White", "Billiard Room");
    m.put("Mr. Green", "Library");
    m.put("Mrs. Peacock", "Dining Room");
    m.put("Professor Plum", "Study");
    m.remove(___);
    Approvals.verify(m);
  }
  @Test
  public void ApprovalHelpShowWhenThingsHaveBeenAdded() throws Exception
  {
    HashMap<String, String> punch = new HashMap<String, String>();
    punch.put("Orange Juice", "2 cups");
    punch.put("Lime Juice", "1/2 cup");
    punch.put("Fruit Juice", "1 cup");
    punch.put("Strawberries", "20");
    punch.put("Mint leaves", "3");
    punch.put("Sprite", "2 cups");
    //punch.put(___,___); // <-- Uncomment Line to solve
    Approvals.verify(punch);
  }
  @Test
  public void HeadersHelpExplainTheContextWhenThingsAreConfusing() throws Exception
  {
    String header = ___;
    Integer[] values = {1, 2, 6, 9, 11};
    Approvals.verifyAll(header, values, new Sequence());
  }
  @Test
  public void TransformingArraysManually() throws Exception
  {
    int[] numbers = {1, 3, ____, 10, 12, 16};
    StringBuffer b = new StringBuffer();
    for (int i : numbers)
    {
      b.append(String.format("%s^2 = %s\n", i, i * i));
    }
    Approvals.verify(b);
  }
  @Test
  public void TransformingArraysWithFunctions() throws Exception
  {
    Integer[] numbers = {1, 3, 5, 10, 12, 16};
    Approvals.verifyAll("Squares", numbers, new Function1<Integer, String>()
    {
      public String call(Integer i)
      {
        return ___;
      }
    });
  }
  @Test
  public void TransformingArraysWithLambdas() throws Exception
  {
    // This requires java8
    Integer[] numbers = {1, 3, 5, 10, 12, 16};
    Approvals.verifyAll("Squares", numbers, n -> ___);
  }
}
