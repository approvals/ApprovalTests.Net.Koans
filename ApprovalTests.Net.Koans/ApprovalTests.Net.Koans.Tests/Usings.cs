global using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests.Reporters.TestFrameworks;

[assembly: ApprovalTests.Reporters.FrontLoadedReporter(typeof(MsTestReporter))]