using System.Text;

namespace ApprovalTestKoans.Helpers
{
	public class Koans
	{
		public string ___ = "Please fill in the blank";
		public int ____ = 0;

		public string decode(string text)
		{
			int offshift = 9;
			return push(text, offshift);
		}

		public string push(string text, int offshift)
		{
			var b = new StringBuilder();
			foreach (char c in text)
			{
				b.Append((char) (c + offshift));
			}
			return b.ToString();
		}
	}
}