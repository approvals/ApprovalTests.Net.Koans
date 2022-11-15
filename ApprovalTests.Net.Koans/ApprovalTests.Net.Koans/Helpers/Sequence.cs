using ApprovalUtilities.Utilities;

namespace ApprovalTestKoans.Helpers
{
	public class Sequence
	{
		public static string Print(int number)
		{
			int n1 = 1;
			int n2 = 1;
			for (int i = 2; i <= number; i++)
			{
				int n3 = n1 + n2;
				n1 = n2;
				n2 = n3;
			}
			return $"#{number} => {n2}";
		}
	}
}