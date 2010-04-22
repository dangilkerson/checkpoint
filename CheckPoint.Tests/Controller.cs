namespace CheckPoint.Tests
{
	public class Controller
	{
		private readonly Model model = new Model();

		public Controller()
		{
			Model2 = new Model();
		}

		private Model Model2 { get; set; }

		public void Action()
		{
			model.Method1();
			model.Method2();

			Model2.Method1();
			Model2.Method2();

			Model.StaticMethod();
		}

		public void ActionsAgainstSystemTypes()
		{
			model.ReturnsSystemType();
			model.ReturnsInt();
			string s = model.SomeProperty;

			Model2.ReturnsSystemType();
			Model2.ReturnsInt();
			string s2 = model.SomeProperty;
		}
	}
}