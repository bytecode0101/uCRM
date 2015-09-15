using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    /// <summary>
    /// Category class for categories products 
    /// </summary>

    class Category
    {
        public Guid Id { get; set; } //Category ID
        public string Name { get; set; } //Name ofthe category
    }
}
