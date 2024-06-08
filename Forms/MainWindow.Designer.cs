using System.Windows.Forms.VisualStyles;

namespace OOP_coursework
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("225");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1111",
            "12343544353",
            "12332432432"}, -1, System.Drawing.SystemColors.InactiveCaption, System.Drawing.SystemColors.HotTrack, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AddTrackButton = new System.Windows.Forms.Button();
            this.DeleteTrack = new System.Windows.Forms.Button();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupParam = new System.Windows.Forms.GroupBox();
            this.checkBox_disk = new System.Windows.Forms.RadioButton();
            this.checkBox_name = new System.Windows.Forms.RadioButton();
            this.checkBox_author = new System.Windows.Forms.RadioButton();
            this.advSearch_search = new System.Windows.Forms.Button();
            this.advSearch_textbox = new System.Windows.Forms.TextBox();
            this.advSearchLabel = new System.Windows.Forms.Label();
            this.chooseDisk = new System.Windows.Forms.Button();
            this.diskList = new System.Windows.Forms.ListView();
            this.DisksGroup = new System.Windows.Forms.GroupBox();
            this.deleteDisk = new System.Windows.Forms.Button();
            this.diskNameAdd = new System.Windows.Forms.TextBox();
            this.diskCreate = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackList = new System.Windows.Forms.Label();
            this.checkbox_Disk_help = new System.Windows.Forms.ToolTip(this.components);
            this.refreshWindow = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupParam.SuspendLayout();
            this.DisksGroup.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTrackButton
            // 
            this.AddTrackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTrackButton.Location = new System.Drawing.Point(290, 439);
            this.AddTrackButton.Name = "AddTrackButton";
            this.AddTrackButton.Size = new System.Drawing.Size(106, 23);
            this.AddTrackButton.TabIndex = 4;
            this.AddTrackButton.Text = "Додати трек";
            this.AddTrackButton.UseVisualStyleBackColor = true;
            this.AddTrackButton.Click += new System.EventHandler(this.AddTrackButton_Click);
            // 
            // DeleteTrack
            // 
            this.DeleteTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTrack.Location = new System.Drawing.Point(177, 439);
            this.DeleteTrack.Name = "DeleteTrack";
            this.DeleteTrack.Size = new System.Drawing.Size(107, 23);
            this.DeleteTrack.TabIndex = 5;
            this.DeleteTrack.Text = "Видалити трек";
            this.DeleteTrack.UseVisualStyleBackColor = true;
            this.DeleteTrack.Click += new System.EventHandler(this.DeleteTrack_Click);
            // 
            // listViewSongs
            // 
            this.listViewSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSongs.HideSelection = false;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            listViewItem3.ToolTipText = "1111111111";
            this.listViewSongs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewSongs.Location = new System.Drawing.Point(16, 51);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(380, 382);
            this.listViewSongs.TabIndex = 6;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleName = "Файл";
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // groupParam
            // 
            this.groupParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupParam.Controls.Add(this.checkBox_disk);
            this.groupParam.Controls.Add(this.checkBox_name);
            this.groupParam.Controls.Add(this.checkBox_author);
            this.groupParam.Location = new System.Drawing.Point(402, 61);
            this.groupParam.Name = "groupParam";
            this.groupParam.Size = new System.Drawing.Size(392, 133);
            this.groupParam.TabIndex = 15;
            this.groupParam.TabStop = false;
            this.groupParam.Text = "Параметри пошуку";
            // 
            // checkBox_disk
            // 
            this.checkBox_disk.AutoSize = true;
            this.checkBox_disk.Location = new System.Drawing.Point(6, 64);
            this.checkBox_disk.Name = "checkBox_disk";
            this.checkBox_disk.Size = new System.Drawing.Size(114, 17);
            this.checkBox_disk.TabIndex = 8;
            this.checkBox_disk.TabStop = true;
            this.checkBox_disk.Text = "Пошук по дискам";
            this.checkBox_disk.UseVisualStyleBackColor = true;
            // 
            // checkBox_name
            // 
            this.checkBox_name.AutoSize = true;
            this.checkBox_name.Location = new System.Drawing.Point(6, 41);
            this.checkBox_name.Name = "checkBox_name";
            this.checkBox_name.Size = new System.Drawing.Size(114, 17);
            this.checkBox_name.TabIndex = 7;
            this.checkBox_name.TabStop = true;
            this.checkBox_name.Text = "Пошук за назвою";
            this.checkBox_name.UseVisualStyleBackColor = true;
            // 
            // checkBox_author
            // 
            this.checkBox_author.AutoSize = true;
            this.checkBox_author.Location = new System.Drawing.Point(6, 18);
            this.checkBox_author.Name = "checkBox_author";
            this.checkBox_author.Size = new System.Drawing.Size(119, 17);
            this.checkBox_author.TabIndex = 6;
            this.checkBox_author.TabStop = true;
            this.checkBox_author.Text = "Пошук за автором";
            this.checkBox_author.UseVisualStyleBackColor = true;
            // 
            // advSearch_search
            // 
            this.advSearch_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advSearch_search.Location = new System.Drawing.Point(735, 200);
            this.advSearch_search.Name = "advSearch_search";
            this.advSearch_search.Size = new System.Drawing.Size(59, 23);
            this.advSearch_search.TabIndex = 14;
            this.advSearch_search.Text = "Пошук";
            this.advSearch_search.UseVisualStyleBackColor = true;
            this.advSearch_search.Click += new System.EventHandler(this.AdvSearch_search_Click);
            // 
            // advSearch_textbox
            // 
            this.advSearch_textbox.AcceptsReturn = true;
            this.advSearch_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advSearch_textbox.Location = new System.Drawing.Point(509, 32);
            this.advSearch_textbox.Name = "advSearch_textbox";
            this.advSearch_textbox.Size = new System.Drawing.Size(285, 20);
            this.advSearch_textbox.TabIndex = 13;
            this.advSearch_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdvSearch_textbox_KeyDown);
            // 
            // advSearchLabel
            // 
            this.advSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advSearchLabel.AutoSize = true;
            this.advSearchLabel.Location = new System.Drawing.Point(399, 35);
            this.advSearchLabel.Name = "advSearchLabel";
            this.advSearchLabel.Size = new System.Drawing.Size(104, 13);
            this.advSearchLabel.TabIndex = 12;
            this.advSearchLabel.Text = "Розширений пошук";
            // 
            // chooseDisk
            // 
            this.chooseDisk.Location = new System.Drawing.Point(270, 204);
            this.chooseDisk.Name = "chooseDisk";
            this.chooseDisk.Size = new System.Drawing.Size(114, 23);
            this.chooseDisk.TabIndex = 18;
            this.chooseDisk.Text = "Відкрити диск";
            this.chooseDisk.UseVisualStyleBackColor = true;
            this.chooseDisk.Click += new System.EventHandler(this.ChooseDisk_Click);
            // 
            // diskList
            // 
            this.diskList.HideSelection = false;
            this.diskList.Location = new System.Drawing.Point(6, 52);
            this.diskList.Name = "diskList";
            this.diskList.Size = new System.Drawing.Size(384, 146);
            this.diskList.TabIndex = 17;
            this.diskList.UseCompatibleStateImageBehavior = false;
            this.diskList.UseWaitCursor = true;
            this.diskList.View = System.Windows.Forms.View.Details;
            this.diskList.ItemActivate += new System.EventHandler(this.DiskList_ItemActivate_1);
            // 
            // DisksGroup
            // 
            this.DisksGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisksGroup.Controls.Add(this.deleteDisk);
            this.DisksGroup.Controls.Add(this.diskNameAdd);
            this.DisksGroup.Controls.Add(this.diskCreate);
            this.DisksGroup.Controls.Add(this.diskList);
            this.DisksGroup.Controls.Add(this.chooseDisk);
            this.DisksGroup.Location = new System.Drawing.Point(402, 229);
            this.DisksGroup.Name = "DisksGroup";
            this.DisksGroup.Size = new System.Drawing.Size(396, 233);
            this.DisksGroup.TabIndex = 19;
            this.DisksGroup.TabStop = false;
            this.DisksGroup.Text = "Диски";
            // 
            // deleteDisk
            // 
            this.deleteDisk.Location = new System.Drawing.Point(157, 204);
            this.deleteDisk.Name = "deleteDisk";
            this.deleteDisk.Size = new System.Drawing.Size(107, 23);
            this.deleteDisk.TabIndex = 21;
            this.deleteDisk.Text = "Видалити диск";
            this.deleteDisk.UseVisualStyleBackColor = true;
            this.deleteDisk.Click += new System.EventHandler(this.DeleteDisk_Click);
            // 
            // diskNameAdd
            // 
            this.diskNameAdd.Location = new System.Drawing.Point(6, 19);
            this.diskNameAdd.Name = "diskNameAdd";
            this.diskNameAdd.Size = new System.Drawing.Size(281, 20);
            this.diskNameAdd.TabIndex = 20;
            this.diskNameAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiskNameAdd_KeyDown);
            // 
            // diskCreate
            // 
            this.diskCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.diskCreate.Location = new System.Drawing.Point(293, 18);
            this.diskCreate.Name = "diskCreate";
            this.diskCreate.Size = new System.Drawing.Size(97, 21);
            this.diskCreate.TabIndex = 19;
            this.diskCreate.Text = "Створити диск";
            this.diskCreate.UseVisualStyleBackColor = true;
            this.diskCreate.Click += new System.EventHandler(this.DiskCreate_Click_1);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu,
            this.toolAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(806, 24);
            this.menuStrip.TabIndex = 20;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolMenu
            // 
            this.toolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu_Save,
            this.toolMenu_exit});
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(48, 20);
            this.toolMenu.Text = "Файл";
            // 
            // toolMenu_Save
            // 
            this.toolMenu_Save.Name = "toolMenu_Save";
            this.toolMenu_Save.Size = new System.Drawing.Size(180, 22);
            this.toolMenu_Save.Text = "Зберегти";
            this.toolMenu_Save.Click += new System.EventHandler(this.ToolMenu_Save_Click);
            // 
            // toolMenu_exit
            // 
            this.toolMenu_exit.Name = "toolMenu_exit";
            this.toolMenu_exit.Size = new System.Drawing.Size(180, 22);
            this.toolMenu_exit.Text = "Вихід";
            this.toolMenu_exit.Click += new System.EventHandler(this.ToolMenu_exit_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(99, 20);
            this.toolAbout.Text = "Про програму";
            this.toolAbout.Click += new System.EventHandler(this.ToolAbout_Click);
            // 
            // TrackList
            // 
            this.TrackList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackList.AutoSize = true;
            this.TrackList.Location = new System.Drawing.Point(17, 35);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(113, 13);
            this.TrackList.TabIndex = 21;
            this.TrackList.Text = "Перелік треків в базі";
            // 
            // refreshWindow
            // 
            this.refreshWindow.Location = new System.Drawing.Point(16, 468);
            this.refreshWindow.Name = "refreshWindow";
            this.refreshWindow.Size = new System.Drawing.Size(107, 23);
            this.refreshWindow.TabIndex = 22;
            this.refreshWindow.Text = "Оновити вікно";
            this.refreshWindow.UseVisualStyleBackColor = true;
            this.refreshWindow.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.ClientSize = new System.Drawing.Size(806, 501);
            this.Controls.Add(this.refreshWindow);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.DisksGroup);
            this.Controls.Add(this.groupParam);
            this.Controls.Add(this.advSearch_search);
            this.Controls.Add(this.advSearch_textbox);
            this.Controls.Add(this.advSearchLabel);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.DeleteTrack);
            this.Controls.Add(this.AddTrackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainWindow";
            this.Text = "Довідник меломана";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupParam.ResumeLayout(false);
            this.groupParam.PerformLayout();
            this.DisksGroup.ResumeLayout(false);
            this.DisksGroup.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddTrackButton;
        private System.Windows.Forms.Button DeleteTrack;
        private System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.GroupBox groupParam;
        private System.Windows.Forms.Button advSearch_search;
        private System.Windows.Forms.TextBox advSearch_textbox;
        private System.Windows.Forms.Label advSearchLabel;
        private System.Windows.Forms.Button chooseDisk;
        private System.Windows.Forms.ListView diskList;
        private System.Windows.Forms.GroupBox DisksGroup;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolMenu;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_Save;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_exit;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
        private System.Windows.Forms.TextBox diskNameAdd;
        private System.Windows.Forms.Button diskCreate;
        private System.Windows.Forms.Label TrackList;
        private System.Windows.Forms.RadioButton checkBox_author;
        private System.Windows.Forms.RadioButton checkBox_name;
        private System.Windows.Forms.RadioButton checkBox_disk;
        private System.Windows.Forms.ToolTip checkbox_Disk_help;
        private System.Windows.Forms.Button refreshWindow;
        private System.Windows.Forms.Button deleteDisk;
    }
}

