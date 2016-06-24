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
    public class Node : NodeBase
    {
        public int ID = 0;
        
        public NodeControl control;

        public NodeContent content;

        public Point position;

        public Node (Canvas canvas, NodeManager manager, int id)
        {
            ID = id;
            base.canvas = canvas;
            base.manager = manager;
            
            control = new NodeControl();
            control.node = this;
            base.canvas.Children.Add(control);
        }

        public void CreateContent<T>() where T : NodeContent, new()
        {
            content = new T(); 
            content.manager = manager;
            content.node = this;
            control.content.Content = content;
        }
    }
}
