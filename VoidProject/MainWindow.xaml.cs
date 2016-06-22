using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VoidProject
{
    public partial class MainWindow : Window
    {
        public NodeManager manager = new NodeManager();

        public MainWindow()
        {
            InitializeComponent();
            manager.canvas = canvas;
            manager.window = this;
            manager.curve.Stroke = Brushes.AliceBlue;
            manager.curve.StrokeThickness = 2;
            manager.curve.IsHitTestVisible = false;

            canvas.MouseMove += manager.OnMouseMove;
            canvas.MouseDown += manager.OnMouseDown;
            canvas.MouseUp += manager.OnMouseUp;
        }

        private void addBut_Click(object sender, RoutedEventArgs e)
        {
            manager.AddNode();
        }

        private void saveBut_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void openBut_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }


        void Save()
        {
            JsonSerializer js = new JsonSerializer();
            TextWriter tw =  File.CreateText("data.json");

            ModelInfo info = new ModelInfo();
            info.links = new List<KeyValuePair<int, int>>();
            info.nodes = new Dictionary<int, NodeInfo>();

            foreach(NodeLink link in manager.links)
            {
                info.Addlink(link.GetLink());
            }
            foreach(Node node in manager.nodes.Values)
            {
                info.AddNodeInfo(node.content.Getinfo());
            }

            js.Formatting = Formatting.Indented;
            js.Serialize(tw, info, typeof(ModelInfo));
            tw.Dispose();
        }

        void Load()
        {
            JsonSerializer js = new JsonSerializer();
            TextReader tr = File.OpenText("data.json");
            ModelInfo info = (ModelInfo)js.Deserialize(tr, typeof(ModelInfo));

            foreach (NodeInfo n in info.nodes.Values)
            {
                Node node = manager.AddNode();
                node.content.nodeText = n.text;
                node.content.SetInfo(n);
                node.position = new Point(n.posX, n.posY);
                node.ID = n.ID;
            }

            foreach (KeyValuePair<int, int> link in info.links)
            {
                manager.LinkCreate(manager.nodes[link.Key], manager.nodes[link.Value]);
            }

            foreach (Node node in manager.nodes.Values)
            {
                node.control.Refresh();
            }
            tr.Dispose();
        }

    }
}
