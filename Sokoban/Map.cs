using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Map
    {
        public int[,] map = new int[11, 11];
        public int x, y;
        public List<Point> li = new List<Point>();
        public int Can_A()
        {
            if(map[x,y]==1)
            {
                if (map[x, y - 1] == 0)
                    return 1;
                if (map[x, y - 1] == 2&&map[x,y-2]==0)
                    return 2;
                if (map[x, y - 1] == 2 && map[x, y - 2] == 3)
                    return 3;
                if (map[x, y - 1] == 3)
                    return 4;
                if (map[x, y - 1] == 5 && map[x, y - 2] == 0)
                    return 5;
                if (map[x, y - 1] == 5 && map[x, y - 2] == 3)
                    return 6;
            }
            else
            {
                if (map[x, y - 1] == 0)
                    return 7;
                if (map[x, y - 1] == 2 && map[x, y - 2] == 0)
                    return 8;
                if (map[x, y - 1] == 2 && map[x, y - 2] == 3)
                    return 9;
                if (map[x, y - 1] == 3)
                    return 10;
                if (map[x, y - 1] == 5 && map[x, y - 2] == 0)
                    return 11;
                if (map[x, y - 1] == 5 && map[x, y - 2] == 3)
                    return 12;
            }
            return 0;
        }
        public void A_Move(int flag)
        {
            if (flag != 0)
            {
                switch (flag)
                {
                    case 1:
                        map[x, y] = 0;
                        map[x, y - 1] = 1;
                        break;
                    case 2:
                        map[x, y] = 0;
                        map[x, y - 1] = 1;
                        map[x, y - 2] = 2;
                        break;
                    case 3:
                        map[x, y] = 0;
                        map[x, y - 1] = 1;
                        map[x, y - 2] = 5;
                        break;
                    case 4:
                        map[x, y] = 0;
                        map[x, y - 1] = 6;
                        break;
                    case 5:
                        map[x, y] = 0;
                        map[x, y - 1] = 6;
                        map[x, y - 2] = 2;
                        break;
                    case 6:
                        map[x, y] = 0;
                        map[x, y - 1] = 6;
                        map[x, y - 2] = 5;
                        break;
                    case 7:
                        map[x, y] = 3;
                        map[x, y - 1] = 1;
                        break;
                    case 8:
                        map[x, y] = 3;
                        map[x, y - 1] = 1;
                        map[x, y - 2] = 2;
                        break;
                    case 9:
                        map[x, y] = 3;
                        map[x, y - 1] = 1;
                        map[x, y - 2] = 5;
                        break;
                    case 10:
                        map[x, y] = 3;
                        map[x, y - 1] = 6;
                        break;
                    case 11:
                        map[x, y] = 3;
                        map[x, y - 1] = 6;
                        map[x, y - 2] = 2;
                        break;
                    case 12:
                        map[x, y] = 3;
                        map[x, y - 1] = 6;
                        map[x, y - 2] = 5;
                        break;
                }
                y--;
            }
        }
        public int Can_D()
        {
            if (map[x, y] == 1)
            {
                if (map[x, y + 1] == 0)
                    return 1;
                if (map[x, y + 1] == 2 && map[x, y + 2] == 0)
                    return 2;
                if (map[x, y + 1] == 2 && map[x, y + 2] == 3)
                    return 3;
                if (map[x, y + 1] == 3)
                    return 4;
                if (map[x, y + 1] == 5 && map[x, y + 2] == 0)
                    return 5;
                if (map[x, y + 1] == 5 && map[x, y + 2] == 3)
                    return 6;
            }
            else
            {
                if (map[x, y + 1] == 0)
                    return 7;
                if (map[x, y + 1] == 2 && map[x, y + 2] == 0)
                    return 8;
                if (map[x, y + 1] == 2 && map[x, y + 2] == 3)
                    return 9;
                if (map[x, y + 1] == 3)
                    return 10;
                if (map[x, y + 1] == 5 && map[x, y + 2] == 0)
                    return 11;
                if (map[x, y + 1] == 5 && map[x, y + 2] == 3)
                    return 12;
            }
            return 0;
        }
        public void D_Move(int flag)
        {
            if (flag != 0)
            {
                switch (flag)
                {
                    case 1:
                        map[x, y] = 0;
                        map[x, y + 1] = 1;
                        break;
                    case 2:
                        map[x, y] = 0;
                        map[x, y + 1] = 1;
                        map[x, y + 2] = 2;
                        break;
                    case 3:
                        map[x, y] = 0;
                        map[x, y + 1] = 1;
                        map[x, y + 2] = 5;
                        break;
                    case 4:
                        map[x, y] = 0;
                        map[x, y + 1] = 6;
                        break;
                    case 5:
                        map[x, y] = 0;
                        map[x, y + 1] = 6;
                        map[x, y + 2] = 2;
                        break;
                    case 6:
                        map[x, y] = 0;
                        map[x, y + 1] = 6;
                        map[x, y + 2] = 5;
                        break;
                    case 7:
                        map[x, y] = 3;
                        map[x, y + 1] = 1;
                        break;
                    case 8:
                        map[x, y] = 3;
                        map[x, y + 1] = 1;
                        map[x, y + 2] = 2;
                        break;
                    case 9:
                        map[x, y] = 3;
                        map[x, y + 1] = 1;
                        map[x, y + 2] = 5;
                        break;
                    case 10:
                        map[x, y] = 3;
                        map[x, y + 1] = 6;
                        break;
                    case 11:
                        map[x, y] = 3;
                        map[x, y + 1] = 6;
                        map[x, y + 2] = 2;
                        break;
                    case 12:
                        map[x, y] = 3;
                        map[x, y + 1] = 6;
                        map[x, y + 2] = 5;
                        break;
                }
                y++;
            }
        }
        public int Can_W()
        {
            if (map[x, y] == 1)
            {
                if (map[x-1, y] == 0)
                    return 1;
                if (map[x-1, y] == 2 && map[x-2, y] == 0)
                    return 2;
                if (map[x-1, y ] == 2 && map[x-2, y] == 3)
                    return 3;
                if (map[x-1, y ] == 3)
                    return 4;
                if (map[x-1, y ] == 5 && map[x-2, y ] == 0)
                    return 5;
                if (map[x-1, y ] == 5 && map[x-2, y ] == 3)
                    return 6;
            }
            else
            {
                if (map[x-1, y ] == 0)
                    return 7;
                if (map[x-1, y ] == 2 && map[x-2, y] == 0)
                    return 8;
                if (map[x-1, y ] == 2 && map[x-2, y ] == 3)
                    return 9;
                if (map[x-1, y ] == 3)
                    return 10;
                if (map[x-1, y] == 5 && map[x-2, y] == 0)
                    return 11;
                if (map[x-1, y ] == 5 && map[x-2, y] == 3)
                    return 12;
            }
            return 0;
        }
        public void W_Move(int flag)
        {
            if (flag != 0)
            {
                switch (flag)
                {
                    case 1:
                        map[x, y] = 0;
                        map[x - 1, y] = 1;
                        break;
                    case 2:
                        map[x, y] = 0;
                        map[x - 1, y] = 1;
                        map[x - 2, y] = 2;
                        break;
                    case 3:
                        map[x, y] = 0;
                        map[x - 1, y] = 1;
                        map[x - 2, y] = 5;
                        break;
                    case 4:
                        map[x, y] = 0;
                        map[x - 1, y] = 6;
                        break;
                    case 5:
                        map[x, y] = 0;
                        map[x - 1, y] = 6;
                        map[x - 2, y] = 2;
                        break;
                    case 6:
                        map[x, y] = 0;
                        map[x - 1, y] = 6;
                        map[x - 2, y] = 5;
                        break;
                    case 7:
                        map[x, y] = 3;
                        map[x - 1, y] = 1;
                        break;
                    case 8:
                        map[x, y] = 3;
                        map[x - 1, y] = 1;
                        map[x - 2, y] = 2;
                        break;
                    case 9:
                        map[x, y] = 3;
                        map[x - 1, y] = 1;
                        map[x - 2, y] = 5;
                        break;
                    case 10:
                        map[x, y] = 3;
                        map[x - 1, y] = 6;
                        break;
                    case 11:
                        map[x, y] = 3;
                        map[x - 1, y] = 6;
                        map[x - 2, y] = 2;
                        break;
                    case 12:
                        map[x, y] = 3;
                        map[x - 1, y] = 6;
                        map[x - 2, y] = 5;
                        break;
                }
                x--;
            }
        }
        public int Can_S()
        {
            if (map[x, y] == 1)
            {
                if (map[x + 1, y] == 0)
                    return 1;
                if (map[x + 1, y] == 2 && map[x + 2, y] == 0)
                    return 2;
                if (map[x + 1, y] == 2 && map[x + 2, y] == 3)
                    return 3;
                if (map[x + 1, y] == 3)
                    return 4;
                if (map[x + 1, y] == 5 && map[x + 2, y] == 0)
                    return 5;
                if (map[x + 1, y] == 5 && map[x + 2, y] == 3)
                    return 6;
            }
            else
            {
                if (map[x + 1, y] == 0)
                    return 7;
                if (map[x + 1, y] == 2 && map[x + 2, y] == 0)
                    return 8;
                if (map[x + 1, y] == 2 && map[x + 2, y] == 3)
                    return 9;
                if (map[x + 1, y] == 3)
                    return 10;
                if (map[x + 1, y] == 5 && map[x + 2, y] == 0)
                    return 11;
                if (map[x + 1, y] == 5 && map[x + 2, y] == 3)
                    return 12;
            }
            return 0;
        }
        public void S_Move(int flag)
        {
            if (flag != 0)
            {
                switch (flag)
                {
                    case 1:
                        map[x, y] = 0;
                        map[x + 1, y] = 1;
                        break;
                    case 2:
                        map[x, y] = 0;
                        map[x + 1, y] = 1;
                        map[x + 2, y] = 2;
                        break;
                    case 3:
                        map[x, y] = 0;
                        map[x + 1, y] = 1;
                        map[x + 2, y] = 5;
                        break;
                    case 4:
                        map[x, y] = 0;
                        map[x + 1, y] = 6;
                        break;
                    case 5:
                        map[x, y] = 0;
                        map[x + 1, y] = 6;
                        map[x + 2, y] = 2;
                        break;
                    case 6:
                        map[x, y] = 0;
                        map[x + 1, y] = 6;
                        map[x + 2, y] = 5;
                        break;
                    case 7:
                        map[x, y] = 3;
                        map[x + 1, y] = 1;
                        break;
                    case 8:
                        map[x, y] = 3;
                        map[x + 1, y] = 1;
                        map[x + 2, y] = 2;
                        break;
                    case 9:
                        map[x, y] = 3;
                        map[x + 1, y] = 1;
                        map[x + 2, y] = 5;
                        break;
                    case 10:
                        map[x, y] = 3;
                        map[x + 1, y] = 6;
                        break;
                    case 11:
                        map[x, y] = 3;
                        map[x + 1, y] = 6;
                        map[x + 2, y] = 2;
                        break;
                    case 12:
                        map[x, y] = 3;
                        map[x + 1, y] = 6;
                        map[x + 2, y] = 5;
                        break;
                }
                x++;
            }
        }
    }
}
