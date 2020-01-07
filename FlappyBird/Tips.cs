using FlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Tips : Form
    {
        int score;
        public Tips(int score)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.score = score;
            l_Score.Text = score.ToString();
        }

        /// <summary>
        /// 提交分数
        /// </summary>
        private void SubmissionScore(string name,int score)
        {
            if (Settings.Default.IsFirstOpen)
            {

                Settings.Default.Score = new System.Collections.Specialized.StringCollection();
                Settings.Default.UserName = new System.Collections.Specialized.StringCollection();
                Settings.Default.IsFirstOpen = false;
            }
            Settings.Default.UserName.Add( name);
            Settings.Default.Score.Add( score.ToString());
            Settings.Default.Save();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }
            SubmissionScore(txt_Name.Text, score);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Rank_Click(object sender, EventArgs e)
        {
            RankForm rankForm = new RankForm();
            rankForm.ShowDialog();
        }
    }
}
