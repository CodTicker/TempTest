using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArivalsTempsDepartures
{
    public  class API
    {
        public Dictionary<string, int> GetArrivals()
        {
            return new Dictionary<string, int>
            {
                { "Tomas", 2 },
                { "Anders", -11 },
                { "Joel", -22 },
                { "Isabel", -10 },
                  { "Perica", -30 }
            };
        }
        public Dictionary<string, int> GetDepartures() {

            return new Dictionary<string, int>
            {
                { "Tomas", -25 },
                { "Anders", -30 },
                { "Joel", -11 },
                { "Isabel", -11 },
            };
        }

        public Dictionary<int, int> GetTemperatures() {
            return new Dictionary<int, int>
            {
                { 0, 2 },
                { 1, -25 },
                { 2, -22 },
                { 3, -10 },
                { 4, -11 },
                { 5, -30 }
            };


        }
    }
}
