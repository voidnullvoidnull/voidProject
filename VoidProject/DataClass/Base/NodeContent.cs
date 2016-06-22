﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using VoidProject.Controls;

namespace VoidProject
{
    public class NodeContent : UserControl 
    {
        public StackPanel panel;
        public Node parentNode;
        public NodeManager parentManager;
        public string nodeText = "empty";

        public NodeContent(Node parent, NodeManager manager)
        {
            parentNode = parent;
            parentManager = manager;
            panel = new StackPanel();
            TextBox box = new TextBox { Height = 50, Text = nodeText };
            box.TextChanged += Box_TextChanged;
            panel.Children.Add(box);
            Content = panel;
        }

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            nodeText = ((TextBox)sender).Text;
        }

        public virtual NodeInfo Getinfo()
        {
            return new NodeInfo
            {
                ID = parentNode.ID,
                contentType = "NodeContent",
                posX = parentNode.position.X, posY = parentNode.position.Y,
                text = nodeText
            };
        }

        public virtual void SetInfo(NodeInfo info)
        {
            nodeText = info.text;
            ((TextBox)panel.Children[0]).Text = info.text;
        }


    }
}
