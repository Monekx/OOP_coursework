namespace OOP_coursework
{
    partial class DisksList
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
            this.diskList = new System.Windows.Forms.ListView();
            this.diskCreate = new System.Windows.Forms.Button();
            this.diskNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseDisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diskList
            // 
            this.diskList.CheckBoxes = true;
            this.diskList.HideSelection = false;
            this.diskList.Location = new System.Drawing.Point(12, 52);
            this.diskList.Name = "diskList";
            this.diskList.Size = new System.Drawing.Size(775, 350);
            this.diskList.TabIndex = 0;
            this.diskList.UseCompatibleStateImageBehavior = false;
            this.diskList.UseWaitCursor = true;
            this.diskList.View = System.Windows.Forms.View.Details;
            this.diskList.ItemActivate += new System.EventHandler(this.diskList_ItemActivate);
            this.diskList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // diskCreate
            // 
            this.diskCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.diskCreate.Location = new System.Drawing.Point(691, 25);
            this.diskCreate.Name = "diskCreate";
            this.diskCreate.Size = new System.Drawing.Size(97, 21);
            this.diskCreate.TabIndex = 1;
            this.diskCreate.Text = "Створити диск";
            this.diskCreate.UseVisualStyleBackColor = true;
            this.diskCreate.Click += new System.EventHandler(this.diskCreate_Click);
            // 
            // diskNameAdd
            // 
            this.diskNameAdd.Location = new System.Drawing.Point(12, 25);
            this.diskNameAdd.Name = "diskNameAdd";
            this.diskNameAdd.Size = new System.Drawing.Size(672, 20);
            this.diskNameAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва диску для створення:";
            // 
            // chooseDisk
            // 
            this.chooseDisk.Location = new System.Drawing.Point(691, 408);
            this.chooseDisk.Name = "chooseDisk";
            this.chooseDisk.Size = new System.Drawing.Size(96, 23);
            this.chooseDisk.TabIndex = 4;
            this.chooseDisk.Text = "Відкрити диск";
            this.chooseDisk.UseVisualStyleBackColor = true;
            // 
            // DisksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.chooseDisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diskNameAdd);
            this.Controls.Add(this.diskCreate);
            this.Controls.Add(this.diskList);
            this.Name = "DisksList";
            this.Text = "DisksList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView diskList;
        private System.Windows.Forms.Button diskCreate;
        private System.Windows.Forms.TextBox diskNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseDisk;
    }
}