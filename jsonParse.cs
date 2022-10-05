using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{
    class jsonParse
    {
        public string price_usd { get; set; }
        public string volume24 { get; set; }

        public override string ToString()
        {
            return price_usd + volume24;
        }

    }
}
