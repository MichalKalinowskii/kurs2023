using BuilderExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
	public class SeatBuilder
	{
		public Car Car { get; set; }
		public SeatBuilder(Car car)
		{
			Car = car;
		}
		public void SeatType(string seatType) => Car.CarSeat.SeatType = seatType;
		public void SeatPrize(int seatPrize) => Car.CarSeat.SeatPrize = seatPrize;

		public SteeringWheelBuilder BuildSteeringWheel()
		{
			return new SteeringWheelBuilder(this.Car);
		}
	}
}
