using Study.Interfaces;

namespace Study.Models
{
    public class Myproducts : IMyproducts
    {
        public int Id { get; set; }
        public string? productName { get; set; }
        public decimal productPrice { get; set; }
    }
}
