using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
    [Serializable]
    public class ExecutiveAgency:Account,ISerializable
    {
        public string? StructuralUnit { get; set; }
        public string ? PoliceID { get; set; }
        public ExecutiveAgency(string? PoliceID, string? StructuralUnit, string? name, string? surname, string? lastName, 
            string? Email,string? Password)
            : base(name, surname, lastName, Email)
        {
            this.PoliceID = PoliceID;
            this.StructuralUnit = StructuralUnit;
            this.Password = Password;
        }
        public ExecutiveAgency() : base()
        {
            this.Password = null;
            this.Email = null;
            this.LastName = null;
            this.Name = null;
            this.Password = null;
            this.Surname = null;
            this.PoliceID = null;
            this.StructuralUnit = null;
            this.Password = null;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name:", Name);
            info.AddValue("Surname:", Surname);
            info.AddValue("LastName:", LastName);
            info.AddValue("Created:", Created);
            info.AddValue("NumberID", NumberID);
            info.AddValue("Police ID", PoliceID);
            info.AddValue("Password", Password);
            info.AddValue("Structural Unit", StructuralUnit);
            info.AddValue("Email", Email);
        }
    }
}
