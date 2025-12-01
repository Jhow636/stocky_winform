namespace Stocky.Models
{
    public class Exit
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; } = string.Empty;
        public int RegisteredByUserId { get; set; }
        public string RegisteredByUserEmail { get; set; } = string.Empty;
    }
}