using StockManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{/// <summary>
/// Holds the details of the shopping cart for its assigned user and uses them to create invoice
/// </summary>
    class Invoice
    {
        
        int invoice_no;
        User user;
        Cart cart;
        Address address;
        Product product;

        public int Invoice_no { get; set; }
    
        public Invoice()
        {
            User user = new User();
            Cart cart = new Cart(user.id);
            Product product = new Product();
         }   
        /// <summary>
        /// Method to create the invoice using the details of the user and his shopping cart
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cart"></param>
        /// <param name="address"></param>
        /// <returns></returns>
            public DataTable MakeInvoice(User user, Cart cart, Address address)
        {
            DataTable invoice_details = new DataTable();
            invoice_details.Columns.Add("Number", typeof(int));
            invoice_details.Columns.Add("Name", typeof(User));
            invoice_details.Columns.Add("Item", typeof(string));
            invoice_details.Columns.Add("Price", typeof(float));

            invoice_details.Rows.Add(Invoice_no);
            invoice_details.Rows.Add(user.name);
            invoice_details.Rows.Add(product.Name);
            invoice_details.Rows.Add(product.Price);

            return invoice_details;
            
        }
        /// <summary>
        /// Prints the invoice details according to the invoice resulted from MakeInvoice()
        /// </summary>
        /// <param name="invoice_details"></param>
        public void PrintInvoice(DataTable invoice_details)
        {
            foreach (var DataRow in invoice_details.Rows)
            {
                Console.WriteLine(DataRow);
            }
        }

        
        

        
        
       
    }
}
