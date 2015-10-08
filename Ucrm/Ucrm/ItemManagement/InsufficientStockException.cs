using System;

namespace Ucrm.ItemManagement
{
    public class InsufficientStockException : Exception
    {
        public InsufficientStockException():base("You have less items in stock than you would like to withdraw")
        {
        }
    }
}
