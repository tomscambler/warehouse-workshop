namespace WarehouseWorkshop
{
    public class Basket
    {
        public List<Stock> basketStockList = new List<Stock>{};
        public string CustomerName{ get; set; }
        public Basket(string customerName)
        {
            this.CustomerName = customerName;
        }

        public void addToBasket(Stock stockItem, int requestedQuantity)
        {
            if (requestedQuantity <= stockItem.StockAmount)
            {
                basketStockList.Add(new Stock(requestedQuantity, stockItem.StockItem));
                stockItem.adjustStock(requestedQuantity);
            }
        }
        public Transaction checkoutBasket()
        {
            Random rnd = new Random();
            int transactionId = rnd.Next(100000,999999);

            //arbitrarily, the transaction is only approved if the id comes back as even
            bool transactionIsApproved = transactionId%2==0;

            return new Transaction(basketStockList, transactionId, transactionIsApproved);
        }
    }
}