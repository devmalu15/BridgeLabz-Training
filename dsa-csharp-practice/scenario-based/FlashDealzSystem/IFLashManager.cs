using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.FlashDealzSystem
{
    public interface IFlashManager
    {
        void AddProduct(string name, double discount);
        void SortProducts();
        void DisplayDeals();
    }
}
