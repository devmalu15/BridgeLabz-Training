using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public interface IBrowserBuddy
    {
        void VisitNewPage(string title, string url);
        void GoBack();
        void GoForward();
        void CloseCurrentTab();
        void RestoreClosedTab();
        void ShowCurrentPage();
    }
}
