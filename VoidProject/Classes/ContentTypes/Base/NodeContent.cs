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
/// Базовый класс для всех элементов управления и содержимого нодов.
/// Все элементы управления и контент помещаются в контейнер panel : StackPanel, где автоматически выравнивается. 
/// Однако, никто не запрещает реализовывать свои контейнеры.
/// Переопределяя метод GetInfo нужно в переопределямом методе сохранять значения из базовой реалзации,
/// так как они содержат в себе координаты, тип и уникальный ID.
/// Соотвественно, конструктор реализующего класса также должен вызывать базовый перед вызовом своего.
/// </summary>

    public abstract class NodeContent : UserControl 
    {
        public string contentType;
        public Node node;
        public NodeManager manager;
        public StackPanel panel;


        public NodeContent()
        {
            panel = new StackPanel();
            Content = panel;
        }

        public virtual NodeInfo Getinfo()
        {
            return new NodeInfo
            {
                ID = node.ID,
                contentType = contentType,
                posX = node.position.X,
                posY = node.position.Y,
            };
        }

    }
}
