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

namespace VoidProject
{
    /// <summary>
    /// Main class for visual node editor. Rntry point
    /// </summary>
    public partial class MainWindow : Window
    {
        public NodeManager manager = new NodeManager();

        public MainWindow()
        {
            InitializeComponent();
            manager.canvas = canvas;
            manager.window = this;
        }

        private void addBut_Click(object sender, RoutedEventArgs e)
        {
            manager.AddNode();
        }


    }
}
