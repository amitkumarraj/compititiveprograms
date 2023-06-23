using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class AbstrationRemoteControl
    {
        protected ILedTV _ledTV;
        protected AbstrationRemoteControl(ILedTV ledTV)
        {
            _ledTV = ledTV;
        }
        public abstract void TurnOffTV();
        public abstract void TrunOnTv();
        public abstract void SetChannel(int channelNumber);
    }
}
