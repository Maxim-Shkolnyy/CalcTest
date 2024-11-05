using RemObjects.Elements.EUnit;

namespace TestApp
{
	public class CalculatorTests : Test
	{

		public void TestAddMethod()
		{
			ClassWithData cd = new();
			Assert.AreEqual(5, cd.Add(2, 3));
		}


		public void TestSubtractMethod()
		{
			ClassWithData cd = new();
			Assert.AreEqual(1, cd.Subtract(3, 2));
		}
	}

	public static class Program
	{
		public static void Main(String[] args)
		{
			var testSuite = Discovery.DiscoverTests();
			Runner.RunTests(testSuite);
		}
	}
}