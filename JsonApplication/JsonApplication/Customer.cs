namespace JsonApplication
{
    [Serializable]
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public decimal TotalSales { get; set; }
        public DateTime FinalPurchaseDate { get; set; }
    }
}
