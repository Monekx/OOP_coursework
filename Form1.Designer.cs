namespace OOP_coursework
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("225");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("123");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1111",
            "12343544353",
            "12332432432"}, -1, System.Drawing.SystemColors.InactiveCaption, System.Drawing.SystemColors.HotTrack, null);
            this.Search_box = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.AddTrackButton = new System.Windows.Forms.Button();
            this.DeleteTrack = new System.Windows.Forms.Button();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Search_box
            // 
            this.Search_box.Location = new System.Drawing.Point(12, 45);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(686, 20);
            this.Search_box.TabIndex = 0;
            this.Search_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(704, 44);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(68, 21);
            this.Search.TabIndex = 1;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(665, 71);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(107, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Перезавантажити";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AddTrackButton
            // 
            this.AddTrackButton.Location = new System.Drawing.Point(665, 526);
            this.AddTrackButton.Name = "AddTrackButton";
            this.AddTrackButton.Size = new System.Drawing.Size(107, 23);
            this.AddTrackButton.TabIndex = 4;
            this.AddTrackButton.Text = "Додати трек";
            this.AddTrackButton.UseVisualStyleBackColor = true;
            this.AddTrackButton.Click += new System.EventHandler(this.AddTrackButton_Click);
            // 
            // DeleteTrack
            // 
            this.DeleteTrack.Location = new System.Drawing.Point(552, 526);
            this.DeleteTrack.Name = "DeleteTrack";
            this.DeleteTrack.Size = new System.Drawing.Size(107, 23);
            this.DeleteTrack.TabIndex = 5;
            this.DeleteTrack.Text = "Видалити трек";
            this.DeleteTrack.UseVisualStyleBackColor = true;
            this.DeleteTrack.Click += new System.EventHandler(this.DeleteTrack_Click);
            // 
            // listViewSongs
            // 
            this.listViewSongs.HideSelection = false;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            listViewItem3.ToolTipText = "1111111111";
            this.listViewSongs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewSongs.Location = new System.Drawing.Point(12, 100);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(760, 420);
            this.listViewSongs.TabIndex = 6;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.DeleteTrack);
            this.Controls.Add(this.AddTrackButton);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

