using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidProject
{
    [Serializable]
    public struct ModelInfo
    {
        public List<KeyValuePair<int, int>> links;
        public Dictionary<int, NodeInfo> nodes;

        public void Addlink(KeyValuePair<int, int> pair)
        {
            links.Add(pair);
        }

        public void AddNodeInfo(NodeInfo info)
        {
            nodes.Add(info.ID,info);
        }
    }
}
