using BuilderExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
	public class SteeringWheelBuilder
	{
		public Car Car { get; set; }
		public SteeringWheelBuilder(Car car)
		{
			Car = car;
		}
		public void SteeringWheelType(string steeringWheelType) => Car.CarSteeringWheel.SteeringWheelType = steeringWheelType;
		public void SteeringWheelPrize(int steeringWheelPrize) => Car.CarSteeringWheel.SteeringWheelPrize = steeringWheelPrize;

		public LacquerBuilder BuildLacquer()
		{
			return new LacquerBuilder(this.Car);
		}
	}
}
