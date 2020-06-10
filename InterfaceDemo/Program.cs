using System;

namespace InterfaceDemo
{
	public class Program
	{
		private static IAnimal _animal;
		static void Main(string[] args)
		{

			_animal = new Dog();
			Console.WriteLine(_animal.MakeSound());
			Console.WriteLine(_animal.MoveForward(8));
			Console.ReadKey();
		}
	}
}
