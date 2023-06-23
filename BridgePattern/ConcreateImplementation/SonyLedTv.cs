using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ConcreateImplementation
{
    /// <summary>
    /// ConcreateImplementation for Sony Tv
    /// </summary>
    class SonyLedTv : ILedTV
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel number:" + channel + "on Sony TV");
        }

        public void TrunOnTv()
        {
            Console.WriteLine("Sony Tv Trun On");
        }

        public void TurnOffTV()
        {
            Console.WriteLine("Sony Tv Trun Off");
        }
    }
}
