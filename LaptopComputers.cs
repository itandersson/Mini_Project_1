using System;

namespace Mini_Project_1
{
	public class LaptopComputers
	{
		private int endOfLife = 3;
		private DateTime purchaseDate = DateTime.MinValue;
		private int price = 0;
		private string modelName = "";

		public LaptopComputers()
		{
		}
	}

	public class MacBook : LaptopComputers
	{

		public MacBook()
		{
		}
	}

	public class Asus : LaptopComputers
	{

		public Asus()
		{
		}
	}

	public class Lenovo : LaptopComputers
	{

		public Lenovo()
		{
		}
	}

}
