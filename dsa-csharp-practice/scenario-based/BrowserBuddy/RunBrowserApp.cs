using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public class RunBrowserApp
    {
        public static void Main(string[] args)
        {
            IBrowserBuddy browser = new BrowserBuddyImpl();
            bool running = true;

            Console.WriteLine("=== BROWSER BUDDY ===");

            while (running)
            {
                BrowserUtility.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string t = BrowserUtility.GetString("Title");
                        string u = BrowserUtility.GetString("URL");
                        browser.VisitNewPage(t, u);
                        break;
                    case "2":
                        browser.GoBack();
                        break;
                    case "3":
                        browser.GoForward();
                        break;
                    case "4":
                        browser.CloseCurrentTab();
                        break;
                    case "5":
                        browser.RestoreClosedTab();
                        break;
                    case "6":
                        browser.ShowCurrentPage();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}
