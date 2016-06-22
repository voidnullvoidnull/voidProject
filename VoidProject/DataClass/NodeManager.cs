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
using VoidProject.Controls;

namespace VoidProject
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
        public List<NodeLink> links { get; private set; } = new List<NodeLink>();
        public Dictionary<int,Node> nodes { get; private set; } = new Dictionary<int, Node>();
        public Path curve = new Path();
        public double hardness = 50;

        public Node AddNode()
        {
            Node node = new Node(canvas, this, count);
            nodes.Add(node.ID, node);
            node.position = canvas.PointFromScreen(new Point(200, 200));
            selected = node;
            count++;
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
                {
                    toDelete.Add(link);
                }
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
                curve.Data = BezierGeometry(active.control.outPoint, Mouse.GetPosition(canvas) , hardness);

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

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (state == ManagerState.connecting)
            {
                canvas.Refresh();
                curve.Data = BezierGeometry(active.control.outPoint, Mouse.GetPosition(canvas), hardness);
                canvas.Refresh();
            }
        }
        
        public void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(state == ManagerState.connecting && Mouse.DirectlyOver == canvas)
            {
                state = ManagerState.normal;
                active = null;
                canvas.Children.Remove(curve);
                canvas.Refresh();
            }

            if(state == ManagerState.normal & canvas.IsMouseOver)
            {
                state = ManagerState.scrolling;
            }
        }

        public void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if(state == ManagerState.scrolling)
            {
                state = ManagerState.normal;
            }
            else if(state == ManagerState.dragging)
            {
                state = ManagerState.normal;
                active = null;
                canvas.Children.Remove(curve);
                canvas.Refresh();
            }
        }

        public static Geometry BezierGeometry(Point start, Point end, double hardness)
        {
            Point p1 = new Point(start.X + hardness, start.Y);
            Point p2 = new Point(end.X - hardness, end.Y);

            BezierSegment segment = new BezierSegment(p1, p2, end, true);
            PathFigure figure = new PathFigure(start, new[] { segment }, false);
            PathGeometry geom = new PathGeometry(new[] { figure });

            return geom;
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
