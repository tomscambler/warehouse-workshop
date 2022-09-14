namespace WarehouseWorkshop
{
    public class Transaction
    {
        public List<Stock> transactionStock = new List<Stock>{};
        public int transactionId;
        public bool transactionIsApproved;

        public Transaction(List<Stock> transactionStock, int transactionId, bool transactionIsApproved)
        {
            this.transactionStock = transactionStock;
            this.transactionId = transactionId;
            this.transactionIsApproved = transactionIsApproved;
        }
    }
}
