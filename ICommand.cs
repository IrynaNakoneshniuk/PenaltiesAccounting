using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PenaltiesAccounting
{
    internal interface ICommand
    {
        void Execute(MainItems mainItems);
    }
    internal class SigINIndividual : ICommand
    {
        public void Execute(MainItems mainItems)
        {
            try
            {
                TextArrayOutput.TextOutput();
                Console.Clear();
                Individual individual = null;
                do
                {
                    individual = (Individual)mainItems.operationWhithAccounts[1].SigInAccount(mainItems.data);
                    if (individual == null)
                    {
                        WriteLine(TextArrayOutput.TextForOutPut[18]);
                        Thread.Sleep(2000);
                    }
                } while (individual == null);
                Console.Clear();
                mainItems.accountInfo.SecondMenuUser(individual);
                int? Choise2 = Convert.ToInt32(Console.ReadLine());
                if (Choise2 == 1)
                {
                    Console.Clear();
                    if (mainItems.data.trafficRuelsPenalty==null&&mainItems.data.administrativePenalties==null)
                    {
                        WriteLine("Штрафи відсутні!");
                        ReadLine();
                    }
                    else
                    {
                        mainItems.accountInfo.ShowPenalty(mainItems.penaltyWhithPenalty[0].GetPenalty(mainItems.data));
                        mainItems.accountInfo.ShowPenalty(mainItems.penaltyWhithPenalty[1].GetPenalty(mainItems.data));
                        ReadLine();
                    }
                    mainItems.accountInfo.SecondMenuUserPenalty();
                    int? Exit = Convert.ToInt32(Console.ReadLine());
                    if (Exit == 1)
                    {
                        Console.Clear();
                        mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[0].GetPenalty(mainItems.data));
                        mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[1].GetPenalty(mainItems.data));
                        ReadLine();
                        mainItems.accountInfo.SecondMenuUserPenalty();
                        int? Exit2 = Convert.ToInt32(Console.ReadLine());
                        if (Exit2 == 1)
                        {
                            Console.Clear();
                            mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[0].GetPenalty(mainItems.data));
                            mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[1].GetPenalty(mainItems.data));
                            ReadLine();
                        }
                        else if (Exit2 == 2)
                        {
                            return;
                        }
                    }
                    else if (Exit == 2)
                    {
                        return;
                    }
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
    }
    internal class SigINAgency : ICommand
    {
        public void Execute(MainItems mainItems)
        {
            try
            {
                TextArrayOutput.TextOutput();
                Console.Clear();
                ExecutiveAgency executiveAgency = null;
                do
                {
                    executiveAgency = (ExecutiveAgency)mainItems.operationWhithAccounts[0].SigInAccount(mainItems.data);
                    if (executiveAgency == null)
                    {
                        WriteLine(TextArrayOutput.TextForOutPut[18]);
                        Thread.Sleep(2000);
                    }
                } while (executiveAgency == null);
                Console.Clear();
                mainItems.accountInfo.SecondMenuAgency(executiveAgency);
                int? Choise2 = Convert.ToInt32(Console.ReadLine());
                if (Choise2 == 1)
                {
                    int? Choise3;
                    do
                    {
                        Console.Clear();
                        TrafficRuelsPenalty trafficRuelsPenalty = (TrafficRuelsPenalty)mainItems.penaltyWhithPenalty[1].Create();
                        mainItems.data.trafficRuelsPenalty.Add(trafficRuelsPenalty);
                        mainItems.accountInfo.RepeadOrExit();
                        Choise3 = Convert.ToInt32(Console.ReadLine());
                    } while (Choise3 == 1);
                    if (Choise3 == 3)
                    {
                        mainItems.adapterData.Save(mainItems.data);
                        return;
                    }
                }
                else if (Choise2 == 2)
                {
                    int? Choise3;
                    do
                    {
                        Console.Clear();
                        AdministrativeFine administrativeFine = (AdministrativeFine)mainItems.penaltyWhithPenalty[0].Create();
                        mainItems.data.administrativePenalties.Add(administrativeFine);
                        mainItems.accountInfo.RepeadOrExit();
                        Choise3 = Convert.ToInt32(Console.ReadLine());
                    } while (Choise3 == 1);
                    if (Choise3 == 3)
                    {
                        mainItems.adapterData.Save(mainItems.data);
                        return;
                    }
                }
                else if (Choise2 == 3)
                {
                    mainItems.adapterData.Save(mainItems.data);
                    Menu menu = new Menu();
                    menu.Run();
                }
                else if (Choise2 == 4)
                {
                    mainItems.adapterData.Save(mainItems.data);
                    return;
                }
                else if(Choise2 == 5)
                {
                     mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[0].GetPenalty(mainItems.data));
                     mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[1].GetPenalty(mainItems.data));
                      ReadLine();
                    return;
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
    }
    internal class RegistrationAgensy : ICommand
    {
        public void Execute(MainItems mainItems)
        {
            try
            {
                Console.Clear();
                IAccount executiveAgency = mainItems.account[0].CreateAccount();
                mainItems.operationWhithAccounts[0].AddAccountl(executiveAgency, mainItems.data);
                Console.Clear();
                mainItems.accountInfo.SecondMenuAgency((ExecutiveAgency)executiveAgency);
                int? Choise2 = Convert.ToInt32(Console.ReadLine());
                if (Choise2 == 1)
                {
                    int? Choise3;
                    do
                    {
                        Console.Clear();
                        TrafficRuelsPenalty trafficRuelsPenalty = (TrafficRuelsPenalty)mainItems.penaltyWhithPenalty[1].Create();
                        mainItems.data.trafficRuelsPenalty.Add(trafficRuelsPenalty);
                        mainItems.accountInfo.RepeadOrExit();
                        Choise3 = Convert.ToInt32(Console.ReadLine());
                    } while (Choise3 == 1);
                    if (Choise3 == 3)
                    {
                        mainItems.adapterData.Save(mainItems.data);
                        return;
                    }
                }
                else if (Choise2 == 2)
                {
                    int? Choise3;
                    do
                    {
                        Console.Clear();
                        AdministrativeFine administrativeFine = (AdministrativeFine)mainItems.penaltyWhithPenalty[0].Create();
                        mainItems.data.administrativePenalties.Add(administrativeFine);
                        mainItems.accountInfo.RepeadOrExit();
                        Choise3 = Convert.ToInt32(Console.ReadLine());
                    } while (Choise3 == 1);
                    if (Choise3 == 3)
                    {
                        mainItems.adapterData.Save(mainItems.data);
                        return;
                    }
                }
                else if (Choise2 == 3)
                {
                    mainItems.adapterData.Save(mainItems.data);
                    Menu menu = new Menu();
                    menu.Run();
                }
                else if (Choise2 == 4)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
    }
    internal class RegistrationIndividual : ICommand
    {
        public void Execute(MainItems mainItems)
        {
            try
            {
                IAccount executiveAgency = mainItems.account[1].CreateAccount();
                mainItems.operationWhithAccounts[1].AddAccountl(executiveAgency, mainItems.data);
                Console.Clear();
                mainItems.accountInfo.SecondMenuUser(executiveAgency);
                int? Choise2 = Convert.ToInt32(Console.ReadLine());
                if (Choise2 == 1)
                {
                    Console.Clear();
                    mainItems.accountInfo.ShowPenalty(mainItems.penaltyWhithPenalty[0].GetPenalty(mainItems.data));
                    mainItems.accountInfo.ShowPenalty(mainItems.penaltyWhithPenalty[1].GetPenalty(mainItems.data));
                    Console.Clear();
                    mainItems.accountInfo.SecondMenuUserPenalty();
                    int? Exit = Convert.ToInt32(Console.ReadLine());
                    if (Exit == 1)
                    {
                        mainItems.adapterData.Save(mainItems.data);
                        return;
                    }
                    else if (Exit == 2)
                    {
                        Console.Clear();
                        mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[0].GetPenalty(mainItems.data));
                        mainItems.accountInfo.ShowAllPenaltyInformation(mainItems.penaltyWhithPenalty[1].GetPenalty(mainItems.data));
                    }
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
    }
}
