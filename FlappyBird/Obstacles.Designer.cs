namespace FlappyBird
{
    partial class Obstacles
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obstacles));
            this.p_pipeDown = new System.Windows.Forms.PictureBox();
            this.p_pipeUp = new System.Windows.Forms.PictureBox();
            this.timer_Move = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p_pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_pipeUp)).BeginInit();
            this.SuspendLayout();
            // 
            // p_pipeDown
            // 
            this.p_pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("p_pipeDown.Image")));
            this.p_pipeDown.Location = new System.Drawing.Point(0, 470);
            this.p_pipeDown.Name = "p_pipeDown";
            this.p_pipeDown.Size = new System.Drawing.Size(52, 320);
            this.p_pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_pipeDown.TabIndex = 0;
            this.p_pipeDown.TabStop = false;
            // 
            // p_pipeUp
            // 
            this.p_pipeUp.Image = ((System.Drawing.Image)(resources.GetObject("p_pipeUp.Image")));
            this.p_pipeUp.Location = new System.Drawing.Point(0, 0);
            this.p_pipeUp.Name = "p_pipeUp";
            this.p_pipeUp.Size = new System.Drawing.Size(52, 320);
            this.p_pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_pipeUp.TabIndex = 0;
            this.p_pipeUp.TabStop = false;
            // 
            // timer_Move
            // 
            this.timer_Move.Interval = 1;
            this.timer_Move.Tick += new System.EventHandler(this.timer_Move_Tick);
            // 
            // Obstacles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.p_pipeUp);
            this.Controls.Add(this.p_pipeDown);
            this.DoubleBuffered = true;
            this.Name = "Obstacles";
            this.Size = new System.Drawing.Size(54, 790);
            ((System.ComponentModel.ISupportInitialize)(this.p_pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_pipeUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox p_pipeDown;
        public System.Windows.Forms.PictureBox p_pipeUp;
        private System.Windows.Forms.Timer timer_Move;
    }
}
