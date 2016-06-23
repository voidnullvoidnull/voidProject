using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using VoidNull.Controls;

namespace VoidNull
{

    public enum ManagerState
    {
        dragging,
        scrolling,
        connecting,
        normal
    }

    public class NodeManager
    {
        public int count = 0;
        public Node selected  = null;
        public Node active = null;
        public ManagerState state = ManagerState.normal;
        public Canvas canvas;
        public MainWindow window;
        public List<NodeLink> links { get; set; } = new List<NodeLink>();
        public Dictionary<int,Node> nodes { get; set; } = new Dictionary<int, Node>();
        public Path curve = new Path();
        public double hardness = 50;

        public double mouseDownPosX = 0;
        public double mouseDownPosY = 0;
        public double scrollPosX = 0;
        public double scrollPosY = 0;

        public Node AddNode()
        {
            count++;
            Node node = new Node(canvas, this, count);
            nodes.Add(node.ID, node);
            node.position = canvas.PointFromScreen(new Point(200, 200));
            selected = node;
            return node;
        }

        public Node LoadNode(NodeInfo info)
        {
            Node node = new Node(canvas, this, info.ID);
            if (nodes.ContainsKey(info.ID))
                        { nodes[info.ID] = node;}
            else
                        { nodes.Add(info.ID, node);}
            node.position = new Point(info.posX, info.posY);
            node.content.SetInfo(info);
            return node;
        }

        public void Select(Node n)
        {
            if (state == ManagerState.normal)
            {
                selected = n;
                window.selectedName.Content = "Selected: " + selected.ID.ToString();
            }
        }

        public void DeleteNode(Node node)
        {
            List<NodeLink> toDelete = new List<NodeLink>();
            foreach(NodeLink link in links)
            {
                if (link.connected.Contains(node))
                        toDelete.Add(link);
            }

            foreach(NodeLink del in toDelete)
            {
                del.Delete();
            }

            canvas.Children.Remove(node.control);
            nodes.Remove(node.ID);
        }

        public void LinkCreate(Node s, Node e)
        {
            NodeLink link = new NodeLink(s, e, this, canvas);
            links.Add(link);
        }

        public void StartConnection(Node start)
        {
            if (state == ManagerState.normal)
            {
                state = ManagerState.connecting;
                active = start;
                curve.Data = NodeEventHelper.BezierGeometry(active.control.outPoint, Mouse.GetPosition(canvas) , hardness);

                canvas.Refresh();
                canvas.Children.Add(curve);
            }
        }

        public void EndConnection(Node end)
        {
            if (state == ManagerState.connecting)
            {
                LinkCreate(active, end);
                state = ManagerState.normal;
                active = null;
            }

            canvas.Children.Remove(curve);
            end.control.Refresh();
        }


        public void OnMove(object sender, MouseEventArgs e)
        {
            if (state == ManagerState.connecting)
            {
                curve.Data = NodeEventHelper.BezierGeometry(active.control.outPoint, Mouse.GetPosition(canvas), hardness);
                window.canvas.Refresh();
            }
            if (state == ManagerState.scrolling)
            {
                window.editorView.ScrollToHorizontalOffset(scrollPosX + (mouseDownPosX - e.GetPosition(window).X));
                window.editorView.ScrollToVerticalOffset(scrollPosY + (mouseDownPosY - e.GetPosition(window).Y));
            }

        }

    }


}
