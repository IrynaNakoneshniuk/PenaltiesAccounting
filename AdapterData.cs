using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltiesAccounting
{
    internal class AdapterData
    {
        public AdapterData(Data data,string?path)
        {
            this.Path = path;
            SaveLoad = new SaveLoadData<Data>(this.Path, data);
        }
        public SaveLoadData<Data> ?SaveLoad;
        public string? Path;
        public void Save(Data data)
        {
            SaveLoad.SaveInFile();
        }
        public Data GetData()
        {
            if (this.SaveLoad.LoadDataFromFile(this.Path) != null)
            {
                return this.SaveLoad.LoadDataFromFile(this.Path);
            }
            else
            {
                throw new NullReferenceException("Data doesnt load!");
            }
           
        }
    }
}
