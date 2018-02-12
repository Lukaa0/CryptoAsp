using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypo.Models
{
    public  class Datapoints
    {
       
        
        public Datapoints(long X, double Y)
        {
            x = X;
            y = Y;


        }
       
        

        public  long x { get; set; }
        public double y { get; set; }
    }
}
