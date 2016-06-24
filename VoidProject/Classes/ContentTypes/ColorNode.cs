using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using VoidNull.Controls;

namespace VoidNull
{
    public class ColorNode : NodeContent
    {
        Button but;

        public ColorNode() : base() 
        {
            contentType = "ColorNode";
            but = new Button();
            
            panel.Children.Add(but);
        }

    }
}
