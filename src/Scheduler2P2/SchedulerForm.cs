using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

namespace Scheduler2P
{
    public partial class SchedulerForm : Form
    {
        public List<Employee> Employees = new List<Employee>();
        public string GenerationPath = "\\..\\..\\";

        public SchedulerForm()
        {
            InitializeComponent();
        }

        private static void ShowNewEmployeeForm(Fonction f)
        {
            const bool oIsNew = true;
            var employeeForm = new EmployeeForm(f, oIsNew);
            employeeForm.ShowDialog();
        }

        private void InspectEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const bool oIsNew = false;
            openFileDialog1.DefaultExt = "\\..\\..\\Employees\\";
            openFileDialog1.Title = @"Select an employee file";
            var dr = openFileDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                var employeePath = openFileDialog1.FileName;
                var employeeForm = new EmployeeForm(Fonction.Waiter, oIsNew, employeePath);
                employeeForm.ShowDialog();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("You're about to delete every employee files created\nWould you like to continue?",
                            "Confirm", MessageBoxButtons.YesNo);
            
            if(dr == DialogResult.Yes)
            {
                var dir = Directory.GetCurrentDirectory() + "\\..\\..\\Employees";
                var files = Directory.GetFiles(dir);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }
        }

        private void waiterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewEmployeeForm(Fonction.Waiter);
        }

        private void generationPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = @"Select a folder";
            var dr = folderBrowserDialog1.ShowDialog();
            
            if(dr == DialogResult.OK)
            {
                GenerationPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var from = DateTimePickerFrom.Value;
            var to = DateTimePickerTo.Value;

            if(from >= to)
            {
                MessageBox.Show("To date must be later than From date", "Error");
                return;
            }

            var fridays = new List<DateTime>();
            var saturdays = new List<DateTime>();
            for (; from <= to; from.AddDays(1))
            {
                switch (from.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        fridays.Add(from);
                        break;
                    case DayOfWeek.Saturday:
                        saturdays.Add(from);
                        break;
                }
            }
            
            var excel = new ApplicationClass();
            
        }
    }
}
