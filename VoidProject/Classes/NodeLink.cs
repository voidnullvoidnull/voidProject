﻿using System;
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

/// <summary>
/// Класс реализующий и хранящий в себе данные о соединенных нодах. 
/// Также, хранит ссылку на визуальное представление соединения в виде кривой Безье, которая помещается в Canvas рабочего поля.
/// </summary>
    public class NodeLink: NodeBase
    {
        public Node[] connected = new Node[2];

        public Path controlCurve;

        public Ellipse deleteControl;

        public NodeLink(Node from, Node to, NodeManager manager, Canvas canvas)
        {
            connected[0] = from;
            connected[1] = to;
            base.manager = manager;
            base.canvas = canvas;

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
            canvas.Children.Remove(controlCurve);
            canvas.Children.Remove(deleteControl);
            manager.links.Remove(this);
        }

        public KeyValuePair<int,int> GetLink()
        {
            return new KeyValuePair<int, int>(connected[0].ID, connected[1].ID);
        }
    }
}
