using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltiesAccounting
{
    internal class MainItems
    {
        public Data data;
        public List<ICreateAccount> account;
        public ShowAccountInfo accountInfo;
        public AdapterData adapterData;
        public List<ICreatePenalty> penalty;
        public List<IOperationWhithAccount> operationWhithAccounts;
        public List<IOperationWhithPenalty> penaltyWhithPenalty;
        public MainItems()
        {
            this.data = new Data();
            account = new List<ICreateAccount>();
            penalty = new List<ICreatePenalty>();
            penaltyWhithPenalty = new List<IOperationWhithPenalty>();
            operationWhithAccounts = new List<IOperationWhithAccount>();
            this.accountInfo = new ShowAccountInfo();
            this.adapterData = new AdapterData(this.data, @"C:\Users\ZbooK\source\repos\PenaltiesAccounting\AccountAgency.xml");
        }
        public void AddAccount()
        {
            CreateExecutiveAgency executiveAgency = new CreateExecutiveAgency();
            account.Add(executiveAgency);
            CreateIndividualAccount createIndividualAccount = new CreateIndividualAccount();
            account.Add(createIndividualAccount);

        }
        public void AddPenalty()
        {
            CraeteTrafficPenalty penaltyTraffic = new CraeteTrafficPenalty();
            CreateAdministrativeFine createAdministrativeFine = new CreateAdministrativeFine();
            penalty.Add(penaltyTraffic);
            penalty.Add(createAdministrativeFine);

        }
        public void AddOperation()
        {
            OperationAccountAgency operationAccountAgency = new OperationAccountAgency();
            OperationAccountIndividual operationAccountIndividual = new OperationAccountIndividual();
            OperationAdministrativeFine operationAdministrativeFine = new OperationAdministrativeFine();
            OperationTrafficPenalty operationTrafficPenalty = new OperationTrafficPenalty();
            operationWhithAccounts.Add(operationAccountAgency);
            operationWhithAccounts.Add(operationAccountIndividual);
            penaltyWhithPenalty.Add(operationAdministrativeFine);
            penaltyWhithPenalty.Add(operationTrafficPenalty);
        }
    }
}
