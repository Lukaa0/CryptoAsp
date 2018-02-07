using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypo.Models
{
    public class CryptoItemDetalModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string USDprice { get; set; }
        public string MarketCapUsd { get; set; }
        public string AvailableSupply { get; set; }
        public string TotalSupply { get; set; }
        public string PercentChange_1h { get; set; }
        public string Rank { get; set; }
    }
}
