namespace week1.DTOs.Store
{
    public class OrderDTO_ToCreate
    {
        public double TotalPrice { get; set; }
        public int TotalCount { get; set; }
        public string PaymentType { get; set; }
        public string OrderStatus { get; set; }  
    }
}