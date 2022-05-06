using System;

namespace Mini_Project_1
{
	public abstract class Computers : Assets
	{
		public override string ToString()
		{
			string outPut = (this.type).PadRight(10) + (this.brand).PadRight(10) + (this.model).PadRight(15) +
				(this.office).PadRight(10) + (this.purchaseDate).ToString("yy/MM/dd").PadRight(16) + 
				(this.price).ToString().PadRight(15) + (this.currency).PadRight(10);

			return outPut;
		}
	}

    public class MacBook : Computers
    {
        public MacBook(DateTime purchaseDate, int price, string type, string brand, string model,string office, string currency)
        {
			base.purchaseDate = purchaseDate;
			base.price = price;
			base.type = type;
			base.brand = brand;
			base.model = model;
			base.office = office;
			base.currency = currency;
        }
    }

    public class Asus : Computers
	{

		public Asus(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
		{
			base.purchaseDate = purchaseDate;
			base.price = price;
			base.type = type;
			base.brand = brand;
			base.model = model;
			base.office = office;
			base.currency = currency;
		}
	}

	public class Lenovo : Computers
	{

		public Lenovo(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
		{
			base.purchaseDate = purchaseDate;
			base.price = price;
			base.type = type;
			base.brand = brand;
			base.model = model;
			base.office = office;
			base.currency = currency;
		}
	}

	public class HP : Computers
	{

		public HP(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
		{
			base.purchaseDate = purchaseDate;
			base.price = price;
			base.type = type;
			base.brand = brand;
			base.model = model;
			base.office = office;
			base.currency = currency;
		}
	}
}
