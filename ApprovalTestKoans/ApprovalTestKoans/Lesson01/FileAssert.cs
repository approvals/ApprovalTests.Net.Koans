using System.IO;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestKoans.Lesson01
{
	public class FileAssert
	{
		public static void VerifyContentsIsEqual(string file, string actual)
		{
			var expected  = File.ReadAllText(PathUtilities.GetAdjacentFile(file));
			Assert.AreEqual(expected,actual);
		}
	}
}