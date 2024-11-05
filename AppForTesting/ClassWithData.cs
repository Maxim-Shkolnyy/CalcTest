namespace AppForTesting
{
	public class ClassWithData : IClassWithData
	{
		public int Add (int a, int b)
		{
			return a + b;
		}

		public int Substract (int a, int b)
		{
			return a - b;
		}
	}
}