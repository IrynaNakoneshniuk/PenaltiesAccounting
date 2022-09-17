using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
    [Serializable]
    public class BankDetails
    {
        public int? EDRPOU { get; set; }
        public string BankName { get; set; }
        public string ? IBAN { get; set; }
        public BankDetails(int? eDRPOU, string bankName, string? iBAN)
        {
            EDRPOU = eDRPOU;
            BankName = bankName;
            IBAN = iBAN;
        }
        public BankDetails()
        {
            EDRPOU = null;
            BankName = null;
            IBAN = null;
        }
        public override string ToString()
        {
            return $"\nЄДРПОУ : {this.EDRPOU} " +
                   $"\nОтримувач: {this.BankName} " +
                   $"\nIBAN: {this.IBAN}";
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ЄДРПОУ", EDRPOU);
            info.AddValue("Отримувач", BankName);
            info.AddValue("IBAN", IBAN);
        }
    }
    public class VinnytsyaDistrict: BankDetails
    {
        public VinnytsyaDistrict()
        {
            EDRPOU = 37979858;
            BankName = " Казначейство України(ел. адм. подат.)";
            IBAN = "UA578999980313040106000002071";
        }
        public VinnytsyaDistrict GetBankDetails()
        {
           return this;
        }
    }
}
