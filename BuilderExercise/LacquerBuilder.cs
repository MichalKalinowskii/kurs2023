using BuilderExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
	public class LacquerBuilder
	{
		public Car Car { get; set; }
		public LacquerBuilder(Car car)
		{
			Car = car;
		}
		public void LacquerBuildType(string lacquerBuildType) => Car.CarLacquer.LacquerType = lacquerBuildType;
		public void LacquerBuildPrize(int lacquerBuildPrize) => Car.CarLacquer.LacquerPrize = lacquerBuildPrize;

		public TireBuilder BuildTire()
		{
			return new TireBuilder(this.Car);
		}
	}
}
