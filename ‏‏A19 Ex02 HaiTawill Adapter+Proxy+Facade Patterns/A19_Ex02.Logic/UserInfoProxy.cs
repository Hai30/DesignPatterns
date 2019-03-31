using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02.Logic
{
	public class UserInfoProxy : IUserInfo
	{
		private ListsUserInfo m_UserInfoLists = null;
		private User m_LoginUser;

		public List<object> m_PostList;
		public List<object> m_AlbumList;
		public List<object> m_FriendsList;
		public List<object> m_CheckinList;
		public List<object> m_EventList;
        private string m_displayString = null;
		public UserInfoProxy(User i_LoginUser)
		{
			this.m_LoginUser = i_LoginUser;
			insertUserInfoToLists();
                                                 
			m_AlbumList = m_UserInfoLists.m_AlbumListR;
			m_CheckinList = m_UserInfoLists.m_CheckinListR;
			m_EventList = m_UserInfoLists.m_EventListR;
			m_FriendsList = m_UserInfoLists.m_FriendsListR;
			m_PostList = m_UserInfoLists.m_PostListR;
		}
        public string DisplayValueString(etypeButtonState i_Type) 
            {
            if (i_Type.ToString() == "Friend")
            {

                m_displayString = "Birthday";
            }

            if (i_Type.ToString() == "Album")
            {
                m_displayString = "Photos.Count" ;
            }

            if (i_Type.ToString() == "Post")
            {
                m_displayString =  "Comments[0]";
            }

            if (i_Type.ToString() == "Checkin")
            {
                m_displayString = "Place";
            }
            return m_displayString;
        }
        
		public void insertUserInfoToLists()
		{
			if (m_UserInfoLists == null)
			{
				m_UserInfoLists = new ListsUserInfo(m_LoginUser);
			}

			m_UserInfoLists.insertUserInfoToLists();

		}
		public List<string> getNameList(List<object> lst)
		{
			if (m_UserInfoLists == null)
			{
				m_UserInfoLists = new ListsUserInfo(m_LoginUser);
			}

			return m_UserInfoLists.getNameList(lst);

		}
		public List<int> getCommentAmountList(List<object> lst)
		{
			if (m_UserInfoLists == null)
			{
				m_UserInfoLists = new ListsUserInfo(m_LoginUser);
			}

			return  m_UserInfoLists.getCommentAmountList(lst);

		}
		public List<int> getPhotosAmountList(List<object> lst)
		{
			if (m_UserInfoLists == null)
			{
				m_UserInfoLists = new ListsUserInfo(m_LoginUser);
			}

			return  m_UserInfoLists.getPhotosAmountList(lst);

		}

        public override string ToString()
        {
            return m_displayString;

        }
    }
}
