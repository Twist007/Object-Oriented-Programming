using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy
{
   public class Sale
    {
       public Sale(string productName, DateTime soldOn, decimal price)
       {
          this.ProductName = productName;
          this.SoldOn = soldOn;
          this.Price = price;
       }

       public string ProductName { get; set; }

       public DateTime SoldOn { get; set; }

       public decimal Price { get; set; }
    }
}
