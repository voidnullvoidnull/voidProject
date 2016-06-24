using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidNull { 

/// <summary>
/// Структура единицы хранения данных о конктерном ноде.
/// Сохраняется уникальный идентификатор, тип содержимого, который будет восстанавливаться при десериализации,
/// координаты и массив props, который служит для хранения информации уникальной для каждого созданного contentType.
/// Props будут обрабатываться отдельно в зависимости от контекста и типа содержимого.
/// </summary>

    [Serializable]
    public struct NodeInfo
    {
        public int ID;
        public string contentType;
        public double posX;
        public double posY;
        public string[] props;
    }
}
