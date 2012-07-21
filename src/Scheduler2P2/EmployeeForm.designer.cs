namespace Scheduler2P
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.ButtonCallEmployee = new System.Windows.Forms.Button();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RichTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.OpenFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.ButtonEmail = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.DateTimePickerFirstDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(96, 34);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(200, 22);
            this.TextBoxFirstName.TabIndex = 1;
            this.TextBoxFirstName.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged);
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(96, 61);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(200, 22);
            this.TextBoxLastName.TabIndex = 2;
            this.TextBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(96, 117);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.TextBoxPhone.TabIndex = 4;
            this.TextBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthday";
            // 
            // DateTimePickerBirthday
            // 
            this.DateTimePickerBirthday.Location = new System.Drawing.Point(96, 91);
            this.DateTimePickerBirthday.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.DateTimePickerBirthday.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerBirthday.Name = "DateTimePickerBirthday";
            this.DateTimePickerBirthday.Size = new System.Drawing.Size(200, 22);
            this.DateTimePickerBirthday.TabIndex = 3;
            this.DateTimePickerBirthday.Value = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerBirthday.ValueChanged += new System.EventHandler(this.DateTimePickerBirthday_ValueChanged);
            // 
            // ButtonCallEmployee
            // 
            this.ButtonCallEmployee.Enabled = false;
            this.ButtonCallEmployee.Location = new System.Drawing.Point(221, 116);
            this.ButtonCallEmployee.Name = "ButtonCallEmployee";
            this.ButtonCallEmployee.Size = new System.Drawing.Size(75, 23);
            this.ButtonCallEmployee.TabIndex = 9;
            this.ButtonCallEmployee.Text = "Call";
            this.ButtonCallEmployee.UseVisualStyleBackColor = true;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Enabled = false;
            this.ButtonAccept.Location = new System.Drawing.Point(467, 417);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 10;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(386, 417);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 11;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Enabled = false;
            this.ButtonClear.Location = new System.Drawing.Point(305, 417);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(96, 145);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.TextBoxEmail.TabIndex = 13;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Comments";
            // 
            // RichTextBoxComment
            // 
            this.RichTextBoxComment.Location = new System.Drawing.Point(15, 245);
            this.RichTextBoxComment.Name = "RichTextBoxComment";
            this.RichTextBoxComment.Size = new System.Drawing.Size(281, 96);
            this.RichTextBoxComment.TabIndex = 16;
            this.RichTextBoxComment.Text = "";
            this.RichTextBoxComment.TextChanged += new System.EventHandler(this.RichTextBoxComment_TextChanged);
            // 
            // OpenFileDialogPicture
            // 
            this.OpenFileDialogPicture.FileName = "openFileDialog1";
            this.OpenFileDialogPicture.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogPicture_FileOk);
            // 
            // ButtonEmail
            // 
            this.ButtonEmail.Enabled = false;
            this.ButtonEmail.Location = new System.Drawing.Point(221, 145);
            this.ButtonEmail.Name = "ButtonEmail";
            this.ButtonEmail.Size = new System.Drawing.Size(75, 23);
            this.ButtonEmail.TabIndex = 18;
            this.ButtonEmail.Text = "Email";
            this.ButtonEmail.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(370, 28);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(125, 139);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 19;
            this.PictureBox.TabStop = false;
            this.PictureBox.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // DateTimePickerFirstDay
            // 
            this.DateTimePickerFirstDay.Location = new System.Drawing.Point(96, 185);
            this.DateTimePickerFirstDay.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.DateTimePickerFirstDay.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerFirstDay.Name = "DateTimePickerFirstDay";
            this.DateTimePickerFirstDay.Size = new System.Drawing.Size(200, 22);
            this.DateTimePickerFirstDay.TabIndex = 20;
            this.DateTimePickerFirstDay.Value = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "First Day";
            // 
            // EmployeeForm
            // 
            this.AcceptButton = this.ButtonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(555, 452);
            this.Controls.Add(this.DateTimePickerFirstDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ButtonEmail);
            this.Controls.Add(this.RichTextBoxComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.ButtonCallEmployee);
            this.Controls.Add(this.DateTimePickerBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthday;
        private System.Windows.Forms.Button ButtonCallEmployee;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RichTextBoxComment;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogPicture;
        private System.Windows.Forms.Button ButtonEmail;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.DateTimePicker DateTimePickerFirstDay;
        private System.Windows.Forms.Label label7;
    }
}