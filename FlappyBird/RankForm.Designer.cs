namespace FlappyBird
{
    partial class RankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_RankList = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RankList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RankList
            // 
            this.dgv_RankList.AllowUserToAddRows = false;
            this.dgv_RankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RankList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserScore});
            this.dgv_RankList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RankList.Location = new System.Drawing.Point(0, 0);
            this.dgv_RankList.Name = "dgv_RankList";
            this.dgv_RankList.ReadOnly = true;
            this.dgv_RankList.RowTemplate.Height = 23;
            this.dgv_RankList.Size = new System.Drawing.Size(356, 443);
            this.dgv_RankList.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserScore
            // 
            this.UserScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserScore.HeaderText = "Score";
            this.UserScore.Name = "UserScore";
            this.UserScore.ReadOnly = true;
            // 
            // RankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 443);
            this.Controls.Add(this.dgv_RankList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RankForm";
            this.Text = "RankForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RankList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RankList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserScore;
    }
}