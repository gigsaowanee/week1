using week1.Models;

namespace week1.DTOs
{
    public class CustomerDTO_ToReturn
    {
        
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string BankAccount { get; set; }
        public double Balance { get; set; }
    }
}