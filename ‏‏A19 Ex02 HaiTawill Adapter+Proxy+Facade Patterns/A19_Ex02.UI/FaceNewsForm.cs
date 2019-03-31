using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using A19_Ex02.Logic;
using A19_Ex02.Delegates;


namespace A19_Ex02.UI
{
	public partial class FaceNewsForm : Form
	{
		private Facade m_Facade = new Facade();
		private Form m_mainForm;
		public FaceNewsForm(Form mainForm)
		{
			m_mainForm = mainForm;
			InitializeComponent();
			FacebookWrapper.FacebookService.s_CollectionLimit = 200;
			FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
			fetchUserInfo();
			this.StartPosition = FormStartPosition.Manual;

			this.Size = m_Facade.AppSetting.LastWindowSize;
			this.Location = m_Facade.AppSetting.LastWindowLocation;
			this.checkBoxRememberUser.Checked = m_Facade.AppSetting.RememberUser;
		}		
	
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			m_Facade.OnFormLoad();
			fetchUserInfo();
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			m_Facade.OnFormClosing(this.Location, this.Size, this.checkBoxRememberUser.Checked);

			m_mainForm.Close();
			System.Environment.Exit(1);

		}
		private void fetchUserInfo()
		{

			this.Text = "Logged in as " + m_Facade.LoggedInUser.FirstName + " " + m_Facade.LoggedInUser.LastName;
			this.loginNameLabel.Text = m_Facade.LoggedInUser.FirstName + " " + m_Facade.LoggedInUser.LastName;
			picture_smallPictureBox.LoadAsync(m_Facade.LoggedInUser.PictureNormalURL);
			new Thread(GetPosts).Start();

		}
		private void GetPosts()
		{
			if (listBox.Items.Count!=0)
			{
				listBox.Invoke(new Action(() => listBox.Items.Clear()));
				listBox.Invoke(new Action(() => listBox.DisplayMember = "Name"));
			}
			foreach (Post post in m_Facade.LoggedInUser.Posts)
			{
				if (post.Message != null)
				{
					listBox.Invoke(new Action(()=>listBox.Items.Add(post.Message)));
				}
				else if (post.Caption != null)
				{
					listBox.Invoke(new Action(()=>listBox.Items.Add(post.Caption)));
				}
				else
				{
					listBox.Invoke(new Action(()=>listBox.Items.Add(string.Format("[{0}]", post.Type))));
				}
			}

			if (m_Facade.LoggedInUser.Posts.Count == 0)
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
		private void displayMembersValues(List<object> list)
		{
			
			stringCountListBox.Items.Clear();
            m_Facade.MyLists.DisplayValueString(m_Facade.ListBoxChoosedButton);
            stringCountListBox.DisplayMember = m_Facade.MyLists.ToString();
			foreach (object obj in list)
			{
				stringCountListBox.Items.Add(obj);
			}
		
		}
		private void postStatusButton_Click(object sender, EventArgs e)
		{
			Status postedStatus = m_Facade.LoggedInUser.PostStatus(textBoxStatus.Text);
			MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
		}
		private void lastPostButton_Click(object sender, EventArgs e)
		{
			m_Facade.ListBoxChoosedButton = etypeButtonState.Post;
			new Thread(GetPosts).Start();
			displayMembersValues(m_Facade.MyLists.m_PostList);
		}
		private void fetchFriendsButton_Click(object sender, EventArgs e)
		{
			m_Facade.ListBoxChoosedButton = etypeButtonState.Friend;
			displayMembers(m_Facade.MyLists.m_FriendsList);
			displayMembersValues(m_Facade.MyLists.m_FriendsList);
		}
		private void logoutButton_Click(object sender, EventArgs e)
		{
			m_mainForm.Close();
			A19_Ex02.Delegates.ActionItem delegateLogOut = new ActionItem(m_Facade.LoginResult.AccessToken);
			FacebookService.Logout(delegateLogOut.RunAction);
			System.Environment.Exit(1);
			
		
		}
		private void albumButton_Click(object sender, EventArgs e)
		{
			m_Facade.ListBoxChoosedButton = etypeButtonState.Album;
			displayMembers(m_Facade.MyLists.m_AlbumList);
			displayMembersValues(m_Facade.MyLists.m_AlbumList);
		}
		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox.SelectedItems.Count == 1)
			{
				string picture = m_Facade.DisplayLogic.DisplaySelectedIndexChangedLogic(m_Facade.ListBoxChoosedButton, listBox.SelectedItem);
				getSmallPicFromList(picture);
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
		private void showEventsButton_Click(object sender, EventArgs e)
		{
			if (m_Facade.LoggedInUser.Events.Count != 0)
			{
				foreach (Event eventt in m_Facade.LoggedInUser.Events)
				{

					string eventTim = eventt.TimeString;

					DateTime myEventDateTime = DateTime.Parse(eventTim);
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
			if (selectedAlbum.Photos.Count != 0 )
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

		//sort button
		private void sortButton_Click(object sender, EventArgs e)
		{
			List<object> sortedList = new List<object>();
			sortedList = m_Facade.DisplayLogic.DisplaySortLogic(m_Facade.MyLists, m_Facade.ListBoxChoosedButton);
			displayMembers(sortedList);
			displayMembersValues(sortedList);
		}
		private void DataBindingFriendsListButton_Click(object sender, EventArgs e)
		{
			FriendUserList form = new FriendUserList(m_Facade.MyLists, m_Facade.LoggedInUser);
			form.ShowDialog();
		
		}

		private void Checkinbutton_Click(object sender, EventArgs e)
		{
			m_Facade.ListBoxChoosedButton = etypeButtonState.Checking;
			displayMembers(m_Facade.MyLists.m_CheckinList);
			displayMembersValues(m_Facade.MyLists.m_CheckinList);
		}

		

	

		
	}
}
