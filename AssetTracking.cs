using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_1
{
    internal class AssetTracking
    {
        static List<Assets> assetList = new List<Assets>();

        static void Main(string[] args)
        {
            Assets asset = new Assets();

            // list of assets
            assetList.Add(new Iphone(DateTime.Parse("2018/12/29"), 970, "Phone", "iPhone", "8", "Spain", "EUR"));
            assetList.Add(new HP(DateTime.Parse("2019/06/01"), 1423, "Computer", "HP", "Elitebook", "Spain", "EUR"));
            assetList.Add(new Iphone(DateTime.Parse("2020/09/25"), 990, "Phone", "iPhone", "11", "Spain", "EUR"));
            assetList.Add(new Iphone(DateTime.Parse("2018/07/15"), 1245, "Phone", "iPhone", "X", "Sweden", "SEK"));
            assetList.Add(new Motorola(DateTime.Parse("2020/03/16"), 970, "Phone", "Motorola", "Razr", "Sweden", "SEK"));
            assetList.Add(new HP(DateTime.Parse("2020/10/02"), 588, "Computer", "HP", "Elitebook", "Sweden", "SEK"));
            assetList.Add(new Asus(DateTime.Parse("2017/04/21"), 1200, "Computer", "Asus", "W234", "USA", "USD"));
            assetList.Add(new Lenovo(DateTime.Parse("2018/05/28"), 835, "Computer", "Lenovo", "Yoga 730", "USA", "USD"));
            assetList.Add(new Lenovo(DateTime.Parse("2019/05/21"), 1030, "Computer", "Lenovo", "Yoga 530", "USA", "USD"));

            //Prints a sorted list with computers first, then phones
            List<Assets> SortedCPuterFirst = assetList.OrderBy(item => item.type).ToList<Assets>();
            asset.setList(SortedCPuterFirst);
            asset.printSortedList();

            input(asset);
        }

        private static void input(Assets asset)
        {
            bool run = true;

            string welcome = "Add new asset\n" +
                "Exit program by write \"q\" (for quit).!\n\n" +
                "(1) Show Assets (Sorted by office)\n" +
                "(2) Show Assets (Sorted by purchase date)\n" +
                "(3) Add New Asset\n";

            while (run)
            {
                Console.WriteLine(welcome);
                Console.Write("Pick an option: ");
                string input = Console.ReadLine();

                //If "q" chosen quit
                if (input.Trim().ToLower() == "q") { run = false; }

                int value;
                int.TryParse(input, out value);

                switch (value)
                {
                    case 1:
                        //Prints a sorted list by office
                        List<Assets> SortedByOffice = assetList.OrderBy(item => item.office).ToList<Assets>();
                        asset.setList(SortedByOffice);
                        asset.printSortedList();
                        continue;
                    case 2:
                        //Prints a sorted list by purchase date
                        List<Assets> SortedByPurchase = assetList.OrderBy(item => item.purchaseDate).ToList<Assets>();
                        asset.setList(SortedByPurchase);
                        asset.printSortedList();
                        continue;
                    case 3:
                        addNewAsset();
                        continue;
                }
            }
        }
        private static void addNewAsset()
        {
            Console.Write("\tEnter purchase date (Ex: 2022/05/09): ");
            string purchaseDate = Console.ReadLine();

            Console.Write("\tEnter Price (USD): ");
            int price;
            int.TryParse(Console.ReadLine(), out price);

            Console.Write("\tEnter type (Phone or Computer): ");
            string type = Console.ReadLine();

            Console.Write("\tEnter brand (Ex: IPhone, Asus and Motorola): ");
            string brand = Console.ReadLine();

            Console.Write("\tEnter model (Ex: 8, W234 and Razr): ");
            string model = Console.ReadLine();

            Console.Write("\tEnter office (Spain, Sweden or USA): ");
            string office = Console.ReadLine();

            Console.Write("\n");

            Assets asset = createAsset(purchaseDate, price, type, brand, model, office);

            //If the asset was created
            if (asset != null)
            {
                assetList.Add(asset);
                Console.WriteLine('\t' + "Thank you! your asset was successfully added to list." + '\n');
            }
            else { Console.WriteLine('\t' + "An error occurred! Please try again" + '\n'); }

        }

        private static Assets createAsset(string purchaseDate, int price, string type, string brand, string model, string office)
        {
            bool fail = false;
            Assets asset = null;
            string currency = "";

            brand = brand.ToLower();
            office = office.ToLower();

            //Assign currency by office
            switch (office)
            {
                case "spain":
                    currency = "EUR";
                    break;

                case "sweden":
                    currency = "SEK";
                    break;

                case "usa":
                    currency = "USD";
                    break;

                default:
                    fail = true;
                    Console.WriteLine("Error: \"" + office + "\" does not exist!");
                    break;
            }

            //Create asset if brand match
            switch (brand)
            {
                case "macbook":
                    asset = new MacBook(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "asus":
                    asset = new Asus(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "lenovo":
                    asset = new Lenovo(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "hp":
                    asset = new HP(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "iphone":
                    asset = new Iphone(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "samsung":
                    asset = new Samsung(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "nokia":
                    asset = new Nokia(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                case "motorola":
                    asset = new Motorola(DateTime.Parse(purchaseDate), price, type, brand, model, office, currency);
                    break;

                default:
                    fail = true;
                    Console.WriteLine("Error: \"" + brand + "\" is not a allowed brand!");
                    break;
            }

            //if an error occurred, ensure that null is returned
            if (fail) { asset = null; }

            return asset;
        }
    }
}
