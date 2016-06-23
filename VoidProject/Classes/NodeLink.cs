using System;
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
    public class NodeLink: NodeBase
    {
        public Node[] connected = new Node[2];

        public Path controlCurve;

        public Ellipse deleteControl;

        public NodeLink(Node from, Node to, NodeManager manager, Canvas canvas)
        {
            connected[0] = from;
            connected[1] = to;
            parentManager = manager;
            parentCanvas = canvas;

            controlCurve = new Path();
            controlCurve.Stroke = Brushes.AliceBlue;
            controlCurve.StrokeThickness = 2;

            deleteControl = new Ellipse();
            deleteControl.Width = 20;
            deleteControl.Height = 20;
            deleteControl.Fill = Brushes.IndianRed;
            deleteControl.MouseDown += OnDelete;

            canvas.Children.Add(controlCurve);
            canvas.Children.Add(deleteControl);
            Canvas.SetZIndex(controlCurve, -1);
            Canvas.SetZIndex(deleteControl, -1);
        }

        void OnDelete(object sender, MouseButtonEventArgs e)
        {
            Delete();
        }

        public void Delete()
        {
            parentCanvas.Children.Remove(controlCurve);
            parentCanvas.Children.Remove(deleteControl);
            parentManager.links.Remove(this);
        }

        public KeyValuePair<int,int> GetLink()
        {
            return new KeyValuePair<int, int>(connected[0].ID, connected[1].ID);
        }
    }
}
