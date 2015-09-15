using System;

namespace Ucrm
{
    /// <summary>
    /// Category class for categories products 
    /// </summary>

    class Category
    {
        public Guid Id { get; set; } //Category ID
        public string Name { get; set; } //Name ofthe category


        /// <summary>
        /// Category constructor
        /// </summary>
        /// <param name="_Name"></param>
        public Category(string _Name)
        {
            this.Id = Guid.NewGuid();
            this.Name = _Name;

        }
    }
}
