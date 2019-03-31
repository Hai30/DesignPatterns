using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using A19_Ex02.Logic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02.UI
{
	public class Facade
	{
		private User m_LoggedInUser;
		private LoginResult m_LoginResult;
		private AppSettings m_AppSetting;
		private etypeButtonState m_listBoxChoosedButton;
		private UserInfoProxy m_myLists;
		private DisplayLogic m_DisplayLogic;
		public Facade()
		{
			loginAndInit();
			m_AppSetting = AppSettings.LoadFromFile();
			m_myLists = new UserInfoProxy(m_LoggedInUser);
			m_DisplayLogic = new DisplayLogic();
		}
		public User LoggedInUser
		{
			get { return m_LoginResult.LoggedInUser; }
		}
		public LoginResult LoginResult
		{
			get { return m_LoginResult; }
		}
		public AppSettings AppSetting
		{
			get { return m_AppSetting; }
		}
		public UserInfoProxy MyLists
		{
			get { return m_myLists; }
			set { m_myLists = value; }
		}
		public DisplayLogic DisplayLogic
		{
			get { return m_DisplayLogic; }
		}
		public etypeButtonState ListBoxChoosedButton
		{
			get { return m_listBoxChoosedButton; }
			set { m_listBoxChoosedButton = value; }
		}

		public LoginResult OnFormLoad()
		{
			if (m_AppSetting.RememberUser && string.IsNullOrEmpty(m_AppSetting.LastAccessToken))
			{
				m_LoginResult = FacebookService.Connect(m_AppSetting.LastAccessToken);
			}

			return m_LoginResult;
		}

		public void OnFormClosing(Point location, Size size, bool checkBoxRememberUser)
		{
			m_AppSetting.LastWindowLocation = location;
			m_AppSetting.LastWindowSize = size;
			m_AppSetting.RememberUser = checkBoxRememberUser;
			if (m_AppSetting.RememberUser)
			{
				m_AppSetting.LastAccessToken = m_LoginResult.AccessToken;
				m_AppSetting.SaveToFile();
			}
			else
			{
				m_AppSetting.LastAccessToken = null;

			}
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
				
			}
			else
			{
				MessageBox.Show(m_LoginResult.ErrorMessage);
			}

			this.m_LoggedInUser = m_LoggedInUser;
		}


	}
}
