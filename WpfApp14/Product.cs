using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum TypesProduct
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public string PathImage { get; set; }
        public double Price { get; set; }
        public TypesProduct TypeProduct { get; set; }

    }
}
