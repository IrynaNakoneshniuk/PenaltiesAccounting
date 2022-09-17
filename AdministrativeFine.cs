using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
    [Serializable]
    public class AdministrativeFine:Penalty,ISerializable
    {
        public AdministrativeFine(long? identifyCode, string? dateTime, string? numberBaseDocument, 
            double? sum, BankDetails? bankDetails):base(identifyCode, dateTime, numberBaseDocument, sum,  bankDetails)
        {
        }
        public AdministrativeFine() : base(){
            this.Status = null;
            this.bankDetails = null;
            this.IdentifyCode = null;
            this.Sum = null;
            this.NumberBaseDocument = null;
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date: ", dateTime);
            info.AddValue("Number of base document: ", NumberBaseDocument);
            info.AddValue("Sum: ", Sum);
            info.AddValue("Status:", Status);
            info.AddValue("IdentifyCode", IdentifyCode);
        }
    }
}
