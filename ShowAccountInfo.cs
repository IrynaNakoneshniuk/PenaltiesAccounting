using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PenaltiesAccounting
{
    internal class ShowAccountInfo
    {
        public void ShowPenalty(List<IPenalty> list)
        {
            if(list != null)
            {
                foreach (var penalty in list)
                {
                    string? status =penalty.ChangeStatus();
                    WriteLine($"Протокол: {penalty.NumberBaseDocument}, " +
                        $"Дата: {penalty.dateTime}, Сума: {penalty.Sum}, Статус: {status}");
                }
            }
            else
            {
                WriteLine("Список пустий!");
            }
        }
        public void SecondMenuUserPenalty()
        {
            TextArrayOutput.TextOutput();
           WriteLine("\t\t\t"+TextArrayOutput.TextForOutPut[21]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[25]);

        }
        public void ShowGeneralMenu()
        {
            TextArrayOutput.TextOutput();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[22]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[23]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[24]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[25]);
        }
        public void ChoiceSigIn()
        {
            TextArrayOutput.TextOutput();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[26]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[27]);
        }
        public void ChoiceRegistration()
        {
            TextArrayOutput.TextOutput();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[28]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[29]);
          
        }
        public void  SecondMenu()
        {
            TextArrayOutput.TextOutput();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[30]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[31]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[25]);
        }
        public void SecondMenuUser(IAccount user)
        {
            TextArrayOutput.TextOutput();
            WriteLine($"\t\t\tВітаємо,{user.Name} !") ;
            WriteLine();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[32]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[33]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[25]);
        }
        public void SecondMenuAgency(ExecutiveAgency user)
        {
            TextArrayOutput.TextOutput();
            WriteLine($"\t\t\tВітаємо,{user.Name}  {user.Surname} !");
            WriteLine($"\n\t\t\tСтруктурний підрозділ: {user.StructuralUnit}");
            WriteLine();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[34]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[35]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[31]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[25]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[36]);
        }
        public void RepeadOrExit()
        {
            TextArrayOutput.TextOutput();
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[37]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[33]);
            WriteLine("\t\t\t" + TextArrayOutput.TextForOutPut[25]);
        }
        public void SinglePenalty(List<IPenalty> list, int index)
        {
            VinnytsyaDistrict vinnytsyaDistrict = new VinnytsyaDistrict();
            if (index <= list.Count)
            {
                IPenalty penalty = list[index];
                penalty.ToString();
                WriteLine($"\t\t\tДата: {penalty.dateTime}");
                WriteLine($"\t\t\tПротокол: {penalty.NumberBaseDocument}");
                WriteLine($"\t\t\tСума: {penalty.Sum}");
                WriteLine($"\t\t\tСтатус: {penalty.ChangeStatus()}");
                WriteLine();
                WriteLine($"\t\t\tРеквізити:\n {vinnytsyaDistrict.ToString()}");
                WriteLine();
            }
            else
            {
                WriteLine("\t\t\tНекоректне значення!");
            }
        }
        public void ShowAllPenaltyInformation(List<IPenalty> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                SinglePenalty(list, i);
                WriteLine();
            }
        }
    }
}
