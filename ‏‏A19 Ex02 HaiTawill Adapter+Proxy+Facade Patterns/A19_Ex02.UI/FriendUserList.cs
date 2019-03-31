using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A19_Ex02.Logic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02.UI
{
	public partial class FriendUserList : Form
	{
		private UserInfoProxy m_myLists;
		private User m_LoginUser;
		public FriendUserList(IUserInfo i_myLists, User i_LoginUser)
		{
			m_myLists = i_myLists as UserInfoProxy;
			m_LoginUser = i_LoginUser;
			InitializeComponent();
		}

		private void friendUserList_Load(object sender, EventArgs e)
		{

			userBindingSource.DataSource = m_LoginUser.Friends;

		}

        private void listBoxdatasource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
