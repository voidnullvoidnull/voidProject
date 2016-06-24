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
    /// <summary>
    /// Базовый класс - единица хранения данных о ноде.
    /// Содержит в себе ссылки, унаследованные от базового класса на менеджер и canvas, 
    /// в котором должен быть размещен отображаемый элемент упарвления, который значится под ссылкой - control.
    /// В свою очередь, видимый эелемент управления должен содержать в себе уникальный для типа нодов набор элементов управления,
    /// на которые указывает ссылка - content - на объект, реализующий абстрактный класс NodeContent.
    /// </summary>
 
    public class Node : NodeBase
    {
        public int ID = 0;
        
        public NodeControl control;

        public NodeContent content;

        public Point position;

        public Node (Canvas canvas, NodeManager manager, int id)
        {
            ID = id;
            base.canvas = canvas;
            base.manager = manager;
            
            control = new NodeControl();
            control.node = this;
            base.canvas.Children.Add(control);
        }

        public void CreateContent<T>() where T : NodeContent, new()
        {
            content = new T(); 
            content.manager = manager;
            content.node = this;
            control.content.Content = content;
        }
    }
}
