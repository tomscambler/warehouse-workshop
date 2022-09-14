namespace WarehouseWorkshop
{
    public class Warehouse
    {
        private string WarehouseName { get; set; }
        public List<Stock> stockList = new List<Stock>{};
        public List<Transaction> transactionHistory = new List<Transaction>{};

        public Warehouse(string WarehouseName, List<Stock> stockList)
        {
            this.stockList = stockList;
            this.WarehouseName = WarehouseName;
        }

        public void generateReport()
        {
            foreach(Transaction transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }

        public void completeTransaction(Transaction transaction)
        {
            //check stock level
            //check transaction id
            //add transaction to transaction history
            //modify stockList
        }
        public void stockTake()
        {
            Console.WriteLine($"The {WarehouseName} warehouse currently holds the following stock:\n");

            decimal totalValue = 0;

            foreach(Stock stock in stockList)
            {
                Console.WriteLine($"{stock.StockItem.ItemName}, {stock.StockAmount}");
                totalValue += stock.StockAmount * stock.StockItem.ItemPrice;
            }

            Console.WriteLine($"\nThe total value of the stock is: £{totalValue}\n");
        }

    }
}