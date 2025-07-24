
namespace Contracts
{
    public interface IFoodServise
    {
      
        public void CountFood();
        public void CountDrink();
        public void CountOverall();
        public  void MaxPrice();
        public int MaxNumberOfRequests();
        public void MinPrice();
        public int  MinNumberOfRequests();
        public void PrintAll();
        public void AvgPrice();
       
        public void SearchById(int id);
        public void GetMostPopularItem();
    }
    public class FoodDto { 
    public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDrink { get; set; }
        public decimal Price { get; set; }
        public int NumberOfRequests { get; set; }
        public void PrintInfo() {
            Console.WriteLine($"Id:{Id},Name:{Name},Price:{Price},Number of requests:{NumberOfRequests}");
        }
    }
}
