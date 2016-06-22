using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VoidProject
{
    public class NodeLink: NodeBase
    {
        public Node fromNode;
        public Node toNode;

        public NodeLink(Node from, Node to, NodeManager manager, Canvas canvas)
        {
            fromNode = from;
            toNode = to;
            parentManager = manager;
            parentCanvas = canvas;
        }
    }
}
