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

namespace VoidProject.Controls
{
    public partial class NodeControl : UserControl
    {
        public NodeControl()
        {
            InitializeComponent();
        }

        public Node node;
        bool isDrag = false;

        double offsetX = 0;
        double offsetY = 0;


        public Point Position
        {
            get { return node.pos;}

            set
            {
                Canvas.SetLeft(this, value.X);
                Canvas.SetTop(this, value.Y);
                node.pos = value;
            }
        }

        private void Select(object sender, MouseButtonEventArgs e)
        {
            idLabel.Content = "ID: " + node.ID.ToString();
            node.parentManager.Select(node);

            Mouse.Capture(this);
            offsetX = e.GetPosition(this).X;
            offsetY = e.GetPosition(this).Y;
            isDrag = true;
        }

        private void Leave(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);
            isDrag = false;
        }

        private void Move(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point pos = new Point(e.GetPosition(node.parentCanvas).X - offsetX, e.GetPosition(node.parentCanvas).Y - offsetY);
                Position = pos;
                node.parentCanvas.Refresh();
            }
        }

        private void delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            node.parentManager.DeleteNode(node);
        }
    }
}
