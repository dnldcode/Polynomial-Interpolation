﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes
{
	class VandermondeMatrix : Matrix
	{
		public void toVandermonde()
		{
			for (int i = 0; i < this.listOfEquations.Count; i++)
			{
				this.SetEquation(i, new Equation($"{Math.Pow(listOfEquations[i].Array.First(), 2)} {listOfEquations[i].Array.First()} {1} {listOfEquations[i].Array.Last()}"));
			}
		}
	}
}
