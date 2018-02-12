using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Crypo.Models;
using CrypyData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Crypo.Controllers
{
    public class ListController : Controller
    {
        private ICrypyData _crypyData;
        

        public ListController([FromServices] ICrypyData crypyData)
        {
            _crypyData = crypyData;
        }

        public IActionResult Detail(string id)
        {
            var item = _crypyData.GetById(id);
            var detailModel = new CryptoItemDetalModel()
            {
                Id = id,
                Name = item.name,
                AvailableSupply = item.available_supply,
                MarketCapUsd = item.market_cap_usd,
                Symbol = item.symbol,
                USDprice = item.price_usd,
                TotalSupply = item.total_supply,
                PercentChange_1h = item.percent_change_1h,
                Rank = item.rank

            };



            return View(detailModel);
        }


        
        public IActionResult Index()
        {
            
            
            return View(JsonUtility.DeserializeJsonClass());
        }
    }
}