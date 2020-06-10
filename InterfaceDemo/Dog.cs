using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
	class Dog : IAnimal
	{
		public string MakeSound()
		{
			return "Bark, bark";
		}

		public string MoveForward(int paces)
		{
			return $"Run forward {paces} steps";
		}
	}
}
