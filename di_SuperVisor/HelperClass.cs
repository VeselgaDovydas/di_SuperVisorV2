using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace di_SuperVisor
{
    class HelperClass
    {
        public class ConnectionTo
        {
            public string ID { get; set; }
            public string IP { get; set; } 
            public override string ToString()
            {
                if (IP.Length > 6) {
                    string[] split = IP.Split('.');
                    return split[3];
                }   
                else
                    return "-";
            }

        }


    }
}
