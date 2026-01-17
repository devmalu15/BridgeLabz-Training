using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public class Page
    {
        public string Title;
        public string Url;
        public DateTime Timestamp;

        public Page(string title, string url)
        {
            Title = title;
            Url = url;
            Timestamp = DateTime.Now;
        }
    }
}
