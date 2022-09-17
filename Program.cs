using static System.Text.Encoding;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;
using System.Text;
using System.Xml.Serialization;
using System.Data;
using System.Runtime.Serialization;
using System.IO;
namespace PenaltiesAccounting
{
    using SaveInXML;
    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.OutputEncoding = System.Text.Encoding.Unicode;
               
                Menu menu = new Menu();
                menu.Run();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
            }
           
        }
    }
}