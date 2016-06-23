using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VoidNull
{
    public partial class MainWindow : Window
    {
        public NodeManager manager = new NodeManager();
        public NodeModelInfo info = new NodeModelInfo();

        public MainWindow()
        {
            InitializeComponent();
            manager.canvas = canvas;
            manager.window = this;
            manager.curve.Stroke = Brushes.AliceBlue;
            manager.curve.StrokeThickness = 2;
            manager.curve.IsHitTestVisible = false;
            NodeEventHelper.activeManager = manager;

            canvas.MouseMove += NodeEventHelper.OnEditorMove;
            canvas.MouseDown += NodeEventHelper.OnEditorDown;
            canvas.MouseUp += NodeEventHelper.OnEditorUp;

            CommandBinding newNodeBinding = new CommandBinding(ApplicationCommands.New);
            CommandBinding saveBinding = new CommandBinding(ApplicationCommands.Save);
            CommandBinding clearbinding = new CommandBinding(ApplicationCommands.Delete);

            saveBinding.Executed += SaveBinding_Executed;
            saveBinding.CanExecute += SaveBinding_CanExecute;
            newNodeBinding.Executed += NewNodeBinding_Executed;
            clearbinding.Executed += Clearbinding_Executed;
            
        }

        private void SaveBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
          e.CanExecute = true;
        }

        private void Clearbinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = true;
            Clear();
        }

        private void SaveBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Save();
        }

        private void NewNodeBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            manager.AddNode();
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

        void Clear()
        {
            manager = new NodeManager();
            manager.canvas = canvas;
            manager.window = this;
            manager.curve.Stroke = Brushes.AliceBlue;
            manager.curve.StrokeThickness = 2;
            manager.curve.IsHitTestVisible = false;

            canvas.Children.Clear();
            canvas.Refresh();
        }

        void Save()
        {
            info = new NodeModelInfo();
            info.count = manager.count;
            info.links = new List<KeyValuePair<int, int>>();
            info.nodes = new Dictionary<int, NodeInfo>();

            foreach (NodeLink link in manager.links)
            {
                info.Addlink(link.GetLink());
            }
            foreach (Node node in manager.nodes.Values)
            {
                info.AddNodeInfo(node.content.Getinfo());
            }

            using (TextWriter tw = File.CreateText("data.json"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Formatting = Formatting.Indented;
                js.Serialize(tw, info, typeof(NodeModelInfo));
            }
        }

        void Load()
        {

            Clear();

            using (TextReader tr = File.OpenText("data.json"))
            {
                JsonSerializer js = new JsonSerializer();
                info = (NodeModelInfo)js.Deserialize(tr, typeof(NodeModelInfo));
                manager.count = info.count+1;
            }

            foreach (NodeInfo n in info.nodes.Values)
            {
                manager.LoadNode(n);
            }

            foreach (KeyValuePair<int, int> link in info.links)
            {
               manager.LinkCreate(manager.nodes[link.Key], manager.nodes[link.Value]);
            }
            foreach(Node node in manager.nodes.Values)
            {
                node.control.Refresh();
            }
        }

    }
}
