using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise.Model
{
	public class Car
	{
		public Engine CarEngine { get; set; }
		public Seat CarSeat { get; set; }
		public SteeringWheel CarSteeringWheel { get; set; }
		public Lacquer CarLacquer { get; set; }
		public Tire CarTire { get; set; }
	}
}
