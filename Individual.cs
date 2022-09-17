using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using static System.Console;
using System.Text.RegularExpressions;



namespace PenaltiesAccounting
{
    [Serializable]
    public class Individual:Account,ISerializable
    {
        public Individual(long? identificationCode, string? name, string? surname, string? lastName,string ?Password,string ?Email )
            : base(name, surname, lastName, Email)
        {
            this.IdentificationCode = identificationCode;
            this.Password = Password;
        }
        public Individual() : base()
        {
            IdentificationCode = null;
            this.Password = null;
            this.Email = null;
            this.LastName = null;
            this.Name = null;
            this.Password = null;
            this.Surname = null;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name:", Name);
            info.AddValue("Surname:", Surname);
            info.AddValue("LastName:", LastName);
            info.AddValue("Created:", Created);
            info.AddValue("NumberID", NumberID);
            info.AddValue("Identification Code", IdentificationCode);
            info.AddValue("Email", Email);
        }
    }
}
