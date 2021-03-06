﻿using System;
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
namespace VoidNull
{
    /// <summary>
    /// Базовый абстрактный класс для элементов, которые могут взаимодействовать в рамках методов NodeManager. 
    /// Реализует хранение ссылок на текущий Canvas отображения и NodeManager, 
    /// в котором производятся операции над объектом, реализующий данный класс
    /// </summary>
    
    public abstract class NodeBase
    {
        public Canvas canvas;
        public NodeManager manager;
    }
}
