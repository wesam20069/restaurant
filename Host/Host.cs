
using System;
using Application;
class HelloWorld
{
    static void Main()
    {
        FoodServises FoodHost = new FoodServises();
        FoodHost.FillFoodDto(FoodHost.food);

        Console.WriteLine("================================== MENU REPORT ==================================\n");

        FoodHost.CountFood();
        Console.WriteLine("---------------------------------------------------------------------------------");

        FoodHost.CountDrink();
        Console.WriteLine("---------------------------------------------------------------------------------");

        FoodHost.CountOverall();
        Console.WriteLine("---------------------------------------------------------------------------------");

        Console.WriteLine(" Max Price Item:");
        FoodHost.MaxPrice();
        Console.WriteLine("---------------------------------------------------------------------------------");

        Console.WriteLine(" Min Price Item:");
        FoodHost.MinPrice();
        Console.WriteLine("---------------------------------------------------------------------------------");

        Console.WriteLine(" All Menu Items:");
        FoodHost.PrintAll();
        Console.WriteLine("---------------------------------------------------------------------------------");

        Console.WriteLine(" Average Price:");
        FoodHost.AvgPrice();
        Console.WriteLine("---------------------------------------------------------------------------------");

        Console.Write("Please enter the ID of the food you want: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Result:");
        FoodHost.SearchById(n);
        Console.WriteLine("---------------------------------------------------------------------------------");

        Console.WriteLine(" Most Popular Item:");
        FoodHost.GetMostPopularItem();
        Console.WriteLine("=================================================================================");
        // Just used AI to polish console output messages. Core logic untouched!
    }
}

