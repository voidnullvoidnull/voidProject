using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidNull
{

/// <summary>
/// Представляет из себя структуру данных, проецирующую на себя информацию из NodeManager, для последующего их сохранения на диск.
/// Содержит методы добавления информации по элеметам и ссылкам в формате, удобном для сохранения.
/// </summary>

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
