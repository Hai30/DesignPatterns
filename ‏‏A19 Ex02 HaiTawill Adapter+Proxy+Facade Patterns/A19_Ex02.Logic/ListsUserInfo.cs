using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A19_Ex02.Logic
{
	public class ListsUserInfo : IUserInfo
	{
		private User m_LoggedInUser;

		public List<object> m_PostListR = new List<object>();
		public List<object> m_AlbumListR = new List<object>();
		public List<object> m_FriendsListR = new List<object>();
		public List<object> m_CheckinListR = new List<object>();
		public List<object> m_EventListR = new List<object>();

		public ListsUserInfo(User i_LoggedInUser)
		{
			m_LoggedInUser = i_LoggedInUser;
		}

		public void insertUserInfoToLists()
		{
			if (m_LoggedInUser.Posts.Count != 0)
			{
				foreach (Post post in m_LoggedInUser.Posts)
				{
					m_PostListR.Add(post);
				}
			
			}
			if (m_LoggedInUser.Albums.Count != 0)
			{
				foreach (Album album in m_LoggedInUser.Albums)
				{
					m_AlbumListR.Add(album);
				}
			}
			if (m_LoggedInUser.Friends.Count != 0)
			{
				foreach (User Friend in m_LoggedInUser.Friends)
				{
					m_FriendsListR.Add(Friend);
				}
			}
			if (m_LoggedInUser.Checkins.Count != 0)
			{
				foreach (Checkin checkin in m_LoggedInUser.Checkins)
				{
					m_CheckinListR.Add(checkin);
				}
			}
		//	if (i_LoggedInUser.Events.Count != 0)
		//	{
		//		foreach (Event evant in i_LoggedInUser.Events)
		//		{
		//			m_EventList.Add(evant);
		//		}
		//	}
		}

		public List<string> getNameList(List<object> lst)
		{
			List<string> nameList = new List<string>();
			if (lst[0] is User)
			{
				foreach (User user in lst)
				{
					nameList.Add(user.Name);
				}
			}
			if (lst[0] is Album)
			{
				foreach (Album album in lst)
				{
					nameList.Add(album.Name);
				}
			}
			if (lst[0] is Checkin)
			{
				foreach (Checkin chekin in lst)
				{
					nameList.Add(chekin.Name);
				}
			}
			if (lst[0] is Post)
			{
				foreach (Post post in lst)
				{
					nameList.Add(post.Name);
				}
			}

			return nameList;
		}
		public List<int> getCommentAmountList(List<object> lst)
		{
			List<int> commentAmountList = new List<int>();
		
			if (lst[0] is Album)
			{
				foreach (Album album in lst)
				{
					commentAmountList.Add(album.Comments.Count);
				}
			}
			if (lst[0] is Checkin)
			{
				foreach (Checkin chekin in lst)
				{
					commentAmountList.Add(chekin.Comments.Count);
				}
			}
			if (lst[0] is Post)
			{
				foreach (Post post in lst)
				{
					commentAmountList.Add(post.Comments.Count);
				}
			}

			return commentAmountList;
		}
		public List<int> getPhotosAmountList(List<object> lst)
		{
			List<int> PhotosAmountList = new List<int>();

			if (lst[0] is Album)
			{
				foreach (Album album in lst)
				{
					PhotosAmountList.Add(album.Photos.Count);
				}
			}

			return PhotosAmountList;
		}


	}

}
