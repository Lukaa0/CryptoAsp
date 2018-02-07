using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Crypo.Models
{
    [DataContract]
    public class HistoricData
    {
        [DataMember(Name ="x")]
        public int x { get; set; }
        [DataMember(Name ="y")]
        public DateTime y { get; set; }

        public HistoricData(int X, DateTime Y)
        {
            x = X;
            y = Y;
        }
        
    }
}
