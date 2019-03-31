using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A19_Ex01.Delegates
{
    public delegate void DoActionHandler();

    public class ActionItem : LogOutItem
    {
        public event DoActionHandler DoAction;

        public ActionItem(string i_ItemName)
            : base(i_ItemName)
        {
        }

        public void RunAction()
        {
            if (DoAction != null)
            {
                DoAction.Invoke();

            }
            
        }
    }
}
