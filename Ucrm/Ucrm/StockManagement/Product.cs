using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement
{
    public class Product
    {
        /// <summary>
        /// Product Atributes 
        /// </summary>
        string prodName;
        string prodCategory;
        string prodSubCategory;
        string prodExtraInfo;
        int amount;
        ProdStatus prodStatus;
        Guid pId;
        float price;
        


        /// <summary>
        /// Product Properties/getters+setters
        /// </summary>
        public string Name
        {
            get
            {
                return prodName;
            }

            set
            {
                prodName = value;
            }
        }

        public string Category
        {
            get
            {
                return prodCategory;
            }

            set
            {
                prodCategory = value;
            }
        }

        public string SubCategory
        {
            get
            {
                return prodSubCategory;
            }

            set
            {
                prodSubCategory = value;
            }
        }

        public string ExtraInfo
        {
            get
            {
                return prodExtraInfo;
            }

            set
            {
                prodExtraInfo = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public ProdStatus Status
        {
            get
            {
                return prodStatus;
            }

            set
            {
                prodStatus = value;
            }
        }

        public Guid Id
        {
            get
            {
                return pId;
            }

            set
            {
                pId = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
