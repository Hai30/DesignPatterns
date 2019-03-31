using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP19_Ex01.Logic
{
	public class ListsUserInfo
	{
		public List<object> m_PostList = new List<object>();
		public List<object> m_AlbumList = new List<object>();
		public List<object> m_FriendsList = new List<object>();
		public List<object> m_CheckinList = new List<object>();

		public ListsUserInfo(User i_LoggedInUser)
		{
			insertUserInfoToList(i_LoggedInUser);
		}
		private void insertUserInfoToList(User i_LoggedInUser)
		{
			if (i_LoggedInUser.Posts.Count != 0)
			{
				foreach (Post post in i_LoggedInUser.Posts)
				{
					m_PostList.Add(post);
				}
			}
			if (i_LoggedInUser.Albums.Count != 0)
			{
				foreach (Album album in i_LoggedInUser.Albums)
				{
					m_AlbumList.Add(album);
				}
			}
			if (i_LoggedInUser.Friends.Count != 0)
			{
				foreach (User Friend in i_LoggedInUser.Friends)
				{
					m_FriendsList.Add(Friend);
				}
			}
			if (i_LoggedInUser.Checkins.Count != 0)
			{
				foreach (Checkin checkin in i_LoggedInUser.Checkins)
				{
					m_CheckinList.Add(checkin);
				}
			}
		}
		
	}

}
