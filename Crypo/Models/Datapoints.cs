using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypo.Models
{
    public  class Datapoints
    {
       
        
        public Datapoints(int X, double Y)
        {
            x = X;
            y = Y;


        }
       
        

        public  int x { get; set; }
        public double y { get; set; }
    }
}
