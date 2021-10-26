namespace Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public decimal Balance { get; set; }
        public string AccountType { get; set; }
    }
}
