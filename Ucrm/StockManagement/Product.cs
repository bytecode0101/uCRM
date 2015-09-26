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
        


        /// <summary>
        /// Product Properties/getters+setters
        /// </summary>
        public string ProdName
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

        public string ProdCategory
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

        public string ProdSubCategory
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

        public string ProdExtraInfo
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

        public ProdStatus ProdStatus
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

        public Guid PId
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
    }
}
