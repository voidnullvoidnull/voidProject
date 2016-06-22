using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidProject { 

    [Serializable]
    public struct NodeInfo
    {
        public int ID;
        public string contentType;
        public double posX;
        public double posY;
        public string text;
        public string[] props;
    }
}
