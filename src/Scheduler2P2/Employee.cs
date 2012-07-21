using System;

namespace Scheduler2P
{
    public class Employee
    {
        public string   FirstName    { get; set; }
        public string   LastName     { get; set; }
        public string   Email        { get; set; }
        public string   Phone        { get; set; }
        public string   PicturePath  { get; set; }
        public string   Notes        { get; set; }
        public DateTime Birth        { get; set; }
        public DateTime FirstDay     { get; set; }
        public Fonction Fonction     { get; set; }

        public Employee()
        {
        }

        public Employee(string[] lines)
        {
            foreach(var line in lines)
            {
                if(line.Contains("First Name : "))
                {
                    var index = "First Name : ".Length;
                    FirstName = line.Substring(index, line.Length - index);
                }
                else if(line.Contains("Last Name : "))
                {
                    var index = "Last Name : ".Length;
                    LastName = line.Substring(index, line.Length - index);
                }
                else if(line.Contains("Birthday : "))
                {
                    var index = "Birthday : ".Length;
                    var BirthStr = line.Substring(index, line.Length - index);
                    var split = BirthStr.Split('/');
                    var year = int.Parse(split[2]);
                    var month = int.Parse(split[1]);
                    var day = int.Parse(split[0]);
                    Birth = new DateTime(year, month, day);
                }
                else if(line.Contains("Fonction : "))
                {
                    var index = "Fonction : ".Length;
                    var FonctionStr = line.Substring(index, line.Length - index);
                    switch (FonctionStr)
                    {
                        case "Waiter":
                            Fonction = Fonction.Waiter;
                            break;
                        case "Busboy":
                            Fonction = Fonction.Busboy;
                            break;
                        case "Barman":
                            Fonction = Fonction.Barman;
                            break;
                        case "Security":
                            Fonction = Fonction.Security;
                            break;
                        case "Boss":
                            Fonction = Fonction.Boss;
                            break;
                        case "Manager":
                            Fonction = Fonction.Manager;
                            break;
                        case "Cashier":
                            Fonction = Fonction.Cashier;
                            break;
                    }
                }
                else if(line.Contains("Phone : "))
                {
                    var index = "Phone : ".Length;
                    Phone = line.Substring(index, line.Length - index);
                }
                else if(line.Contains("Email : "))
                {
                    var index = "Email : ".Length;
                    Email = line.Substring(index, line.Length - index);
                }
                else if(line.Contains("PicturePath : "))
                {
                    var index = "PicturePath : ".Length;
                    PicturePath = line.Substring(index, line.Length - index);
                }
                else if(line.Contains("Notes : "))
                {
                    var index = "Notes : ".Length;
                    Notes = line.Substring(index, line.Length - index);
                }
                else if(line.Contains("First Day : "))
                {
                    var index = "First Day : ".Length;
                    var FirstDayStr = line.Substring(index, line.Length - index);
                    var split = FirstDayStr.Split('/');
                    var year = int.Parse(split[2]);
                    var month = int.Parse(split[1]);
                    var day = int.Parse(split[0]);
                    FirstDay = new DateTime(year, month, day);
                }
            }
        }

        public override string ToString()
        {
            return "First Name : "      + FirstName                     + 
                   "\nLast Name : "     + LastName                      +
                   "\nFonction : "      + Fonction                      + 
                   "\nBirthday : "      + Birth.ToShortDateString()     +
                   "\nFirst Day : "     + FirstDay.ToShortDateString()  +
                   "\nPhone : "         + Phone                         + 
                   "\nEmail : "         + Email                         +
                   "\nPicturePath : "   + PicturePath                   + 
                   "\nNotes : "         + Notes;
        }
    }
}
