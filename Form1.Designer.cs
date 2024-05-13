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
            this.Search_box = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.AddTrackButton = new System.Windows.Forms.Button();
            this.DeleteTrack = new System.Windows.Forms.Button();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.Button();
            this.openDisks = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_box
            // 
            this.Search_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_box.Location = new System.Drawing.Point(12, 35);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(686, 20);
            this.Search_box.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(704, 34);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(68, 21);
            this.Search.TabIndex = 1;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Location = new System.Drawing.Point(656, 61);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(116, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Перезавантажити";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AddTrackButton
            // 
            this.AddTrackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTrackButton.Location = new System.Drawing.Point(666, 478);
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
            this.DeleteTrack.Location = new System.Drawing.Point(553, 478);
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
            this.listViewSongs.Location = new System.Drawing.Point(12, 90);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(760, 382);
            this.listViewSongs.TabIndex = 6;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пошук";
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
            // saveFile
            // 
            this.saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFile.Location = new System.Drawing.Point(576, 61);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 9;
            this.saveFile.Text = "Зберегти";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // openDisks
            // 
            this.openDisks.Location = new System.Drawing.Point(12, 478);
            this.openDisks.Name = "openDisks";
            this.openDisks.Size = new System.Drawing.Size(75, 23);
            this.openDisks.TabIndex = 10;
            this.openDisks.Text = "Диски";
            this.openDisks.UseVisualStyleBackColor = true;
            this.openDisks.Click += new System.EventHandler(this.openDisks_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.openDisks);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.DeleteTrack);
            this.Controls.Add(this.AddTrackButton);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainWindow";
            this.Text = "Довідник меломана";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_box;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button AddTrackButton;
        private System.Windows.Forms.Button DeleteTrack;
        private System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button openDisks;
    }
}

