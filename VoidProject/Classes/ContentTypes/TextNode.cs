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
    public class TextNode : NodeContent
    {
        public string text;
        public TextBox box;

        public TextNode() : base() 
        {
            contentType = "TextNode";

            box = new TextBox
            {
                Text = text,
                AcceptsReturn = true,
                AcceptsTab = true,

                Height = 80,
                MaxHeight = 120,
                Background = (Brush)Resources.FindName("TransperentControl"),
                Foreground = Brushes.AliceBlue
            };

            box.TextChanged += OnTextChanged;

            panel.Children.Add(box);
        }

        void OnTextChanged(object sender, TextChangedEventArgs e) 
        {
            text = box.Text;
        }

        public override NodeInfo Getinfo()
        {
            NodeInfo info = base.Getinfo();
            info.props = new string[] { text};
            return info;
        }

    }
}
