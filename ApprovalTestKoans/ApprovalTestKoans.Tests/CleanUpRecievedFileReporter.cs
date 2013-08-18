using System.IO;
using ApprovalTests.Core;

namespace ApprovalTestKoans.Tests
{
	public class CleanUpRecievedFileReporter : IEnvironmentAwareReporter
	{
		public void Report(string approved, string received)
		{
			File.Delete(received);
		}

		public bool IsWorkingInThisEnvironment(string forFile)
		{
			return true;
		}
	}
}