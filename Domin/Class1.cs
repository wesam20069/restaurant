namespace Domin
{
    public class Food
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDrink { get; set; }
        public decimal Price { get; set; }
        public int NumberOfRequests { get; set; }

    }
}
