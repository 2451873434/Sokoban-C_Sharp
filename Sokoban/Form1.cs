using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class Form1 : Form
    {
        List<int[,]> M = new List<int[,]>();
        Map m = new Map_1();
        int r = 5;
        int flag;
        int is_win=1;
        public Form1()
        {
            InitializeComponent();
        }
        public void Add_Map(Map m_creat)
        {
            comboBox1.Items.Add((comboBox1.Items.Count + 1).ToString());
            M.Add(m_creat.map);
            m.x = m_creat.x;
            m.y = m_creat.y;
            m.li = m_creat.li;
        }
        public void Paints(int i,int j)
        {
            Graphics g = this.CreateGraphics();
            if (m.map[i, j] == 0)
                g.FillRectangle(new SolidBrush(Color.White), j * 30, i * 30, 29, 29);
            if (m.map[i, j] == 1)
                g.FillEllipse(new SolidBrush(Color.Blue), j * 30, i * 30, 29, 29);
            if (m.map[i, j] == 2)
                g.FillRectangle(new SolidBrush(Color.Green), j * 30, i * 30, 29, 29);
            if (m.map[i, j] == 3)
                g.DrawRectangle(Pens.Red, j * 30, i * 30, 29, 29);
            if (m.map[i, j] == 4)
                g.FillRectangle(new SolidBrush(Color.Black), j * 30, i * 30, 29, 29);
            if (m.map[i, j] == 5)
                g.FillRectangle(new SolidBrush(Color.Red), j * 30, i * 30, 29, 29);
            if (m.map[i, j] == 6)
            {
                g.FillEllipse(new SolidBrush(Color.Blue), j * 30, i * 30, 29, 29);
                g.DrawRectangle(Pens.Red, j * 30, i * 30, 29, 29);
            }
        }
        public void Paints_A()
        {
            Graphics g = this.CreateGraphics();
            for(int j=m.y+1;j>m.y-2;j--)
            {
                Paints(m.x, j);
            }
        }
        public void Paints_D()
        {
            Graphics g = this.CreateGraphics();
            for (int j = m.y-1; j < m.y + 2; j++)
            {
                Paints(m.x, j);
            }
        }
        public void Paints_W()
        {
            Graphics g = this.CreateGraphics();
            for (int i = m.x+1; i > m.x - 2; i--)
            {
                Paints(i,m.y);
            }
        }
        public void Paints_S()
        {
            Graphics g = this.CreateGraphics();
            for (int i = m.x-1; i < m.x + 2; i++)
            {
                Paints(i, m.y);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m.map = M[int.Parse(comboBox1.Text)-1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            is_win = 1;
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            for (int i = 0; i < m.map.GetLength(0); i++)
            {
                for (int j = 0; j < m.map.GetLength(1); j++)
                {
                    Paints(i, j);
                }
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            is_win = 1;
            Graphics g = this.CreateGraphics();
            switch (e.KeyChar)
            {
                case 'w':
                case 'W':
                    flag = m.Can_W();
                    if (flag != 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.White), m.y * 30, (m.x - 2) * 30, 30, 90);
                        m.W_Move(flag);
                        Paints_W();
                    }
                    break;
                case 's':
                case 'S':
                    flag = m.Can_S();
                    if (flag != 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.White), m.y * 30, m.x * 30, 30, 90);
                        m.S_Move(flag);
                        Paints_S();
                    }
                    break;
                case 'a':
                case 'A':
                    flag = m.Can_A();
                    if (flag != 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.White), (m.y - 2) * 30, m.x * 30, 90, 30);
                        m.A_Move(flag);
                        Paints_A();
                    }
                    break;
                case 'd':
                case 'D':
                    flag = m.Can_D();
                    if (flag != 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.White), m.y * 30, m.x * 30, 90, 30);
                        m.D_Move(flag);
                        Paints_D();
                    }
                    break;
            }
            for(int i=0;i<m.li.Count;i++)
            {
                if (m.map[m.li[i].X, m.li[i].Y] != 5)
                    is_win = 0;
            }
            if(is_win==1)
            {
                MessageBox.Show("You Win!!!", "congratulate");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2= Form2.CreatForm2_OnlyOne(Add_Map);
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] map_1 =
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
            M.Add(map_1);
        }
    }
}
