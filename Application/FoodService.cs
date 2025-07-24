
using System;
using Domin;
using Contracts;

namespace Application
{
  
  
    public class FoodServises : IFoodServise {
       public List<Food> food = new List<Food>
       
{
    new Food { Id = 1, Name = "Margherita Pizza",     IsDeleted = false, IsDrink = false, Price = 25.99m, NumberOfRequests = 120 },
    new Food { Id = 2, Name = "Cheeseburger",         IsDeleted = false, IsDrink = false, Price = 20.50m, NumberOfRequests = 95 },
    new Food { Id = 3, Name = "Chicken Shawarma",     IsDeleted = false, IsDrink = false, Price = 18.00m, NumberOfRequests = 140 },
    new Food { Id = 4, Name = "Spaghetti Bolognese",  IsDeleted = false, IsDrink = false, Price = 28.00m, NumberOfRequests = 110 },
    new Food { Id = 5, Name = "Caesar Salad",         IsDeleted = false, IsDrink = false, Price = 15.75m, NumberOfRequests = 60 },

    new Food { Id = 6, Name = "Pepsi",                IsDeleted = false, IsDrink = true,  Price = 5.00m,  NumberOfRequests = 200 },
    new Food { Id = 7, Name = "Fresh Orange Juice",   IsDeleted = false, IsDrink = true,  Price = 9.50m,  NumberOfRequests = 90 },
    new Food { Id = 8, Name = "Iced Coffee",          IsDeleted = false, IsDrink = true,  Price = 12.00m, NumberOfRequests = 75 },
    new Food { Id = 9, Name = "Mineral Water",        IsDeleted = false, IsDrink = true,  Price = 3.50m,  NumberOfRequests = 150 },
    new Food { Id = 10, Name = "Mango Smoothie",      IsDeleted = false, IsDrink = true,  Price = 13.50m, NumberOfRequests = 65 },

    new Food { Id = 11, Name = "Tandoori Chicken",    IsDeleted = false, IsDrink = false, Price = 30.00m, NumberOfRequests = 80 },
    new Food { Id = 12, Name = "French Fries",        IsDeleted = false, IsDrink = false, Price = 10.00m, NumberOfRequests = 130 },
    new Food { Id = 13, Name = "Beef Steak",          IsDeleted = false, IsDrink = false, Price = 45.00m, NumberOfRequests = 55 },

    new Food { Id = 14, Name = "Old Coffee",          IsDeleted = true,  IsDrink = true,  Price = 10.00m, NumberOfRequests = 5 },
    new Food { Id = 15, Name = "Expired Sandwich",    IsDeleted = true,  IsDrink = false, Price = 20.00m, NumberOfRequests = 0 },
};
        // I added data using ai.
        public List<FoodDto> fooddto = new List<FoodDto>();

        public void FillFoodDto(List<Food> food)
        {
            foreach (var foods in food)
            {
                if (foods.IsDeleted == false)
                {
                    var dto = new FoodDto
                    {
                        Id = foods.Id,
                        Name = foods.Name,
                        IsDrink = foods.IsDrink,
                        Price = foods.Price,
                        NumberOfRequests = foods.NumberOfRequests
                    };

                    fooddto.Add(dto);
                }
            }
        }
        public void CountFood() {
            Console.WriteLine($"The number of food(not drinks) in the menu is:{fooddto.Count(x=>x.IsDrink==false)}");
        
        }
        public void CountDrink() {
            Console.WriteLine($"The number of  drinks in the menu is:{fooddto.Count(x => x.IsDrink== true)}");
        }
        
        public void CountOverall() {
            Console.WriteLine($"The number  overall is:{fooddto.Count(x => true)})");
        }
        public virtual void MaxPrice() {
            Console.Write("The food with the highest price is: ");
            fooddto.MaxBy(x => x.Price)?.PrintInfo();

        }

        public void MinPrice() {
            Console.Write("The food with the Lowest price is: ");
            fooddto.MinBy(x => x.Price)?.PrintInfo();

        }
        public int MaxNumberOfRequests() {
            return fooddto.Max(x => x.NumberOfRequests);
        }
        public int MinNumberOfRequests()
        {
            return fooddto.Min(x => x.NumberOfRequests);
        }
        public void PrintAll() {
            foreach (var food in fooddto)
            { food.PrintInfo(); 
            }
                
        }
        public void AvgPrice() {
            Console.WriteLine($"the avg price for the restaurant:{fooddto.Average(x=>x.Price)}");
        }
       
        public void SearchById(int id) {
            fooddto.FirstOrDefault(x => x.Id == id)?.PrintInfo();

        }
        public void GetMostPopularItem() {
            fooddto.MaxBy(x => x.NumberOfRequests)?.PrintInfo();


        }

    }

        
 
   
}
