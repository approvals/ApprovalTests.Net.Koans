using ApprovalUtilities.Utilities;

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