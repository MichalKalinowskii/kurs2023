using BuilderExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
	public class TireBuilder
	{
		public Car Car { get; set; }
		public TireBuilder(Car car)
		{
			Car = car;
		}
		public void TireType(string tireType) => Car.CarTire.TireType = tireType;
		public void TireProducer(string tireProducer) => Car.CarTire.TireProducer = tireProducer;
		public void TirePrize(int tirePrize) => Car.CarTire.TirePrize = tirePrize;

	}
}
