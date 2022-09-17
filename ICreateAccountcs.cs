using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Text.RegularExpressions;
namespace PenaltiesAccounting
{
    internal interface ICreateAccount
    {
        IAccount CreateAccount();
        string CreateLogin();
        string CreatePassword();
        string CreateEmail();
    }
    internal class CreateGeneralDetails
    {
        public string CreateEmail()
        {
            string? Email = null;
            try
            {
                Regex regex = new Regex(RegularExpressin.EmailPattern);
                WriteLine(TextArrayOutput.TextForOutPut[15]);
                Email = ReadLine();
                while (!regex.IsMatch(Email))
                {
                    WriteLine(TextArrayOutput.TextForOutPut[15]);
                    Email = ReadLine();
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if (Email != null)
            {
                return Email;
            }
            else
            {
                throw new NullReferenceException("String is empty!");
            }
        }
        public string CreatePassword()
        {
            WriteLine(TextArrayOutput.TextForOutPut[4]);
            string? Password1 = ReadLine();
            WriteLine(TextArrayOutput.TextForOutPut[5]);
            string? Password2 = ReadLine();
            Regex regex = new Regex(RegularExpressin.PasswordPatern);
            while (!regex.IsMatch(Password1) || Password1 != Password2)
            {
                WriteLine(TextArrayOutput.TextForOutPut[9]);
                WriteLine(TextArrayOutput.TextForOutPut[4]);
                Password1 = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[5]);
                Password2 = ReadLine();
            }
            return Password1;
        }
    }
    internal class CreateIndividualAccount : CreateGeneralDetails,ICreateAccount
    {
        public IAccount CreateAccount()
        {
            Individual ?individual=null;
            try
            {
                TextArrayOutput.TextOutput();
                WriteLine(TextArrayOutput.TextForOutPut[0]);
                string? name = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[1]);
                string? surname = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[2]);
                string? lastName = ReadLine();
                string? Email = CreateEmail();
                long? IdentificationCode =Convert.ToInt64(CreateLogin());
                string? Password = CreatePassword();
                individual= new Individual(IdentificationCode, name, surname, lastName, Password, Email);
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if(individual!=null)
            {
                return individual;
            }
            else
            {
                throw new NullReferenceException("Empty object!");
            }
        }
        public string  CreateLogin()
        {
            string? IdentifcationCode=null;
            try
            {
                Regex regex = new Regex(RegularExpressin.UserPattern);
                WriteLine(TextArrayOutput.TextForOutPut[3]);
                IdentifcationCode = ReadLine();
                while (!regex.IsMatch(IdentifcationCode.ToString()))
                {
                    WriteLine(TextArrayOutput.TextForOutPut[9]);
                    WriteLine(TextArrayOutput.TextForOutPut[3]);
                    IdentifcationCode = ReadLine();
                }
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if (IdentifcationCode != null)
            {
                return IdentifcationCode;
            }
            else
            {
                throw new NullReferenceException("String is empty!");
            }
        }
    }
    internal class CreateExecutiveAgency : CreateGeneralDetails,ICreateAccount
    {
        ExecutiveAgency ?executiveAgency=null ;
        public IAccount CreateAccount()
        {
            Console.Clear();
            try
            {
                TextArrayOutput.TextOutput();
                WriteLine(TextArrayOutput.TextForOutPut[0]);
                string? name = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[1]);
                string? surname = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[2]);
                string? lastName = ReadLine();
                WriteLine(TextArrayOutput.TextForOutPut[7]);
                string? StructUnit = ReadLine();
                string? Email= CreateEmail();
                string ?PoliceID =CreateLogin();
                string? Password = CreatePassword();
                executiveAgency = new ExecutiveAgency(PoliceID, StructUnit, name, surname, lastName, Email, Password);
            }
            catch (IndexOutOfRangeException exR)
            {
                WriteLine(exR.Message.ToString());
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if (executiveAgency != null)
            {
                return executiveAgency;
            }
            else
            {
                throw new NullReferenceException("Empty object!");
            }
        }

        public string CreateLogin()
        {
            string? IdPolice = null;
            try
            {
                Regex regex = new Regex(RegularExpressin.AgencyPattern);
                WriteLine(TextArrayOutput.TextForOutPut[6]);
                IdPolice = ReadLine();
                while (!regex.IsMatch(IdPolice))
                {
                    WriteLine(TextArrayOutput.TextForOutPut[9]);
                    WriteLine(TextArrayOutput.TextForOutPut[6]);
                    IdPolice = ReadLine();
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if(IdPolice != null)
            {
                return IdPolice;
            }
            else
            {
                throw new NullReferenceException("Empty object!");
            }
        }
    }
}
