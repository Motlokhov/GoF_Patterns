using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Struct.Bridge
{
    internal class BridgeClient
    {
        IBridgeAbstraction _bridge;
        public BridgeClient(IBridgeAbstraction bridge)
        {
            _bridge = bridge;
        }

        public void UseBridge()
        {
            _bridge.Operation();
        }
    }
}
