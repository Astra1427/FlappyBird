using FlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        byte bridPictureIndex = 0;  //控制小鸟图片
        int bridDescentVelocity = -10;    //控制小鸟下降速度
        int Score = 0;  //分数
        bool IsPause = false;//是否暂停
        /*PanelEx p_bg1 = new PanelEx {
            Width = 784,
            Height = 473
        }, p_bg2 = new PanelEx {
            Width = 784,
            Height = 473
        };*/
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //背景部分有BUG 现在已经将背景隐藏
            p_bg1.SendToBack();
            p_bg2.SendToBack();

            p_bg1.Visible = false;
            p_bg2.Visible = false;
        }

        private void GameInit()
        {
            p_Brid.Location = new Point(108, 161);
            timer_BirdMovingTrail.Enabled = false;
            Score = 0;
            l_Score.Text = "";

            lock (ObstacleList)
            {

                for (int i = 0; i < ObstacleList.Count; i++)
                {
                    this.Controls.Remove(ObstacleList[i]);
                }
                ObstacleList.Clear();
            }
        }



        /// <summary>
        /// 控制小鸟图片的切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_BirdFly_Tick(object sender, EventArgs e)
        {
            p_Brid.Image = imgList_Bird.Images[bridPictureIndex];
            bridPictureIndex++;
            if (bridPictureIndex >= imgList_Bird.Images.Count)
            {
                bridPictureIndex = 0;
            }
        }
        /// <summary>
        /// 暂停
        /// </summary>
        private void GamePause()
        {
            timer_BirdMovingTrail.Enabled = false;
            timer_SceneMovement.Enabled = false;
            IsPause = true;
        }
        /// <summary>
        /// 继续游戏
        /// </summary>
        private void GameContinue()
        {
            timer_BirdMovingTrail.Enabled = true;
            timer_SceneMovement.Enabled = true;
            IsPause = false;
        }

        /// <summary>
        /// 控制玩家下坠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_BirdMovingTrail_Tick(object sender, EventArgs e)
        {
            p_Brid.Location = new Point(p_Brid.Location.X,p_Brid.Location.Y + bridDescentVelocity);
            bridDescentVelocity++;

            if (IsBeyondInterface())
            {
                GameOver();
            }
            //检测碰撞
            if (ObstacleList.Count > 1) 
            {

                if (IsCollision(p_Brid, ObstacleList[0].p_pipeUp) || IsCollision(p_Brid, ObstacleList[0].p_pipeDown) || IsCollision(p_Brid, ObstacleList[1].p_pipeUp) || IsCollision(p_Brid, ObstacleList[1].p_pipeDown)
                    )
                {
                    //MessageBox.Show($"游戏结束!\nScore:{Score}");
                    GameOver();
                }
            }
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            //监听空格键
            if (e.KeyCode == Keys.Space)
            {
                if (!timer_BirdMovingTrail.Enabled)//如果第一次按下则开始游戏
                {
                    timer_BirdMovingTrail.Enabled = true;
                    timer_CreateObstacles.Enabled = true;
                }
                if (IsPause)
                {
                    GameContinue();
                }
                bridDescentVelocity = -12;
            }
            else if (e.KeyCode == Keys.R)
            {
                GameInit();
            }else if (e.KeyCode == Keys.P)
            {
                if (IsPause)
                { GameContinue(); }
                else
                { GamePause(); }
            }
        }

        int px = 1;

        /// <summary>
        /// 控制场景和障碍物移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_SceneMovement_Tick(object sender, EventArgs e)
        {
            //移动背景
            p_bg1.Location = new Point(p_bg1.Location.X - px,0);
            p_bg2.Location = new Point(p_bg2.Location.X - px,0);
            if (p_bg1.Location.X + p_bg1.Width <= 0)
            {
                p_bg1.Location = new Point(785, 0);
            }
            else if (p_bg2.Location.X + p_bg2.Width <= 0)
            {
                p_bg2.Location = new Point(785, 0);
            }

            //移动pipe  
            
            for (int i = 0; i < ObstacleList.Count; i++)
            {
                ObstacleList[i].Location = new Point(ObstacleList[i].Location.X - px, ObstacleList[i].Location.Y);

                if (ObstacleList[i].Location.X + ObstacleList[i].Width <= p_Brid.Location.X)//加分
                {
                    Score++;
                    l_Score.Text = Score.ToString();   
                }
                if (ObstacleList[i].Location.X + ObstacleList[i].Width <= 0)
                {
                    //ObstacleList[i].RandomLocation(this.Width);
                    this.Controls.Remove(ObstacleList[i]);
                    ObstacleList.Remove(ObstacleList[i]);
                }
            }
            


            

            

        }

        List<Obstacles> ObstacleList = new List<Obstacles>();

        public void CreateObstacles()
        {
            lock (ObstacleList)
            {
                ObstacleList.Add(new Obstacles(this.Width)) ;
                this.Controls.Add(ObstacleList[ObstacleList.Count-1]);
            }
        }
        Random random = new Random();

        int maxObstaclesCount = 0;
        private void timer_CreateObstacles_Tick(object sender, EventArgs e)
        {
            CreateObstacles();
            maxObstaclesCount++;
        }



        /// <summary>
        /// 将测碰撞
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        private bool IsCollision(Control c1, Control c2)
        {

            if (c2.Name == "p_pipeUp")
            {
                if (c1.Location.X > c2.Parent.Location.X - c1.Width && c1.Location.Y > c2.Parent.Location.Y - c1.Height
                && c1.Location.X < c2.Parent.Location.X + c2.Width && c1.Location.Y < c2.Parent.Location.Y + c2.Height)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (c1.Location.X > c2.Parent.Location.X - c1.Width && c1.Location.Y > c2.Location.Y + c2.Parent.Location.Y - c1.Height
                && c1.Location.X < c2.Parent.Location.X + c2.Width && c1.Location.Y < c2.Location.Y  + c2.Parent.Location.Y + c2.Height)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            
        }

        private void GameOver()
        {
            GamePause();
            Tips tips = new Tips(Score);
            tips.ShowDialog();
            GameInit();
        }

        /// <summary>
        /// 是否超出界面
        /// </summary>
        /// <returns></returns>
        private bool IsBeyondInterface()
        {
            if (p_Brid.Location.Y <= 0)
            {
                return true;
            }
            else if (p_Brid.Location.Y >= this.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
