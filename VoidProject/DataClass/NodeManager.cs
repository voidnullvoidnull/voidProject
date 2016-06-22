using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Threading;
using VoidProject.Controls;

namespace VoidProject
{
    public class NodeManager
    {
        public int count = 0;
        public Node selected { get; private set; } = null;
        public bool isConnecting;

        public Canvas canvas;
        public MainWindow window;

        public List<NodeLink> links { get; private set; } = new List<NodeLink>();
        public List<Node> nodes { get; private set; } = new List<Node>();

        public Node AddNode()
        {
            Node node = new Node(canvas, this, count);
            nodes.Add(node);
            selected = node;
            count++;
            return node;
        }

        public void DeleteNode(Node node)
        {
            canvas.Children.Remove(node.control);
            nodes.Remove(node);

            canvas.Refresh();

        }

        public void Select(Node n)
        {
            selected = n;
            window.selectedName.Content = "Selected: " + selected.ID.ToString();
        }
    }


    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate () { };

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }
}
