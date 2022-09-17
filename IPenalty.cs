using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
     interface IPenalty
    {
        long? IdentifyCode { get; set; }
        DateTime dateTime { get; set; }
        string? NumberBaseDocument { get; set; }
        double? Sum { get; set; }
        string? Status { get; set; }
        BankDetails? bankDetails { get; set; }
        public string ChangeStatus();
    }
    [Serializable]
    public class Penalty: IPenalty,ISerializable
    {
        public long? IdentifyCode { get; set; }
        public DateTime dateTime { get; set; }
        public string? NumberBaseDocument { get; set; }
        public double? Sum { get; set; }
        public string? Status { get; set; }
        public BankDetails? bankDetails { get ; set ; }
        public Penalty(long? identifyCode,string ?dateTime, string? numberBaseDocument, double? sum, BankDetails? bankDetails)
        {
            IdentifyCode = identifyCode;
            this.dateTime = Convert.ToDateTime(dateTime);
            NumberBaseDocument = numberBaseDocument;
            Sum = sum;
            bankDetails = bankDetails;
        }
        public Penalty()
        {
            IdentifyCode = null;
            dateTime = DateTime.Now.Date ;
            NumberBaseDocument = null;
            Sum = null;
            Status = null;
            bankDetails = null;
        }
        public string ChangeStatus()
        {
            if (IsOutstanding())
            {
               return "Прострочено";
            }
            else
            {
                return "Не прострочено";
            }
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date: ", dateTime);
            info.AddValue("Number of base document: ", NumberBaseDocument);
            info.AddValue("Sum: ", Sum);
            info.AddValue("Status:", Status);
            info.AddValue("IdentifyCode", IdentifyCode);
        }
        public bool IsOutstanding()
        {
            var day = DateTime.Now.Date - this.dateTime.Date;
            if (day.Days > 15)
            {
                return true;
            }
            return false;

        }
    }
}
