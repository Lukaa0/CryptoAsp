using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CrypyData
{
    public static class  JsonUtility
    {
        public static List<CrypoItem> DeserializeJsonClass()
        {
            var jsonString = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/");
            var recievedItems = JsonConvert.DeserializeObject<List<CrypoItem>>(jsonString);
            return recievedItems;
        }
        public static HistoDay DeserializeJsonHistoric()
        {
            var jsonString = new WebClient().DownloadString("https://min-api.cryptocompare.com/data/histoday");
            dynamic items = JsonConvert.DeserializeObject<HistoDay>(jsonString);
            var itemData = items.data;
            return itemData;
        }
    }
}
