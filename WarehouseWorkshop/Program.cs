using System;

namespace WarehouseWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock pandaBears = new Stock( 10, new Item("Panda Bear",   7.50M) );
            Stock toyTrains  = new Stock( 20, new Item("Toy Train" ,  20.00M) );
            Stock legoSets   = new Stock(  2, new Item("Lego Set"  , 110.00M) );

            List<Stock> stockList = new List<Stock>()
            {
                pandaBears,
                toyTrains,
                legoSets
            };

            Warehouse amazon = new Warehouse("The Big Amazon Warehouse", stockList);
            
            amazon.transactionHistory = new List<Transaction>{};

            amazon.stockTake();

            Basket myBasket = new Basket("Mrs Miggins");

            myBasket.addToBasket(pandaBears, 5);

            amazon.stockTake();

            amazon.transactionHistory.Add(myBasket.checkoutBasket());
        }
    }
}