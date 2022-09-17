using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;

namespace PenaltiesAccounting
{
    internal class Menu
    {
        MainItems mainItems;
        MenuEventHandler menuEventHandler1;
        MenuEventHandler menuEventHandler2;
        public Menu()
        {
            mainItems = new MainItems();
            menuEventHandler1 = new MenuEventHandler();
            menuEventHandler2 = new MenuEventHandler();
        }
        public void Run()
        {
            mainItems.AddAccount();
            mainItems.AddPenalty();
            mainItems.AddOperation();
            AddCommandAtMenu();
            mainItems.data = mainItems.adapterData.GetData();
            while (true)
            {
                Console.SetCursorPosition(5, 1);
                Console.Clear();
                mainItems.accountInfo.ShowGeneralMenu();
                int ChoiceUser = Convert.ToInt16(ReadLine());
                if (ChoiceUser == 1)
                {
                    Console.Clear();
                    mainItems.accountInfo.ChoiceSigIn();
                    int Choise=Convert.ToInt16(ReadLine());
                    menuEventHandler1._sortedEvents[Choise](mainItems);
                }
                else if(ChoiceUser == 2)
                {
                    Console.Clear();
                    mainItems.accountInfo.ChoiceRegistration();
                    int Choise = Convert.ToInt16(ReadLine());
                    menuEventHandler2._sortedEvents[Choise](mainItems);
                }
                else if(ChoiceUser == 3)
                {
                    mainItems.adapterData.Save(mainItems.data);
                    return;
                }
            }
        }
        public void AddCommandAtMenu()
        {
            SigINIndividual sigINIndividual = new SigINIndividual();
            SigINAgency sigINAgency = new SigINAgency();
            RegistrationAgensy registrationAgensy = new RegistrationAgensy();
            RegistrationIndividual registrationIndividual = new RegistrationIndividual();
            menuEventHandler1.menu+= sigINIndividual.Execute;
            menuEventHandler1.menu += sigINAgency.Execute;
            menuEventHandler2.menu += registrationAgensy.Execute;
            menuEventHandler2.menu += registrationIndividual.Execute;

        }
    }
}
