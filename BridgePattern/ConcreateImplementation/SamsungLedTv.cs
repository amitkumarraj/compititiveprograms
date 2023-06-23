using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ConcreateImplementation
{
    /// <summary>
    /// ConcreateImplementation for sumsung Tv
    /// </summary>
    class SamsungLedTv : ILedTV
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel number:"+channel+"on Sumsung TV");
        }

        public void TrunOnTv()
        {
            Console.WriteLine("Sumsung Tv Trun On");
        }

        public void TurnOffTV()
        {
            Console.WriteLine("Sumsung Tv Trun Off");
        }
    }
}
