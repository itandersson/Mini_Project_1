using System;
using System.Collections.Generic;

namespace Mini_Project_1
{
	public class Assets
	{
		private static List<Assets> assets = new List<Assets>();
		private DateTime endOfLife = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddYears(-3).AddMonths(-3);
		public DateTime purchaseDate;
		public int price;
		public string type;
		public string brand;
		public string model;
		public string office;
		public string currency;

		public void setList(List<Assets> assetList) 
		{
			assets = assetList;
		}

		public void printSortedList()
		{
			string outPut = "Type".PadRight(10) + "Brand".PadRight(10) + "Model".PadRight(15) +
				"Office".PadRight(10) + "Purchase Date".PadRight(16) + "Price in USD".PadRight(15) +
				"Currency".PadRight(10);

			Console.WriteLine(outPut);
			Console.WriteLine("____________________________________________________________________________________");

			//Print assets in red if older than 3 years and 3 month
			foreach (Assets asset in assets)
			{
				int res = DateTime.Compare(endOfLife, asset.purchaseDate);
				if (res < 0) { Console.ForegroundColor = ConsoleColor.White; }
				else { Console.ForegroundColor = ConsoleColor.Red; }
				Console.WriteLine( asset.ToString() );
			}

			Console.WriteLine("\n");
		}
    }
}