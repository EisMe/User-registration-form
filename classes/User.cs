using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nika_Iakobashvili_Davaleba_9.classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
        public string Website { get; set; }

        // Assumes data has already been validated
        public User(string firstName, string lastName, string id, DateTime birthDate, string mail, string phone, string postal, string website)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthDate;
            Mail = mail;
            Phone = phone;
            Postal = postal;
            Website = website;
        }
    }
}
