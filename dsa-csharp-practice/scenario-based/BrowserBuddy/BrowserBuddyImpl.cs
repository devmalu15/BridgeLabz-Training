using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public class BrowserBuddyImpl : IBrowserBuddy
    {
        public HistoryNode CurrentPage = null;
        public StackNode ClosedTabsTop = null;

        public void VisitNewPage(string title, string url)
        {
            Page newPage = new Page(title, url);
            HistoryNode newNode = new HistoryNode(newPage);

            if (CurrentPage == null)
            {
                CurrentPage = newNode;
            }
            else
            {
                CurrentPage.Next = newNode;
                newNode.Prev = CurrentPage;
                CurrentPage = newNode;
            }
            Console.WriteLine($"    Visited: {title}");
        }

        public void GoBack()
        {
            if (CurrentPage == null || CurrentPage.Prev == null)
            {
                Console.WriteLine("    [!] Cannot go back.");
                return;
            }
            CurrentPage = CurrentPage.Prev;
            Console.WriteLine($"    Navigated Back to: {CurrentPage.Data.Title}");
        }

        public void GoForward()
        {
            if (CurrentPage == null || CurrentPage.Next == null)
            {
                Console.WriteLine("    [!] Cannot go forward.");
                return;
            }
            CurrentPage = CurrentPage.Next;
            Console.WriteLine($"    Navigated Forward to: {CurrentPage.Data.Title}");
        }

        public void CloseCurrentTab()
        {
            if (CurrentPage == null)
            {
                Console.WriteLine("    [!] No tab open to close.");
                return;
            }

            StackNode newStackNode = new StackNode(CurrentPage);
            newStackNode.Next = ClosedTabsTop;
            ClosedTabsTop = newStackNode;

            Console.WriteLine($"    Closed Tab: {CurrentPage.Data.Title}");
            CurrentPage = null;
        }

        public void RestoreClosedTab()
        {
            if (ClosedTabsTop == null)
            {
                Console.WriteLine("    [!] No closed tabs to restore.");
                return;
            }

            if (CurrentPage != null)
            {
                Console.WriteLine("    [!] Close current tab before restoring another.");
                return;
            }

            CurrentPage = ClosedTabsTop.TabState;
            ClosedTabsTop = ClosedTabsTop.Next;

            Console.WriteLine($"    Restored Tab: {CurrentPage.Data.Title}");
        }

        public void ShowCurrentPage()
        {
            Console.WriteLine("\n    === BROWSER STATE ===");
            if (CurrentPage != null)
            {
                Console.WriteLine($"    Active Page: {CurrentPage.Data.Title}");
                Console.WriteLine($"    URL:         {CurrentPage.Data.Url}");
                Console.WriteLine($"    Time:        {CurrentPage.Data.Timestamp}");
            }
            else
            {
                Console.WriteLine("    [Empty Tab]");
            }
            Console.WriteLine("    =====================\n");
        }
    }
}
