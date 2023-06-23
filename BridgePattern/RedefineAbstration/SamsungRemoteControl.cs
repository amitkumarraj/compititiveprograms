using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.RedefineAbstration
{
    /// <summary>
    /// RefinedAbstraction for SamsungRemoteControl
    /// </summary>
    public class SamsungRemoteControl: AbstrationRemoteControl
    {
        public SamsungRemoteControl(ILedTV ledTV):base(ledTV)
        {
        }
        public override void SetChannel(int channelNumber)
        {
            _ledTV.SetChannel(channelNumber);
        }

        public override void TrunOnTv()
        {
            _ledTV.TrunOnTv();
        }

        public override void TurnOffTV()
        {
            _ledTV.TurnOffTV();
        }
    }
}
