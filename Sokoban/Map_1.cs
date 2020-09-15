using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Map_1:Map
    {
        private int[,] map_1 =
            {
            {0,0,0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,4,4,4,0,0,0,0 },
            {0,0,0,0,4,3,4,0,0,0,0 },
            {0,0,0,0,4,0,4,0,0,0,0 },
            {0,4,4,4,4,2,4,4,4,4,0 },
            {0,4,3,0,2,1,2,0,3,4,0 },
            {0,4,4,4,4,2,4,4,4,4,0 },
            {0,0,0,0,4,0,4,0,0,0,0 },
            {0,0,0,0,4,3,4,0,0,0,0 },
            {0,0,0,0,4,4,4,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0,0,0 }
            };
        public Map_1()
        {
            map = map_1;
            x = 5;
            y = 5;
            //Point p = new Point(0,1);
            li.Add(new Point(2, 5));
            li.Add(new Point(5, 2));
            li.Add(new Point(8, 5));
            li.Add(new Point(5, 8));
        }
    }
}
