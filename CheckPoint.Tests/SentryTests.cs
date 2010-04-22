using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeMock.ArrangeActAssert;

namespace CheckPoint.Tests
{
	[TestClass]
	public class SentryTests
	{
		[TestMethod]
		[Isolated]
		public void GetInteractions()
		{
			Sentry s = Monitor.Interactions(typeof (Controller));

			var controller = new Controller();
			controller.Action();

			Approvals.Approve(s.Report);
		}

		[TestMethod]
		[Isolated]
		public void GetInteractionsAgainstSystemTypes()
		{
			Sentry s = Monitor.Interactions(typeof (Controller));

			var controller = new Controller();
			controller.ActionsAgainstSystemTypes();

			Approvals.Approve(s.Report);
		}

		[TestMethod]
		[Isolated]
		public void GetListOfCalls()
		{
			Sentry s = Monitor.Calls<Model>();

			var controller = new Controller();
			controller.Action();

			Approvals.Approve(s.Report);
		}
	}
}