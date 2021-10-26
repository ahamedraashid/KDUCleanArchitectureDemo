namespace Application.Common.Dtos
{
    public class AccountDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public decimal Balance { get; set; }
        public string AccountType { get; set; }
    }
}
