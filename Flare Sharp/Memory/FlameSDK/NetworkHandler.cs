using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class NetworkHandler : SDKObj
    {
        public NetworkHandler(ulong addr) : base(addr)
        {

        }

        public RakNetInstance rakNetInstance
        {
            get
            {
                return new RakNetInstance(MCM.readInt64(addr + 0x18));
            }
        }
    }
}
