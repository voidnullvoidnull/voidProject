using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using VoidNull.Controls;

namespace VoidNull
{
    public abstract class NodeContent : UserControl 
    {
        public string contentType;
        public Node node;
        public NodeManager manager;
        public StackPanel panel;


        public NodeContent()
        {
            panel = new StackPanel();
            Content = panel;
        }

        public virtual NodeInfo Getinfo()
        {
            return new NodeInfo
            {
                ID = node.ID,
                contentType = contentType,
                posX = node.position.X,
                posY = node.position.Y,
            };
        }

    }
}
