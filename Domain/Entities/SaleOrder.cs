namespace Domain.Entities
{
    public class SaleOrder
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
