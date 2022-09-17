using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Linq;

namespace PenaltiesAccounting
{
     interface IOperationWhithAccount
     {
        void AddAccountl(IAccount account, Data data);
        void RemoveAccount(IAccount account, Data data);
        IAccount SigInAccount(Data data);
    }
     internal class OperationAccountIndividual : IOperationWhithAccount
    {
        public void AddAccountl(IAccount account, Data data)
        {
            data.users.Add((Individual)account);
        }
        public void RemoveAccount(IAccount account, Data data)
        {
            data.users.Remove((Individual)account);
        }
        public IAccount SigInAccount(Data data)
        {
            Console.Clear();
            TextArrayOutput.TextOutput();
            if (data != null)
            {
                WriteLine(TextArrayOutput.TextForOutPut[11]);
                long? IdentifyCode = Convert.ToInt64(ReadLine());
                WriteLine(TextArrayOutput.TextForOutPut[16]);
                string? Password = ReadLine();
               IEnumerable<Individual> account  = from i in data.users
                              where i.IdentificationCode == IdentifyCode &&
                              i.Password == Password
                              select i;
                return account.FirstOrDefault();
            }
            else
            {
                throw new NullReferenceException("List data is empty!");
            }
        }
    }
    internal class OperationAccountAgency : IOperationWhithAccount
    {
        public void AddAccountl(IAccount account, Data data)
        {
            data.executiveAgency.Add((ExecutiveAgency)account);
        }

        public void RemoveAccount(IAccount account, Data data)
        {
            data.executiveAgency.Remove((ExecutiveAgency)account);
        }

        public IAccount SigInAccount(Data data)
        {
            Console.Clear();
            if (data != null)
            {
                WriteLine(TextArrayOutput.TextForOutPut[06]);
                string? PolicId = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[16]);
                string? Password = ReadLine();
               IEnumerable<ExecutiveAgency> account= from i in data.executiveAgency
                              where i.PoliceID == PolicId &&
                              i.Password == Password
                              select i;
                return account.FirstOrDefault();
            }
            else
            {
                throw new NullReferenceException("List data is empty!");
            }
        }
    }
}
