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

namespace VoidNull
{
    public static class NodeEventHelper
    {
        public static NodeManager activeManager;
        public static double hardness = 50;

        public static void OnEditorMove(object sender, MouseEventArgs e)
        {
            if (activeManager.state == ManagerState.connecting)
            {
                activeManager.curve.Data = BezierGeometry(activeManager.active.control.outPoint, Mouse.GetPosition(activeManager.canvas), hardness);
                activeManager.window.canvas.Refresh();
            }
            if (activeManager.state == ManagerState.scrolling)
            {
                activeManager.window.editorView.ScrollToHorizontalOffset(activeManager.scrollPosX + (activeManager.mouseDownPosX - e.GetPosition(activeManager.window).X));
                activeManager.window.editorView.ScrollToVerticalOffset(activeManager.scrollPosY + (activeManager.mouseDownPosY - e.GetPosition(activeManager.window).Y));
            }

        }

        public static void OnEditorDown(object sender, MouseButtonEventArgs e)
        {

            if (Mouse.DirectlyOver == activeManager.canvas)
            {
                if (activeManager.state == ManagerState.connecting)
                {
                    activeManager.state = ManagerState.normal;
                    activeManager.active = null;
                    activeManager.canvas.Children.Remove(activeManager.curve);
                    activeManager.canvas.Refresh();
                }

                if (activeManager.state == ManagerState.normal)
                {
                    activeManager.state = ManagerState.scrolling;
                    activeManager.mouseDownPosX = e.GetPosition(activeManager.window).X;
                    activeManager.mouseDownPosY = e.GetPosition(activeManager.window).Y;
                    activeManager.scrollPosX = activeManager.window.editorView.HorizontalOffset;
                    activeManager.scrollPosY = activeManager.window.editorView.VerticalOffset;
                }
            }


        }

        public static void OnEditorUp(object sender, MouseButtonEventArgs e)
        {
            if (activeManager.state == ManagerState.scrolling)
            {
                activeManager.state = ManagerState.normal;
            }
            else if (activeManager.state == ManagerState.dragging)
            {
                activeManager.state = ManagerState.normal;
                activeManager.active = null;
                activeManager.canvas.Children.Remove(activeManager.curve);
                activeManager.canvas.Refresh();
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
