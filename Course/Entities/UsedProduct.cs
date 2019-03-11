using System;
using System.Globalization;


namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string priceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToShortDateString()})";
        }

    }
}
