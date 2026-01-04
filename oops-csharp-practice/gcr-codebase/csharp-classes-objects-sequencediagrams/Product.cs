using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesObjectsAndSequenceDiagram
{
    public class Product
    {
        public string productName;
        public double quantity;
        public double pricePerUnit;

        public Product(string productName, double quantity, double pricePerUnit)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
        }

        public double GetTotalCost()
        {
            return quantity * pricePerUnit;
        }
    }
}
