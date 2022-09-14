namespace WarehouseWorkshop
{
    public class Item
    {
        private decimal itemPrice;
        
        public string ItemName { get; set; }

        public decimal ItemPrice 
        { 
            get { return itemPrice; } 
            set { itemPrice = Math.Round(value,2); } 
        }

        public Item(string itemName, decimal itemPrice)
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
        }

        public void AmendPrice(decimal newItemPrice)
        {
            ItemPrice = newItemPrice;
        }
    }
}