namespace Storage.Models
{
    public class ProductViewModel
    {
        //error:
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
