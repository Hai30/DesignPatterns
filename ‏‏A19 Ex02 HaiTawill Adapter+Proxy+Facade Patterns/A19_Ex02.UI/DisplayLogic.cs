using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A19_Ex02.Logic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02.UI
{
public	class DisplayLogic
	{
		public string DisplaySelectedIndexChangedLogic(etypeButtonState m_listBoxChoosedButton,object SelectedItem )
		{
			User selectedFriend = new User();
			Album selectedAlbum = new Album();
			string picture = null;
			if (m_listBoxChoosedButton.ToString() == "Friend")
			{
				selectedFriend = SelectedItem as User;
				picture = selectedFriend.PictureNormalURL;
			}

			if (m_listBoxChoosedButton.ToString() == "Album")
			{
                
				selectedAlbum = SelectedItem as Album;
                if (selectedAlbum.Photos.Count != 0)
                {
                    picture = selectedAlbum.CoverPhoto.PictureAlbumURL;
                }
                else
                {
                    PictureBox P = new PictureBox();
                    picture = P.ErrorImage.ToString();
                }
            }

			return picture;
		}
		public  List<object> DisplaySortLogic(UserInfoProxy m_myLists, etypeButtonState m_listBoxChoosedButton)
		{
			
			ISort isort = new DoSortAdapter();
			List<object> List = new List<object>();
			List<object> sortedLilst =new List<object>();
			switch (m_listBoxChoosedButton)
			{
				case etypeButtonState.Album:
					List = m_myLists.m_AlbumList;
					sortedLilst = isort.sortObjectList(m_myLists.m_AlbumList, m_myLists.getPhotosAmountList(List));
					break;
				case etypeButtonState.Checking:
					List = m_myLists.m_CheckinList;
					sortedLilst = isort.sortObjectList(m_myLists.m_CheckinList, m_myLists.getCommentAmountList(List));
					break;
				case etypeButtonState.Event:
					List = m_myLists.m_EventList;
					sortedLilst = isort.sortObjectList(m_myLists.m_EventList, m_myLists.getNameList(List));
					break;
				case etypeButtonState.Friend:
					List = m_myLists.m_FriendsList;
					sortedLilst = isort.sortObjectList(m_myLists.m_FriendsList, m_myLists.getNameList(List));
					break;
				case etypeButtonState.Post:
					List = m_myLists.m_PostList;
					sortedLilst = isort.sortObjectList(m_myLists.m_PostList, m_myLists.getCommentAmountList(List));
					break;

					
			}
			return sortedLilst;
		}
	}
}
