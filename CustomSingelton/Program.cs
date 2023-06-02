namespace CustomSingelton
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}

	public class Singellton
	{
		public static readonly List<object> List = new List<object>();
		public Singellton(object obj)
		{
			List.Add(obj);
		}
	}

	
}