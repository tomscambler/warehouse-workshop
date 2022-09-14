namespace WarehouseWorkshop
{
    public class Stock
    {
        private int stockAmount;
        public int StockAmount
        { 
            get
            {
                return stockAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", value, "Cannot go below zero.");
                }

                stockAmount = value;
            }
        }
        public Item StockItem{ get; set; }

        public Stock( int stockAmount, Item stockItem)
        {
            this.StockAmount = stockAmount;
            this.StockItem = stockItem;
        }

        public void adjustStock(int adjustStockAmount)
        {
            if (adjustStockAmount < StockAmount)
            {
                StockAmount = StockAmount - adjustStockAmount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("value", StockAmount, "Cannot go below zero.");
            }
        }

    }
}
