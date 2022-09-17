using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace PenaltiesAccounting
{
    using SaveInXML;
    internal class SaveLoadData<T>
    {
        public T? UsersData;
        public string XMLFilePath;
        public SaveLoadData(string XMLFilePath, T? UsersData)
        {
            this.XMLFilePath = XMLFilePath;
            this.UsersData = UsersData;
        }
        public void GetData(T ?UsersData)
        {
            this.UsersData = UsersData;
        }
        public void SaveInFile()
        {
            try
            {
                SerializerXML.SerializeObject(XMLFilePath, UsersData);
            }
            catch (SerializationException ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        public T LoadDataFromFile(string XMLFilePath)
        {
            T UsersData=default(T);
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
                using (Stream fs = new FileStream(@XMLFilePath, FileMode.Open))
                {
                     UsersData  = (T)xmlSerializer.Deserialize(fs);
                    fs.Close();
                }
            }
            catch (SerializationException ex)
            {
                WriteLine(ex.Message.ToString());
            }
            if (UsersData != null)
            {
                return UsersData;
            }
            else
            {
                throw new NullReferenceException("Data not load!");
            }
        }
    }
}
