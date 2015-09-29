using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    public class Address
    {
        /// <summary>
        /// Holds address details of users
        /// </summary>
        /// 


        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Extra { get; set; }
        public string Phone { get; set; }

        public Address()
        {

        }
        /// <summary>
        /// Populate countries list for user to select and print to screen. Holds the country selected by user
        /// </summary>
        /// <returns></returns>
        public string SelectCountry()
        {
            

            string[] Countries = { "Afganistan", "Algeria", "Albania","Algeria", "Andorra", "Angola", "Anguilla",
                "Argentina","Bahrain", "Canada","Chile", "China","Colombia"};
                            

                foreach (var country in Countries)
                {
                    Console.WriteLine(country);
                }

            string mycountry = "";
            int CountryLocation = Array.IndexOf(Countries, mycountry);
            string CountrySelected = Countries[CountryLocation];
            Console.WriteLine(CountrySelected);

            return CountrySelected;
                 

        }

        public void SelectCity()
        {

        }

                
    }
}
