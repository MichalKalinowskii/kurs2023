namespace BuilderExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CarBuilder cb = new();
			//przykład
			cb.BuildEngine().BuildSeat().BuildSteeringWheel().BuildLacquer().BuildTire();
		}
	}
}