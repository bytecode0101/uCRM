using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    class ReturnProduct
    {
     
            public void CustomerChoice() {  } // check Customer's choice of return(refund/deliver another product)
            public bool CheckReason() { return false; }
            public bool CheckProduct() { return false; } // check the returned product to see if the customer's issue was legit
            public bool ChangeProduct() { return false; } //change the product if CheckReason = true; CheckProduct = true;
            public bool RefundProduct() { return false; } //return money to customer if CheckReason = true; CheckProduct = true; id DateTime = Legal DateTime for returning a product;

            public ReturnProduct()
            {
                if (CheckReason())
                {
                    //if (ChangeProduct())
                        //init procedura de schimbareprod + costuri transport
                    //if (RefundProduct())
                        //init procedura de returnare suma +- costuri transport
                }
            }
        }
    }
