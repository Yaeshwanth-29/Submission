namespace User_and_Account_Management.Controllers.DTOs
{
    public class TransactionRequestDto
    {
        public int UserID { get; set; }
        public decimal Amount { get; set; }
    }

    public class TransactionResponseDto
    {
        public string Message { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
