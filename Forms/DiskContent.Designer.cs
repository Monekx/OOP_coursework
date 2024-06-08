namespace OOP_coursework
{
    partial class DiskContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskContent));
            this.label_disk = new System.Windows.Forms.Label();
            this.diskContentView = new System.Windows.Forms.ListView();
            this.trackSelection = new System.Windows.Forms.Button();
            this.TrackDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_disk
            // 
            this.label_disk.AutoSize = true;
            this.label_disk.Location = new System.Drawing.Point(13, 13);
            this.label_disk.Name = "label_disk";
            this.label_disk.Size = new System.Drawing.Size(83, 13);
            this.label_disk.TabIndex = 0;
            this.label_disk.Text = "Контент диску:";
            // 
            // diskContentView
            // 
            this.diskContentView.CheckBoxes = true;
            this.diskContentView.HideSelection = false;
            this.diskContentView.Location = new System.Drawing.Point(12, 29);
            this.diskContentView.Name = "diskContentView";
            this.diskContentView.Size = new System.Drawing.Size(707, 399);
            this.diskContentView.TabIndex = 1;
            this.diskContentView.UseCompatibleStateImageBehavior = false;
            this.diskContentView.View = System.Windows.Forms.View.Details;
            // 
            // trackSelection
            // 
            this.trackSelection.Location = new System.Drawing.Point(632, 434);
            this.trackSelection.Name = "trackSelection";
            this.trackSelection.Size = new System.Drawing.Size(87, 23);
            this.trackSelection.TabIndex = 2;
            this.trackSelection.Text = "Додати треки";
            this.trackSelection.UseVisualStyleBackColor = true;
            this.trackSelection.Click += new System.EventHandler(this.trackSelection_Click);
            // 
            // TrackDelete
            // 
            this.TrackDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TrackDelete.Location = new System.Drawing.Point(528, 434);
            this.TrackDelete.Name = "TrackDelete";
            this.TrackDelete.Size = new System.Drawing.Size(98, 23);
            this.TrackDelete.TabIndex = 3;
            this.TrackDelete.Text = "Видалити треки";
            this.TrackDelete.UseVisualStyleBackColor = true;
            this.TrackDelete.Click += new System.EventHandler(this.TrackDelete_Click);
            // 
            // DiskContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 462);
            this.Controls.Add(this.TrackDelete);
            this.Controls.Add(this.trackSelection);
            this.Controls.Add(this.diskContentView);
            this.Controls.Add(this.label_disk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiskContent";
            this.Text = "DiskContent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_disk;
        private System.Windows.Forms.ListView diskContentView;
        private System.Windows.Forms.Button trackSelection;
        private System.Windows.Forms.Button TrackDelete;
    }
}