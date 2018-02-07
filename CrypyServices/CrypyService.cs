using CrypyData;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CrypyServices
{
    public class CrypyService : ICrypyData
    {
        private CrypoItem crypoItem;

        public CrypyService() { }
        public CrypyService(CrypoItem crypo)
        {
            crypoItem = crypo;
        }
        public CrypoItem GetById(string Id)
        {
            var itemList = JsonUtility.DeserializeJsonClass();
            for(int i =0; i < itemList.Count(); i++)
            {
                crypoItem = itemList.FirstOrDefault(item => item.id == Id);
            }
            return crypoItem;
        }
    }
}
