using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// Implementer
    /// </summary>
    public interface ILedTV
    {
        void TurnOffTV();
        void TrunOnTv();
        void SetChannel(int channel);
    }
}
