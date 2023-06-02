using BuilderExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
	public class CarBuilder 
	{
		public Car Car { get; set; }

		public CarBuilder()
		{

		}
		public EngineBuilder BuildEngine()
		{
			return new EngineBuilder(this.Car);
		}

	}
}
