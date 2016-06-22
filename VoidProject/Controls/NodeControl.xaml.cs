using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VoidProject;

namespace VoidProject.Controls
{
    public partial class NodeControl : UserControl
    {
        public NodeControl()
        {
            InitializeComponent();
        }

        public Node node;
        bool isDragging = false;

        double offsetX = 0;
        double offsetY = 0;

        public Point outPoint
        {
            get
            {
                return new Point(position.X + Canvas.GetLeft(output) +10, position.Y + Canvas.GetTop(output) + 10 );
            }
        }

        public Point inPoint
        {
            get
            {
                return new Point(position.X + Canvas.GetLeft(input) + 10, position.Y + Canvas.GetTop(input) + 10);
            }
        }

        public Point position
        {
            get { return node.position;}

            set
            {
                Canvas.SetLeft(this, value.X);
                Canvas.SetTop(this, value.Y);
                node.position = value;
            }
        }

        public void Refresh()
        {
            foreach (NodeLink link in node.parentManager.links)
            {
                if (link.connected.Contains(node))
                {
                    link.controlCurve.Data = NodeManager.BezierGeometry(link.connected[0].control.outPoint, link.connected[1].control.inPoint, 50);
                    Canvas.SetLeft(link.deleteControl, ((link.connected[0].control.outPoint.X + link.connected[1].control.inPoint.X) / 2) - 10);
                    Canvas.SetTop(link.deleteControl, ((link.connected[0].control.outPoint.Y + link.connected[1].control.inPoint.Y) / 2) - 10);
                }
            }
            node.parentManager.canvas.Refresh();
        }

        void Select(object sender, MouseButtonEventArgs e)
        {
            if (node.parentManager.state == ManagerState.normal)
            {
                node.parentManager.Select(node);

                Mouse.Capture(this);
                offsetX = e.GetPosition(this).X;
                offsetY = e.GetPosition(this).Y;
                isDragging = true;
            }
        }

        void Leave(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);
            isDragging = false;
        }

        void Move(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                position = new Point(e.GetPosition(node.parentCanvas).X - offsetX, e.GetPosition(node.parentCanvas).Y - offsetY);
                Refresh();                
            }
        }

        void delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            node.parentManager.DeleteNode(node);
        }

        void output_MouseDown(object sender, MouseButtonEventArgs e)
        {
            node.parentManager.StartConnection(node);
        }

        void input_MouseDown(object sender, MouseButtonEventArgs e)
        {
            node.parentManager.EndConnection(node);
        }

        void control_Loaded(object sender, RoutedEventArgs e)
        {
            position = node.position;
            content.Content = node.content;
        }
    }
}
