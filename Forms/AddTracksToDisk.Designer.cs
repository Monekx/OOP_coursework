namespace OOP_coursework
{
    partial class AddTracksToDisk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTracksToDisk));
            this.addTrackToDisk_View = new System.Windows.Forms.ListView();
            this.addTrackToDisk_OK = new System.Windows.Forms.Button();
            this.addTrackToForm_DECLINE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTrackToDisk_View
            // 
            this.addTrackToDisk_View.CheckBoxes = true;
            this.addTrackToDisk_View.HideSelection = false;
            this.addTrackToDisk_View.Location = new System.Drawing.Point(13, 27);
            this.addTrackToDisk_View.Name = "addTrackToDisk_View";
            this.addTrackToDisk_View.Size = new System.Drawing.Size(775, 390);
            this.addTrackToDisk_View.TabIndex = 0;
            this.addTrackToDisk_View.UseCompatibleStateImageBehavior = false;
            this.addTrackToDisk_View.View = System.Windows.Forms.View.Details;
            // 
            // addTrackToDisk_OK
            // 
            this.addTrackToDisk_OK.Location = new System.Drawing.Point(713, 423);
            this.addTrackToDisk_OK.Name = "addTrackToDisk_OK";
            this.addTrackToDisk_OK.Size = new System.Drawing.Size(75, 23);
            this.addTrackToDisk_OK.TabIndex = 1;
            this.addTrackToDisk_OK.Text = "OK";
            this.addTrackToDisk_OK.UseVisualStyleBackColor = true;
            this.addTrackToDisk_OK.Click += new System.EventHandler(this.addTrackToDisk_OK_Click);
            // 
            // addTrackToForm_DECLINE
            // 
            this.addTrackToForm_DECLINE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addTrackToForm_DECLINE.Location = new System.Drawing.Point(632, 423);
            this.addTrackToForm_DECLINE.Name = "addTrackToForm_DECLINE";
            this.addTrackToForm_DECLINE.Size = new System.Drawing.Size(75, 23);
            this.addTrackToForm_DECLINE.TabIndex = 2;
            this.addTrackToForm_DECLINE.Text = "Скасувати";
            this.addTrackToForm_DECLINE.UseVisualStyleBackColor = true;
            this.addTrackToForm_DECLINE.Click += new System.EventHandler(this.addTrackToForm_DECLINE_Click);
            // 
            // AddTracksToDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addTrackToForm_DECLINE);
            this.Controls.Add(this.addTrackToDisk_OK);
            this.Controls.Add(this.addTrackToDisk_View);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTracksToDisk";
            this.Text = "Додати треки до диску";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView addTrackToDisk_View;
        private System.Windows.Forms.Button addTrackToDisk_OK;
        private System.Windows.Forms.Button addTrackToForm_DECLINE;
    }
}