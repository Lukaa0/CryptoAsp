using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CrypyData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Crypo.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Crypo.Controllers
{
    [Produces("application/json")]
    [Route("api/Api")]
    public class ApiController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public ApiController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }
        // GET: api/Api
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Api/5
        [HttpGet("{id}", Name = "Get")]
        public List<CryptoItemModel> Get(int id)
        {
            var jString = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/");
            List<CryptoItemModel> CryptoItemList = new List<CryptoItemModel>();
            var inData = JsonConvert.DeserializeObject<List<CrypoItem>>(jString);
            foreach(var item in inData)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath+"/images", $"{item.symbol.ToLower()}@2x.png");
                CryptoItemModel cryptoItemModel = new CryptoItemModel()
                {
                    last_updated = item.last_updated,
                    market_cap_usd = item.market_cap_usd,
                    name = item.name,
                    percent_change_1h = item.percent_change_1h,
                    percent_change_24h = item.percent_change_24h,
                    percent_change_7d = item.percent_change_7d,
                    available_supply = item.available_supply,
                    id = item.id,
                    price_usd = item.price_usd,
                    rank = item.rank,
                    symbol = item.symbol,
                    total_supply = item.total_supply,
                    volume_usd_24h = item.volume_usd_24h
                
                };
                
                cryptoItemModel.imgUrl = path;
                CryptoItemList.Add(cryptoItemModel);
            }

            return CryptoItemList;
        }
       
        }
    }

