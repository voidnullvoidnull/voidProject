using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidNull
{
    [Serializable]
    public struct NodeModelInfo
    {
        public int count;
        public List<KeyValuePair<int, int>> links;
        public Dictionary<int, NodeInfo> nodes;

        public void Addlink(KeyValuePair<int, int> pair)
        {
            links.Add(pair);
        }

        public void WriteNodeInfo(NodeInfo info)
        {
            nodes.Add(info.ID,info);
        }
    }
}
