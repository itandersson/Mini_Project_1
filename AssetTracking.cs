using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_1
{
    internal class AssetTracking
    {
        static void Main(string[] args)
        {
            List<Assets> assetList = new List<Assets>();
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
            asset.setList( SortedCPuterFirst );
            asset.printSortedList();

            //Prints a sorted list by purchase date
            List<Assets> SortedPurchase = assetList.OrderBy(item => item.purchaseDate).ToList<Assets>();
            asset.setList( SortedPurchase );
            asset.printSortedList();

            input();
        }

        static void input() 
        {
            string welcome = "Welcome to ToDoLy\n" +
                "You have " + x + " tasks todo and " + y + " tasks are done!\n\n" +
                "(1) Show Task List (by date or project)\n" +
                "(2) Add New Task\n" +
                "(3) Edit Task (update, mark as done, remove)\n" +
                "(4) Save and Quit\n";

            while (run)
            {
                Console.WriteLine(welcome);
                Console.Write("Pick an option: ");
                int value = int.Parse(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        showTaskList(list);
                        continue;
                    case 2:
                        Task item = addNewTask();
                        list.Add(item);
                        Console.WriteLine('\t' + "Thank you, a new task was successfully added." + '\n');
                        continue;
                    case 3:
                        editTask(list);
                        continue;
                    case 4:
                        run = false;
                        break;
                }
            }
    }
}
