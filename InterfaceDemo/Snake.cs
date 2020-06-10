using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
	class Snake : IAnimal
	{
		public string MakeSound()
		{
			return "Hiss, hiss";
		}

		public string MoveForward(int paces)
		{
			return $"I slither {paces} steps forward";
		}
	}
}
