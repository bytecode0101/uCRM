using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    /// <summary>
    /// The ReturnProduct class handles the product return/refund requests from out customers
    /// </summary>
    class ReturnProduct
    {
        /// <summary>
        /// CustomerChoice check Customer's choice of return(refund/deliver another product)
        /// </summary>
        public void CustomerChoice() {  }

        /// <summary>
        /// CheckReason check if there is a valid reason for returning
        /// </summary>
        /// <returns>returns "true" if theres a valid reason and "false" if the reason its invalid</returns>
        public bool CheckReason() { return false; }

        /// <summary>
        /// CheckProduct check the returned product to see if the customer's issue was legit
        /// </summary>
        /// <returns>returns "true" if the product was not damaged by the customer/"false" if it was damage and is not recievable</returns>
        public bool CheckProduct() { return false; } 

        /// <summary>
        /// if CheckProduct returns true - initialise the product return procedure, adding transportation costs if we
        /// deliver the product with acourier
        /// </summary>
        /// <returns>"true" if we initialise the procedure/ "false" - default value</returns>
            public bool ChangeProduct() { return false; }

        /// <summary>
        ///  RefundProduct return money to customer if CheckReason = true; CheckProduct = true; id DateTime = Legal DateTime for returning a product;
        /// </summary>
        /// <returns>>"true" if we initialise the procedure/ "false" - default value</returns>
        public bool RefundProduct() { return false; }

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
