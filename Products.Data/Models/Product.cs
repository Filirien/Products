namespace Products.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Description { get; set; }

        public int TypeId { get; set; }

        public ProductType ProductType { get; set; }
    }
}
