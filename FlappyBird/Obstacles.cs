using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Obstacles : UserControl
    {
        int formWidth;
        public Obstacles(int _formWidth)
        {
            InitializeComponent();
            formWidth = _formWidth;
            RandomLocation(_formWidth);
        }

        /// <summary>
        /// 创建随机定位的障碍物
        /// </summary>
        /// <returns></returns>
        /*public Obstacles CreateObstacles(int _formWidth)
        {
            Random random = new Random();
            Obstacles obstacles = new Obstacles();
            obstacles.Location = new Point(_formWidth, random.Next(-290, 0));
            obstacles.BringToFront();
            return obstacles;
        }*/

        /// <summary>
        /// 移动障碍物
        /// </summary>
        private void MoveObstacles()
        {
            this.Location = new Point(this.Location.X - 3,this.Location.Y);
            if (this.Location.X + this.Width <= 0)
            {
                RandomLocation(formWidth);
            }
        }
        /// <summary>
        /// 随机位置
        /// </summary>
        /// <param name="_formWidth"></param>
        public void RandomLocation(int _formWidth)
        {
            Random random = new Random();
            this.Location = new Point(_formWidth, random.Next(-290, 0));
        }

        private void timer_Move_Tick(object sender, EventArgs e)
        {
            MoveObstacles();
        }
    }
}
