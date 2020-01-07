namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p_Brid = new System.Windows.Forms.PictureBox();
            this.imgList_Bird = new System.Windows.Forms.ImageList(this.components);
            this.timer_BirdFly = new System.Windows.Forms.Timer(this.components);
            this.timer_BirdMovingTrail = new System.Windows.Forms.Timer(this.components);
            this.timer_SceneMovement = new System.Windows.Forms.Timer(this.components);
            this.timer_CreateObstacles = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.l_Score = new System.Windows.Forms.Label();
            this.p_bg2 = new FlappyBird.PanelEx();
            this.p_bg1 = new FlappyBird.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.p_Brid)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Brid
            // 
            this.p_Brid.BackColor = System.Drawing.Color.Transparent;
            this.p_Brid.Image = ((System.Drawing.Image)(resources.GetObject("p_Brid.Image")));
            this.p_Brid.Location = new System.Drawing.Point(108, 161);
            this.p_Brid.Name = "p_Brid";
            this.p_Brid.Size = new System.Drawing.Size(12, 12);
            this.p_Brid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Brid.TabIndex = 0;
            this.p_Brid.TabStop = false;
            // 
            // imgList_Bird
            // 
            this.imgList_Bird.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Bird.ImageStream")));
            this.imgList_Bird.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Bird.Images.SetKeyName(0, "Bird0_0.png");
            this.imgList_Bird.Images.SetKeyName(1, "Bird0_1.png");
            this.imgList_Bird.Images.SetKeyName(2, "Bird0_2.png");
            // 
            // timer_BirdFly
            // 
            this.timer_BirdFly.Enabled = true;
            this.timer_BirdFly.Interval = 150;
            this.timer_BirdFly.Tick += new System.EventHandler(this.timer_BirdFly_Tick);
            // 
            // timer_BirdMovingTrail
            // 
            this.timer_BirdMovingTrail.Interval = 18;
            this.timer_BirdMovingTrail.Tick += new System.EventHandler(this.timer_BirdMovingTrail_Tick);
            // 
            // timer_SceneMovement
            // 
            this.timer_SceneMovement.Enabled = true;
            this.timer_SceneMovement.Interval = 1;
            this.timer_SceneMovement.Tick += new System.EventHandler(this.timer_SceneMovement_Tick);
            // 
            // timer_CreateObstacles
            // 
            this.timer_CreateObstacles.Interval = 2500;
            this.timer_CreateObstacles.Tick += new System.EventHandler(this.timer_CreateObstacles_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(667, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score：";
            // 
            // l_Score
            // 
            this.l_Score.AutoSize = true;
            this.l_Score.BackColor = System.Drawing.Color.Transparent;
            this.l_Score.Font = new System.Drawing.Font("宋体", 15F);
            this.l_Score.Location = new System.Drawing.Point(737, 9);
            this.l_Score.Name = "l_Score";
            this.l_Score.Size = new System.Drawing.Size(19, 20);
            this.l_Score.TabIndex = 1;
            this.l_Score.Text = "0";
            // 
            // p_bg2
            // 
            this.p_bg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_bg2.BackgroundImage")));
            this.p_bg2.Location = new System.Drawing.Point(786, 0);
            this.p_bg2.Name = "p_bg2";
            this.p_bg2.Size = new System.Drawing.Size(786, 472);
            this.p_bg2.TabIndex = 1;
            // 
            // p_bg1
            // 
            this.p_bg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_bg1.BackgroundImage")));
            this.p_bg1.Location = new System.Drawing.Point(0, 1);
            this.p_bg1.Name = "p_bg1";
            this.p_bg1.Size = new System.Drawing.Size(786, 472);
            this.p_bg1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.l_Score);
            this.Controls.Add(this.p_Brid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_bg1);
            this.Controls.Add(this.p_bg2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.p_Brid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_Brid;
        private System.Windows.Forms.ImageList imgList_Bird;
        private System.Windows.Forms.Timer timer_BirdFly;
        private System.Windows.Forms.Timer timer_BirdMovingTrail;
        private System.Windows.Forms.Timer timer_SceneMovement;
        private PanelEx p_bg1;
        private PanelEx p_bg2;
        private System.Windows.Forms.Timer timer_CreateObstacles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Score;
    }
}

