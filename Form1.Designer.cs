namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.LB_Mobile = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.TB_Mobile = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LB_MeetingWith = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LB_Date = new System.Windows.Forms.Label();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(761, 34);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(361, 372);
            this.listBox.TabIndex = 0;
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.AutoSize = true;
            this.LB_FirstName.Location = new System.Drawing.Point(29, 34);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(69, 16);
            this.LB_FirstName.TabIndex = 1;
            this.LB_FirstName.Text = "FirstName";
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Location = new System.Drawing.Point(29, 109);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(69, 16);
            this.LB_LastName.TabIndex = 2;
            this.LB_LastName.Text = "LastName";
            // 
            // LB_Mobile
            // 
            this.LB_Mobile.AutoSize = true;
            this.LB_Mobile.Location = new System.Drawing.Point(29, 181);
            this.LB_Mobile.Name = "LB_Mobile";
            this.LB_Mobile.Size = new System.Drawing.Size(48, 16);
            this.LB_Mobile.TabIndex = 3;
            this.LB_Mobile.Text = "Mobile";
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(29, 258);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(41, 16);
            this.LB_Email.TabIndex = 4;
            this.LB_Email.Text = "Email";
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Location = new System.Drawing.Point(32, 63);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(236, 22);
            this.TB_FirstName.TabIndex = 5;
            // 
            // TB_LastName
            // 
            this.TB_LastName.Location = new System.Drawing.Point(32, 138);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(236, 22);
            this.TB_LastName.TabIndex = 6;
            // 
            // TB_Mobile
            // 
            this.TB_Mobile.Location = new System.Drawing.Point(32, 212);
            this.TB_Mobile.Name = "TB_Mobile";
            this.TB_Mobile.Size = new System.Drawing.Size(236, 22);
            this.TB_Mobile.TabIndex = 7;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(32, 288);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(236, 22);
            this.TB_Email.TabIndex = 8;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(32, 358);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(236, 35);
            this.BT_Save.TabIndex = 9;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(401, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // LB_MeetingWith
            // 
            this.LB_MeetingWith.AutoSize = true;
            this.LB_MeetingWith.Location = new System.Drawing.Point(398, 181);
            this.LB_MeetingWith.Name = "LB_MeetingWith";
            this.LB_MeetingWith.Size = new System.Drawing.Size(81, 16);
            this.LB_MeetingWith.TabIndex = 11;
            this.LB_MeetingWith.Text = "MeetingWith";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Location = new System.Drawing.Point(398, 34);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(36, 16);
            this.LB_Date.TabIndex = 13;
            this.LB_Date.Text = "Date";
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(529, 358);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(109, 35);
            this.BT_Delete.TabIndex = 14;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(401, 358);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(110, 35);
            this.BT_Update.TabIndex = 15;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 515);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.LB_Date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LB_MeetingWith);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_Mobile);
            this.Controls.Add(this.TB_LastName);
            this.Controls.Add(this.TB_FirstName);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.LB_Mobile);
            this.Controls.Add(this.LB_LastName);
            this.Controls.Add(this.LB_FirstName);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.Label LB_Mobile;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.TextBox TB_Mobile;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LB_MeetingWith;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.TextBox textBox1;
    }
}

