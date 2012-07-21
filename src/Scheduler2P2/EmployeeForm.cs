using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scheduler2P
{
    public enum Fonction
    {
        Waiter,
        Barman,
        Security,
        Busboy,
        Manager,
        Boss,
        Cashier
    };

    public partial class EmployeeForm : Form
    {
        private Fonction Fonction;
        private bool     IsNew;
        private bool     IsModified;
        private Employee NewEmployee = new Employee();
        
        public EmployeeForm(Fonction f, bool iIsNew, string employeePath = "")
        {
            InitializeComponent();

            Fonction = f;
            IsNew = iIsNew;

            Text = (IsNew ? @"New " : @"Inspect ") + Fonction;
            
            if(!IsNew && employeePath.Length > 0)
            {
                var employee = new Employee(File.ReadAllLines(employeePath));
                TextBoxFirstName.Text = employee.FirstName;
                TextBoxLastName.Text = employee.LastName;
                DateTimePickerBirthday.Value = employee.Birth;
                TextBoxPhone.Text = employee.Phone;
                TextBoxEmail.Text = employee.Email;

                if(employee.PicturePath != "")
                    PictureBox.ImageLocation = employee.PicturePath;

                if(employee.Notes != "")
                    RichTextBoxComment.Text = employee.Notes;
            }
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(@"Are you sure you want to abort?", @"Confirm", 
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialogPicture.ShowDialog();
        }

        private void OpenFileDialogPicture_FileOk(object sender, CancelEventArgs e)
        {
            PictureBox.ImageLocation = OpenFileDialogPicture.FileName;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach(var control in Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox) control).Text = "";
                }
            }

            DateTimePickerBirthday.Value = new DateTime(1985, 01, 01);
            RichTextBoxComment.Text = "";
            EnableClearAcceptButtons();
        }

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            EnableClearAcceptButtons();
        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            EnableClearAcceptButtons();
        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            EnableClearAcceptButtons();
        }

        private void RichTextBoxComment_TextChanged(object sender, EventArgs e)
        {
            EnableClearAcceptButtons();
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            EnableClearAcceptButtons();
        }

        private void EnableClearAcceptButtons()
        {
            var textBoxes = Controls.OfType<TextBox>();
            IsModified = true;

            ButtonClear.Enabled = !textBoxes.All(x => x.Text == "");
            ButtonAccept.Enabled = textBoxes.All(x => x.Text != "");
        }

        private bool ValidateInputs()
        {
            //var textBoxes = Controls.OfType<TextBox>();

            //foreach (var textBox in textBoxes)
            //{
            //    textBox.BackColor = Color.White;
            //}

            //if(TextBoxFirstName.Text.Contains(' '))
            //{
            //    MessageBox.Show(@"First name can't contain any space!", @"Error", MessageBoxButtons.OK);
            //    TextBoxFirstName.BackColor = Color.Red;
            //    return false;
            //}

            //if (!TextBoxPhone.Text.Contains('-') || !TextBoxPhone.Text.Contains('(') || !TextBoxPhone.Text.Contains(')'))
            //{
            //    MessageBox.Show(@"Phone number is not the good format!\nPlease use (xxx)-xxx-xxxx", @"Error", MessageBoxButtons.OK);
            //    TextBoxPhone.BackColor = Color.Red;
            //    return false;
            //}

            return true;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            AcceptForm();
        }

        private void AcceptForm()
        {
            var validInputs = ValidateInputs();
            if (validInputs)
            {
                if (IsNew)
                {
                    var stream =
                        File.Create(Directory.GetCurrentDirectory() + "\\..\\..\\Employees\\" + TextBoxFirstName.Text.Replace('?','e') +
                                    " " + TextBoxLastName.Text.Replace('?', 'e') + ".emp");
                    NewEmployee.FirstName = TextBoxFirstName.Text;
                    NewEmployee.LastName = TextBoxLastName.Text;
                    NewEmployee.Birth = DateTimePickerBirthday.Value;
                    NewEmployee.FirstDay = DateTimePickerFirstDay.Value;
                    NewEmployee.Fonction = Fonction;
                    NewEmployee.Phone = TextBoxPhone.Text;
                    NewEmployee.Email = TextBoxEmail.Text;
                    
                    if(PictureBox.ImageLocation != null)
                        NewEmployee.PicturePath = PictureBox.ImageLocation;

                    if(RichTextBoxComment.Text != null)
                        NewEmployee.Notes = RichTextBoxComment.Text;

                    var buffer = Encoding.ASCII.GetBytes(NewEmployee.ToString());

                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                    Close();
                }
                else if (IsModified)
                {
                    IsNew = true;
                    AcceptForm();
                }
            }
        }

        private void DateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerFirstDay.Value = DateTimePickerBirthday.Value.AddYears(18);
        }
    }
}
