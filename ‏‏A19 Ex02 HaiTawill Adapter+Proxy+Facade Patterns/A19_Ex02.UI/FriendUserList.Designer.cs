namespace A19_Ex02.UI
{
	partial class FriendUserList
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label imageSmallLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendUserList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxdatasource = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            imageSmallLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(30, 391);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(128, 32);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(30, 327);
            emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(95, 32);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(26, 211);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(160, 32);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // imageSmallLabel
            // 
            imageSmallLabel.AutoSize = true;
            imageSmallLabel.Location = new System.Drawing.Point(22, 23);
            imageSmallLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            imageSmallLabel.Name = "imageSmallLabel";
            imageSmallLabel.Size = new System.Drawing.Size(180, 32);
            imageSmallLabel.TabIndex = 6;
            imageSmallLabel.Text = "Image Small:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(30, 260);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(159, 32);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxdatasource);
            this.panel1.Controls.Add(this.panelUserDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 642);
            this.panel1.TabIndex = 0;
            // 
            // listBoxdatasource
            // 
            this.listBoxdatasource.DataSource = this.userBindingSource;
            this.listBoxdatasource.DisplayMember = "Name";
            this.listBoxdatasource.FormattingEnabled = true;
            this.listBoxdatasource.ItemHeight = 31;
            this.listBoxdatasource.Location = new System.Drawing.Point(24, 95);
            this.listBoxdatasource.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxdatasource.Name = "listBoxdatasource";
            this.listBoxdatasource.Size = new System.Drawing.Size(362, 469);
            this.listBoxdatasource.TabIndex = 2;
            this.listBoxdatasource.SelectedIndexChanged += new System.EventHandler(this.listBoxdatasource_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelUserDetails.Controls.Add(birthdayLabel);
            this.panelUserDetails.Controls.Add(this.birthdayTextBox);
            this.panelUserDetails.Controls.Add(emailLabel);
            this.panelUserDetails.Controls.Add(this.emailTextBox);
            this.panelUserDetails.Controls.Add(firstNameLabel);
            this.panelUserDetails.Controls.Add(this.firstNameTextBox);
            this.panelUserDetails.Controls.Add(imageSmallLabel);
            this.panelUserDetails.Controls.Add(this.imageSmallPictureBox);
            this.panelUserDetails.Controls.Add(lastNameLabel);
            this.panelUserDetails.Controls.Add(this.lastNameTextBox);
            this.panelUserDetails.Location = new System.Drawing.Point(412, 95);
            this.panelUserDetails.Margin = new System.Windows.Forms.Padding(6);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(516, 484);
            this.panelUserDetails.TabIndex = 1;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(248, 391);
            this.birthdayTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(196, 38);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(248, 322);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(196, 38);
            this.emailTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(248, 202);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(196, 38);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(28, 62);
            this.imageSmallPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(158, 143);
            this.imageSmallPictureBox.TabIndex = 7;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(248, 256);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(196, 38);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(1038, 47);
            this.userBindingNavigator.TabIndex = 1;
            this.userBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Enabled = false;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 44);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // FriendUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 642);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FriendUserList";
            this.Text = "FriendUserList";
            this.Load += new System.EventHandler(this.friendUserList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelUserDetails;
		private System.Windows.Forms.ListBox listBoxdatasource;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.BindingNavigator userBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox birthdayTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.PictureBox imageSmallPictureBox;
		private System.Windows.Forms.TextBox lastNameTextBox;

	}
}