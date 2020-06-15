using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        public readonly List<MenuItem> m_MenuItems = new List<MenuItem>();
        string title;
        
        public MainMenu()
        {
            MenuItem menuItem = new MenuItem("Version and Digits");
            menuItem.AttachObserver(new ReportClickedDelegate(this.reportClicked));
            m_MenuItems.add(menuItem);


            menuItem = new MenuItem("Show Date/Time");
            menuItem.AttachObserver(new ReportClickedDelegate(this.reportClicked));
            m_MenuItems.Add(menuItem);
        }

        private void reportClicked(string i_buttonID)
        {
            Console.WriteLine("button {0} is clicked :(", i_buttonID);
        }
        private int countCaptials()
        {
            int result = 0;

            return result;
        }

        private void showVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }

        private void showTime()
        {
            /// show current time
        }
        private void showdate()
        {
            /// show current date
        }
    }
}
