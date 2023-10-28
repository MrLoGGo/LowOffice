using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawOffice
{
    internal class Pages
    {
        private Dictionary<string, Panel> pages = new Dictionary<string, Panel>();
        public void Add(string pageName, ref Panel pageObj)
        {
            pages.Add(pageName, pageObj);
        }
        public void OpenPage(string openPageName)
        {
            pages[openPageName].BringToFront();
        }
    }
}
