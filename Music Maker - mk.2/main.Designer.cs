namespace Music_Maker___mk._2
{
    partial class main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test",
            "Requester Test",
            "Video Id test"}, -1);
            this.groupBox_Users = new System.Windows.Forms.GroupBox();
            this.button_BanUser = new System.Windows.Forms.Button();
            this.button_Kick = new System.Windows.Forms.Button();
            this.groupBox_Queue = new System.Windows.Forms.GroupBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_BanSong = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Skip = new System.Windows.Forms.Button();
            this.resize = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Playing = new System.Windows.Forms.GroupBox();
            this.textBox_Playing = new System.Windows.Forms.TextBox();
            this.listView_Queue = new System.Windows.Forms.ListView();
            this.listView_Users = new System.Windows.Forms.ListView();
            this.column_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Requester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_VideoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Users.SuspendLayout();
            this.groupBox_Queue.SuspendLayout();
            this.groupBox_Playing.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Users
            // 
            this.groupBox_Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Users.Controls.Add(this.listView_Users);
            this.groupBox_Users.Controls.Add(this.button_BanUser);
            this.groupBox_Users.Controls.Add(this.button_Kick);
            this.groupBox_Users.Location = new System.Drawing.Point(12, 11);
            this.groupBox_Users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Users.Name = "groupBox_Users";
            this.groupBox_Users.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Users.Size = new System.Drawing.Size(211, 356);
            this.groupBox_Users.TabIndex = 0;
            this.groupBox_Users.TabStop = false;
            this.groupBox_Users.Text = "Users";
            // 
            // button_BanUser
            // 
            this.button_BanUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BanUser.Location = new System.Drawing.Point(108, 321);
            this.button_BanUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BanUser.Name = "button_BanUser";
            this.button_BanUser.Size = new System.Drawing.Size(97, 31);
            this.button_BanUser.TabIndex = 2;
            this.button_BanUser.Text = "Ban";
            this.button_BanUser.UseVisualStyleBackColor = true;
            this.button_BanUser.Click += new System.EventHandler(this.button_BanUser_Click);
            // 
            // button_Kick
            // 
            this.button_Kick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Kick.Location = new System.Drawing.Point(6, 321);
            this.button_Kick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Kick.Name = "button_Kick";
            this.button_Kick.Size = new System.Drawing.Size(96, 31);
            this.button_Kick.TabIndex = 2;
            this.button_Kick.Text = "Kick";
            this.button_Kick.UseVisualStyleBackColor = true;
            this.button_Kick.SizeChanged += new System.EventHandler(this.main_SizeChanged);
            this.button_Kick.Click += new System.EventHandler(this.button_Kick_Click);
            // 
            // groupBox_Queue
            // 
            this.groupBox_Queue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Queue.Controls.Add(this.listView_Queue);
            this.groupBox_Queue.Controls.Add(this.button_Info);
            this.groupBox_Queue.Controls.Add(this.button_Remove);
            this.groupBox_Queue.Controls.Add(this.button_BanSong);
            this.groupBox_Queue.Location = new System.Drawing.Point(228, 11);
            this.groupBox_Queue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Queue.Name = "groupBox_Queue";
            this.groupBox_Queue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Queue.Size = new System.Drawing.Size(553, 356);
            this.groupBox_Queue.TabIndex = 1;
            this.groupBox_Queue.TabStop = false;
            this.groupBox_Queue.Text = "Queue";
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(143, 321);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(131, 31);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            // 
            // button_BanSong
            // 
            this.button_BanSong.Location = new System.Drawing.Point(280, 321);
            this.button_BanSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BanSong.Name = "button_BanSong";
            this.button_BanSong.Size = new System.Drawing.Size(131, 31);
            this.button_BanSong.TabIndex = 5;
            this.button_BanSong.Text = "Ban";
            this.button_BanSong.UseVisualStyleBackColor = true;
            // 
            // button_Info
            // 
            this.button_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Info.Location = new System.Drawing.Point(5, 321);
            this.button_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(131, 31);
            this.button_Info.TabIndex = 6;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Skip
            // 
            this.button_Skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Skip.Location = new System.Drawing.Point(416, 20);
            this.button_Skip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Skip.Name = "button_Skip";
            this.button_Skip.Size = new System.Drawing.Size(131, 31);
            this.button_Skip.TabIndex = 3;
            this.button_Skip.Text = "Skip";
            this.button_Skip.UseVisualStyleBackColor = true;
            // 
            // resize
            // 
            this.resize.DoWork += new System.ComponentModel.DoWorkEventHandler(this.resize_DoWork);
            // 
            // groupBox_Playing
            // 
            this.groupBox_Playing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Playing.Controls.Add(this.textBox_Playing);
            this.groupBox_Playing.Controls.Add(this.button_Skip);
            this.groupBox_Playing.Location = new System.Drawing.Point(228, 372);
            this.groupBox_Playing.Name = "groupBox_Playing";
            this.groupBox_Playing.Size = new System.Drawing.Size(553, 56);
            this.groupBox_Playing.TabIndex = 4;
            this.groupBox_Playing.TabStop = false;
            this.groupBox_Playing.Text = "Currently Playing";
            // 
            // textBox_Playing
            // 
            this.textBox_Playing.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_Playing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_Playing.Location = new System.Drawing.Point(6, 20);
            this.textBox_Playing.Multiline = true;
            this.textBox_Playing.Name = "textBox_Playing";
            this.textBox_Playing.ReadOnly = true;
            this.textBox_Playing.Size = new System.Drawing.Size(406, 30);
            this.textBox_Playing.TabIndex = 4;
            this.textBox_Playing.Text = "NO SONG CURRENTLY PLAYING...";
            this.textBox_Playing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView_Queue
            // 
            this.listView_Queue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Queue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Title,
            this.column_Requester,
            this.column_VideoId});
            this.listView_Queue.FullRowSelect = true;
            this.listView_Queue.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.listView_Queue.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_Queue.Location = new System.Drawing.Point(6, 21);
            this.listView_Queue.MultiSelect = false;
            this.listView_Queue.Name = "listView_Queue";
            this.listView_Queue.Size = new System.Drawing.Size(541, 295);
            this.listView_Queue.TabIndex = 7;
            this.listView_Queue.UseCompatibleStateImageBehavior = false;
            this.listView_Queue.View = System.Windows.Forms.View.Details;
            // 
            // listView_Users
            // 
            this.listView_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Users.Location = new System.Drawing.Point(6, 21);
            this.listView_Users.Name = "listView_Users";
            this.listView_Users.Size = new System.Drawing.Size(199, 295);
            this.listView_Users.TabIndex = 3;
            this.listView_Users.UseCompatibleStateImageBehavior = false;
            // 
            // column_Title
            // 
            this.column_Title.Text = "Title:";
            this.column_Title.Width = 200;
            // 
            // column_Requester
            // 
            this.column_Requester.Text = "Requested By:";
            this.column_Requester.Width = 152;
            // 
            // column_VideoId
            // 
            this.column_VideoId.Text = "Video Id:";
            this.column_VideoId.Width = 181;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 523);
            this.Controls.Add(this.groupBox_Playing);
            this.Controls.Add(this.groupBox_Queue);
            this.Controls.Add(this.groupBox_Users);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(811, 570);
            this.Name = "main";
            this.Text = "Music Maker - mk.2";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_SizeChanged);
            this.groupBox_Users.ResumeLayout(false);
            this.groupBox_Queue.ResumeLayout(false);
            this.groupBox_Playing.ResumeLayout(false);
            this.groupBox_Playing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Users;
        private System.Windows.Forms.Button button_BanUser;
        private System.Windows.Forms.Button button_Kick;
        private System.Windows.Forms.GroupBox groupBox_Queue;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_BanSong;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Skip;
        private System.ComponentModel.BackgroundWorker resize;
        private System.Windows.Forms.GroupBox groupBox_Playing;
        private System.Windows.Forms.TextBox textBox_Playing;
        private System.Windows.Forms.ListView listView_Queue;
        private System.Windows.Forms.ListView listView_Users;
        private System.Windows.Forms.ColumnHeader column_Title;
        private System.Windows.Forms.ColumnHeader column_Requester;
        private System.Windows.Forms.ColumnHeader column_VideoId;
    }
}

