using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using A19_Ex01.Delegates;
using DP19_Ex01.Logic;



namespace A19_Ex01_Hen_201322252_Hai_301487138
{
	public partial class FaceNewsForm : Form
	{
		public FaceNewsForm()
		{
			InitializeComponent();
			FacebookWrapper.FacebookService.s_CollectionLimit = 200;
			FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
			loginAndInit();

			this.StartPosition = FormStartPosition.Manual;

			m_AppSetting = AppSettings.LoadFromFile();

			m_myLists = new ListsUserInfo(m_LoggedInUser);
			this.Size = m_AppSetting.LastWindowSize;
			this.Location = m_AppSetting.LastWindowLocation;
			this.checkBoxRememberUser.Checked = m_AppSetting.RememberUser;
		}		
		LoginResult m_LoginResult;
		User m_LoggedInUser;
		AppSettings m_AppSetting;
		ListsUserInfo m_myLists;
		private string m_listBoxChoosedButton;
		
		
	
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			if (m_AppSetting.RememberUser && string.IsNullOrEmpty(m_AppSetting.LastAccessToken))
			{
				m_LoginResult = FacebookService.Connect(m_AppSetting.LastAccessToken);
				fetchUserInfo();

			}
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			m_AppSetting.LastWindowLocation = this.Location;
			m_AppSetting.LastWindowSize = this.Size;
			m_AppSetting.RememberUser = this.checkBoxRememberUser.Checked;
			if (m_AppSetting.RememberUser)
			{
				m_AppSetting.LastAccessToken = m_LoginResult.AccessToken;
				m_AppSetting.SaveToFile();
			}
			else
			{
				m_AppSetting.LastAccessToken = null;

			}
            System.Environment.Exit(1);
               
		}

      
     
		private void loginAndInit()
		{
			/// Owner: design.patterns

			/// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
			/// You can then save the result.AccessToken for future auto-connect to this user:
			m_LoginResult = FacebookService.Login("574802032979677", /// (desig patter's "Design Patterns Course App 2.4" app)
				"public_profile",
				//"user_education_history",
				"user_birthday",
			//	"user_actions.video",
			//	"user_actions.news",
			//	"user_actions.music",
			//	"user_actions.fitness",
			//	"user_actions.books",
			//	"user_about_me",
				"user_friends",
			//	"publish_actions",
				"user_events",
			//	"user_games_activity,"
		//		//"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
			//	"user_hometown",
			//	"user_likes",
			///	"user_location",
			//	"user_managed_groups",
				"user_photos",
				"user_posts"
			//	"user_relationships",
			//	"user_relationship_details",
			//	"user_religion_politics",

				//"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
			//	"user_tagged_places",
			//	"user_videos",
			//	"user_website",
			//	"user_work_history",
			//	"read_custom_friendlists",

				// "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
			//	"read_page_mailboxes",
				// "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
				// "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
			//	"manage_pages",
			//	"publish_pages",
			//	"publish_actions",

			//	"rsvp_event"
			);

			// These are NOT the complete list of permissions. Other permissions for example:
			// "user_birthday", "user_education_history", "user_hometown", "user_likes", "user_location", "user_relationships", "user_relationship_details",/// "user_religion_politics", "user_videos", "user_website", "user_work_history", "email", "read_insights", "rsvp_event", "manage_pages"
				
			
			//The documentation regarding facebook login and permissions can be found here: 
			//https://developers.facebook.com/docs/facebook-login/permissions#reference


			if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
			{
				m_LoggedInUser = m_LoginResult.LoggedInUser;
				fetchUserInfo();
			}
			else
			{
				MessageBox.Show(m_LoginResult.ErrorMessage);
			}
		}

		private void fetchUserInfo()
		{	
			m_LoggedInUser = m_LoginResult.LoggedInUser;
			this.textBoxStatus.Text = string.Empty;
			this.Text = "Logged in as " + m_LoggedInUser.FirstName+ " " + m_LoggedInUser.LastName;
			this.loginNameLabel.Text = m_LoggedInUser.FirstName + " " + m_LoggedInUser.LastName;
			picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
			if (m_LoggedInUser.Posts.Count > 0)
			{
				textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
			}	
		}
		private void fetchPosts()
		{
			foreach (Post post in m_myLists.m_PostList)
			{
				if (post.Message != null)
				{
					listBox.Items.Add(post.Message);
				}
				else if (post.Caption != null)
				{
					listBox.Items.Add(post.Caption);
				}
				else
				{
					listBox.Items.Add(string.Format("[{0}]", post.Type));
				}
			}

			if (m_LoggedInUser.Posts.Count == 0)
			{
				MessageBox.Show("No Posts to retrieve :(");
			}
		}
        public void displayMembers(List<object> list)
         {
			listBox.Items.Clear();
			listBox.DisplayMember = "Name";
			if (list.Count != 0)
			{
			foreach (object obj in list)
			{
				listBox.Items.Add(obj);
			}
			}
			else
			{
				MessageBox.Show("No data to retrieve :(");
			}
		 }
		private void displayMembersCounts(List<object> list)
		{

			stringCountListBox.Items.Clear();
			stringCountListBox.DisplayMember = "Name";
			
			
			if (m_listBoxChoosedButton == "Friend")
			{
				foreach (User obj in list)
				{
					stringCountListBox.Items.Add("Birthday : " + obj.Birthday);
				}
				
			}
			if (m_listBoxChoosedButton == "Album")
			{
				foreach (Album obj in list)
				{
					stringCountListBox.Items.Add("Photos : " + obj.Photos.Count);
				}
			
			}
			if (m_listBoxChoosedButton == "Post")
			{
				foreach (Post obj in list)
				{
					stringCountListBox.Items.Add("Comments : " + obj.Comments.Count);
				}
			}
			if (m_listBoxChoosedButton == "Checkin")
			{
				foreach (Checkin obj in list)
				{
					stringCountListBox.Items.Add("Comments : " + obj.Comments.Count + " , Place : " + obj.Place);
				}
			}
		}
	


		private void postStatuseButton_Click(object sender, EventArgs e)
		{
			Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
			MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
		}
		private void lastPostButton_Click(object sender, EventArgs e)
		{
			m_listBoxChoosedButton ="Post";
			fetchPosts();
			displayMembersCounts(m_myLists.m_PostList);
		}
		private void fetchFriendsbutton_Click(object sender, EventArgs e)
		{
			m_listBoxChoosedButton = "Friend";
			displayMembers(m_myLists.m_FriendsList);
			displayMembersCounts(m_myLists.m_FriendsList);
		}
		private void logoutButton_Click(object sender, EventArgs e)
		{
            A19_Ex01.Delegates.ActionItem delegateLogOut = new ActionItem(m_LoginResult.AccessToken);

            FacebookService.Logout(delegateLogOut.RunAction);
            System.Environment.Exit(1);
            
        }
		private void albumButton_Click(object sender, EventArgs e)
		{
			m_listBoxChoosedButton = "Album";
			displayMembers(m_myLists.m_AlbumList);
			displayMembersCounts(m_myLists.m_AlbumList);
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox.SelectedItems.Count == 1)
			{
				User selectedFriend = new User();
				Album selectedAlbum = new Album();
				if (m_listBoxChoosedButton == "Friend")
				{
					selectedFriend = listBox.SelectedItem as User;
					getSmallPicFromList(selectedFriend.PictureNormalURL);
				}
				if (m_listBoxChoosedButton == "Album")
				{
					selectedAlbum = listBox.SelectedItem as Album;
					getSmallPicFromList(selectedAlbum.CoverPhoto.PictureAlbumURL);
				}
			}
		}
		private void getSmallPicFromList(string i_urlSmallPic)
		{
			if (i_urlSmallPic != null)
			{
				selectedLinePictureBox.LoadAsync(i_urlSmallPic);
			}
			else
			{
				selectedLinePictureBox.Image = picture_smallPictureBox.ErrorImage;
			}
		}
		private void showEventsButton_Click(object sender, EventArgs e) //No permission Fro FaceBook Api To Events
        {
			//DateTime myEventDateTime = new DateTime(2018, 11, 24);
			//monthCalendar1.AddBoldedDate(myEventDateTime.Date);
			//monthCalendar1.UpdateBoldedDates();
			if (m_LoggedInUser.Events.Count != 0)
			{
				foreach (Event eventt in m_LoggedInUser.Events)
				{

					string eventTim = eventt.TimeString;

					DateTime myEventDateTime = DateTime.Parse(eventTim);      //No permission Fro FaceBook Api To Events
                    monthCalendar1.AddBoldedDate(myEventDateTime.Date);
				}
				monthCalendar1.UpdateBoldedDates();
			}
			else
			{
				MessageBox.Show("No events to retrieve :(");
			}
			
		}
		private void listBox_DoubleClick(object sender, EventArgs e)
		{
			Album selectedAlbum = listBox.SelectedItem as Album;

			listView1.Items.Clear();
			if (selectedAlbum.Photos.Count != 0)
			{
				for (int i = 0; i < selectedAlbum.Photos.Count; i++)
				{
					listView1.Items.Add(selectedAlbum.Photos[i].Id);
				}
			}
			else
			{
				MessageBox.Show("No photos to retrieve in Album :(");
			}

		

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			List<object> sortedList = new List<object>();
			List<object> List = new List<object>();
			if (m_listBoxChoosedButton == "Album")
			{
				List = m_myLists.m_AlbumList;
				sortedList = IDoSort.SortAlbums(List, m_listBoxChoosedButton);
			}
			if (m_listBoxChoosedButton == "Post")
			{
				List = m_myLists.m_PostList;
				sortedList = IDoSort.SortAlbums(List, m_listBoxChoosedButton);
			}
            if (m_listBoxChoosedButton == "Checkin")
            {
                List = m_myLists.m_CheckinList;
                sortedList = IDoSort.SortAlbums(List, m_listBoxChoosedButton);
            }

            displayMembers(sortedList);
			displayMembersCounts(sortedList);
		}

        private void button2_Click(object sender, EventArgs e)
        {
            m_listBoxChoosedButton = "Checkin";
            displayMembers(m_myLists.m_CheckinList);
            displayMembersCounts(m_myLists.m_CheckinList);
        }
    }
}
