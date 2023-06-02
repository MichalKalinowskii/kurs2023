using BuilderExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
	public class EngineBuilder
	{
		public Car Car { get; set; }
		public EngineBuilder(Car car)
		{
			Car = car;
		}

		public void EngineType(string engineName) => Car.CarEngine.EngineType = engineName;
		public void EnginePower(int enginePower) => Car.CarEngine.EnginePower = enginePower;
		public void EngineCapacity(int engineCapacity) => Car.CarEngine.EngineCapacity = engineCapacity;
		public void EngiePrize(int enginePrize) => Car.CarEngine.EngiePrize = enginePrize;

		public SeatBuilder BuildSeat()
		{
			return new SeatBuilder(this.Car);
		}
	}
}
