using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace PenaltiesAccounting
{
    interface  ICreatePenalty
    {
        IPenalty CreatePenalty();
        
    }
    internal class CreateAdministrativeFine : ICreatePenalty
    {
        public IPenalty CreatePenalty()
        {
            AdministrativeFine ?administrativeFine = null;
            try
            {
                VinnytsyaDistrict vinnytsyaDistrict = new VinnytsyaDistrict();
                TextArrayOutput.TextOutput();
                WriteLine(TextArrayOutput.TextForOutPut[10]);
                string? BaseDocument = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[11]);
                long? IdentifyCode = Convert.ToInt64(ReadLine());
                WriteLine(TextArrayOutput.TextForOutPut[12]);
                double? Sum = Convert.ToDouble(ReadLine());
                WriteLine(TextArrayOutput.TextForOutPut[13]);
                string? dateTime = ReadLine(); 
                administrativeFine= new AdministrativeFine(IdentifyCode, dateTime,BaseDocument, Sum, vinnytsyaDistrict);
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if(administrativeFine == null)
            {
                throw new NullReferenceException("Object is empty!");
            }
            else
            {
                return administrativeFine;
            }
        }
    }

    internal class CraeteTrafficPenalty : ICreatePenalty
    {
        public IPenalty CreatePenalty()
        {
            TrafficRuelsPenalty? Fine = null;
            try
            {
                VinnytsyaDistrict vinnytsyaDistrict = new VinnytsyaDistrict();
                TextArrayOutput.TextOutput();
                WriteLine(TextArrayOutput.TextForOutPut[10]);
                string? BaseDocument = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[11]);
                long? IdentifyCode = Convert.ToInt64(ReadLine());
                WriteLine(TextArrayOutput.TextForOutPut[12]);
                double? Sum = Convert.ToDouble(ReadLine());
                WriteLine(TextArrayOutput.TextForOutPut[13]);
                string ?dateTime = ReadLine();
                string? CarNumber = CreateNumberCar();
                Fine = new TrafficRuelsPenalty(CarNumber,IdentifyCode, dateTime, BaseDocument, Sum, vinnytsyaDistrict);
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if (Fine == null)
            {
                throw new NullReferenceException("Object is empty!");
            }
            else
            {
                return Fine;
            }
        }
        public string CreateNumberCar()
        {
            Regex regex = new Regex(RegularExpressin.CarNumber);
            WriteLine(TextArrayOutput.TextForOutPut[14]);
            string number = ReadLine();
            while (regex.IsMatch(number))
            {
                WriteLine(TextArrayOutput.TextForOutPut[9]);
                WriteLine(TextArrayOutput.TextForOutPut[14]);
                number = ReadLine();
            }
            return number;
        }
    }
}
