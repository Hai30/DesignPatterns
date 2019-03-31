using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A19_Ex02.Delegates
{
    public class LogOutItem
    {
        private string m_ItemName = null;

        public string ItemName
        {
            set
            {
                m_ItemName = value;
            }
            get
            {
                return m_ItemName;
            }

        }

        public LogOutItem(string i_ItemName)
        {
            ItemName = i_ItemName;
        }
    }
}
