using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MenuItem : IExecute
    {
        private string m_ItemText;
        public event Action<MenuItem> Picked;

        public string ItemText
        {
            get { return m_ItemText; }
            set { m_ItemText = value; }
        }

        private void OnPicked()
        {
            if (Picked != null)
            {
                Picked.Invoke(this);
            }
        }

        public void Print()
        {
            Console.WriteLine(m_ItemText);
        }
    }
}
