using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class LoopbackPacketSender : SDKObj
    {
        public LoopbackPacketSender(ulong addr) : base(addr)
        {
        }

        public NetworkHandler networkHandler
        {
            get
            {
                return new NetworkHandler(MCM.readInt64(addr + 0x10));
            }
        }
    }
}
