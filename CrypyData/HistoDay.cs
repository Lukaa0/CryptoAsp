using System;
using System.Collections.Generic;
using System.Text;
using CrypyData;

namespace CrypyData
{
    public class HistoDay
    {
        public string Response { get; set; }
        public string Message { get; set; }
        public int Type { get; set; }
        public bool Aggregated { get; set; }
        public List<HistoDayData> Data { get; set; }
    }
}
