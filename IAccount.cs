using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
     interface IAccount
       {
        string? Name { get; set; }
        string? Surname { get; set; }
        string? LastName { get; set; }
        string? Created { get; set; }
        static int? NumberID { get; set; }
        string? Password { get; set; }
        public string? Email { get; set; }

        void CreatedAccount() { }
     }
    [Serializable]
    abstract public class Account : IAccount
    {
        public string ? Email { get; set; }
        public long? IdentificationCode { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? LastName { get; set; }
        public string? Created { get; set; }
        public string? Password { get; set; }
        public static int? NumberID { get; set; }
        public Account(string? name, string? surname, string? lastName, string? email)
        {
            Name = name;
            Surname = surname;
            LastName = lastName;
            Created = DateTime.Now.ToString();
            NumberID++;
            Email = email;
        }
        public Account()
        {
            Name = null;
            Surname = null;
            LastName = null;
            Created = DateTime.Now.ToString();
            Email = null;
            NumberID++;
        }
    }
}
