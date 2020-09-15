using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public delegate void Del_Creat_Map(Map m_creat);
    public partial class Form2 : Form
    {
        public static Del_Creat_Map del;
        Map m = new Map();
        static Form2 f2;
        int button;
        int x, y;
        public Form2()
        {
            InitializeComponent();
        }
        public static Form2 CreatForm2_OnlyOne(Del_Creat_Map dell)
        {
            del = dell;
            if (f2 == null)
                f2 = new Form2();
            return f2;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            button = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button = 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button = 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button = 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m.map.GetLength(0); i++)
            {
                for (int j = 0; j < m.map.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == m.map.GetLength(0) - 1 || j == m.map.GetLength(1) - 1)
                        m.map[i, j] = 4;
                    if (m.map[i, j] == 5 || m.map[i, j] == 3)
                        m.li.Add(new Point(i, j));
                }
            }
            del(m);
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            for (int i = 0; i < m.map.GetLength(0); i++)
            {
                for (int j = 0; j < m.map.GetLength(1); j++)
                {
                    g.FillRectangle(new SolidBrush(Color.White), j * 30, i * 30, 29, 29);
                }
            }
            g.FillRectangle(new SolidBrush(Color.Yellow), 0, 0, 330, 30);
            g.FillRectangle(new SolidBrush(Color.Yellow), 0, 0, 30, 330);
            g.FillRectangle(new SolidBrush(Color.Yellow), 300, 0, 30, 330);
            g.FillRectangle(new SolidBrush(Color.Yellow), 0, 300, 330, 30);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X < 300 && e.Y < 300 && e.X > 30 && e.Y > 30)
            {
                Graphics g = this.CreateGraphics();
                switch (button)
                {
                    case 0:
                        m.map[e.Y / 30, e.X / 30] = 1;
                        g.FillRectangle(new SolidBrush(Color.White), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        break;
                    case 2:
                        if (m.map[e.Y / 30, e.X / 30] == 0)
                        {
                            m.map[e.Y / 30, e.X / 30] = 2;
                            g.FillRectangle(new SolidBrush(Color.Green), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        }
                        else if (m.map[e.Y / 30, e.X / 30] == 3)
                        {
                            m.map[e.Y / 30, e.X / 30] = 5;
                            g.FillRectangle(new SolidBrush(Color.Red), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        }
                        break;
                    case 3:
                        if (m.map[e.Y / 30, e.X / 30] == 0)
                        {
                            m.map[e.Y / 30, e.X / 30] = 3;
                            g.DrawRectangle(Pens.Red, e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        }
                        else if (m.map[e.Y / 30, e.X / 30] == 2)
                        {
                            m.map[e.Y / 30, e.X / 30] = 5;
                            g.FillRectangle(new SolidBrush(Color.Red), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        }
                        else if (m.map[e.Y / 30, e.X / 30] == 1)
                        {
                            m.map[e.Y / 30, e.X / 30] = 6;
                            g.DrawRectangle(Pens.Red, e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            g.FillEllipse(new SolidBrush(Color.Blue), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        }
                        break;
                    case 4:
                        m.map[e.Y / 30, e.X / 30] = 4;
                        g.FillRectangle(new SolidBrush(Color.Black), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                        break;
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (e.X < 300 && e.Y < 300 && e.X > 30 && e.Y > 30)
                {
                    Graphics g = this.CreateGraphics();
                    switch (button)
                    {
                        case 0:
                            m.map[e.Y / 30, e.X / 30] = 1;
                            g.FillRectangle(new SolidBrush(Color.White), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            break;
                        case 2:
                            if (m.map[e.Y / 30, e.X / 30] == 0)
                            {
                                m.map[e.Y / 30, e.X / 30] = 2;
                                g.FillRectangle(new SolidBrush(Color.Green), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            }
                            else if (m.map[e.Y / 30, e.X / 30] == 3)
                            {
                                m.map[e.Y / 30, e.X / 30] = 5;
                                g.FillRectangle(new SolidBrush(Color.Red), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            }
                            break;
                        case 3:
                            if (m.map[e.Y / 30, e.X / 30] == 0)
                            {
                                m.map[e.Y / 30, e.X / 30] = 3;
                                g.DrawRectangle(Pens.Red, e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            }
                            else if (m.map[e.Y / 30, e.X / 30] == 2)
                            {
                                m.map[e.Y / 30, e.X / 30] = 5;
                                g.FillRectangle(new SolidBrush(Color.Red), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            }
                            else if (m.map[e.Y / 30, e.X / 30] == 1)
                            {
                                m.map[e.Y / 30, e.X / 30] = 6;
                                g.DrawRectangle(Pens.Red, e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                                g.FillEllipse(new SolidBrush(Color.Blue), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            }
                            break;
                        case 4:
                            m.map[e.Y / 30, e.X / 30] = 4;
                            g.FillRectangle(new SolidBrush(Color.Black), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                            break;
                    }
                }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (button == 1 && e.X < 300 && e.Y < 300 && e.X > 30 && e.Y > 30)
            {
                m.y = e.X / 30;
                m.x = e.Y / 30;
                Graphics g = this.CreateGraphics();
                if (m.map[x, y] == 1)
                {
                    m.map[x, y] = 0;
                    g.FillRectangle(new SolidBrush(Color.White), y * 30, x * 30, 29, 29);
                }
                else if (m.map[x, y] == 6)
                {
                    m.map[x, y] = 3;
                    g.FillRectangle(new SolidBrush(Color.White), y * 30, x * 30, 29, 29);
                    g.DrawRectangle(Pens.Red, y * 30, x * 30, 29, 29);
                }
                if (m.map[e.Y / 30, e.X / 30] == 0)
                {
                    m.map[e.Y / 30, e.X / 30] = 1;
                    g.FillEllipse(new SolidBrush(Color.Blue), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                }
                else if (m.map[e.Y / 30, e.X / 30] == 3)
                {
                    m.map[e.Y / 30, e.X / 30] = 6;
                    g.DrawRectangle(Pens.Red, e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                    g.FillEllipse(new SolidBrush(Color.Blue), e.X / 30 * 30, e.Y / 30 * 30, 29, 29);
                }
                y = e.X / 30;
                x = e.Y / 30;
            }
        }
    }
}
