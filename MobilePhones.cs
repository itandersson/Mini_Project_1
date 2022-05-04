using System;

namespace Mini_Project_1
{

	public class MobilePhones
	{
		private int endOfLife = 3;
		private DateTime purchaseDate = DateTime.MinValue;
		private int price = 0;
		private string modelName = "";

		public MobilePhones()
		{
		}
	}

	public class Iphone : MobilePhones
	{

		public Iphone()
		{
		}
	}

	public class Samsung : MobilePhones
	{

		public Samsung()
		{
		}
	}

	public class Nokia : MobilePhones
	{

		public Nokia()
		{
		}
	}

}
