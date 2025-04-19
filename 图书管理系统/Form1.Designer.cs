namespace 图书管理系统
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogInlinkLabel = new System.Windows.Forms.LinkLabel();
            this.SignInlinkLabel = new System.Windows.Forms.LinkLabel();
            this.UnsubscribelinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInlinkLabel
            // 
            this.LogInlinkLabel.AutoSize = true;
            this.LogInlinkLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogInlinkLabel.Location = new System.Drawing.Point(742, 629);
            this.LogInlinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogInlinkLabel.Name = "LogInlinkLabel";
            this.LogInlinkLabel.Size = new System.Drawing.Size(93, 38);
            this.LogInlinkLabel.TabIndex = 2;
            this.LogInlinkLabel.TabStop = true;
            this.LogInlinkLabel.Text = "登陆";
            this.LogInlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignInlinkLabel
            // 
            this.SignInlinkLabel.AutoSize = true;
            this.SignInlinkLabel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SignInlinkLabel.Location = new System.Drawing.Point(707, 721);
            this.SignInlinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignInlinkLabel.Name = "SignInlinkLabel";
            this.SignInlinkLabel.Size = new System.Drawing.Size(165, 37);
            this.SignInlinkLabel.TabIndex = 3;
            this.SignInlinkLabel.TabStop = true;
            this.SignInlinkLabel.Text = "用户注册";
            this.SignInlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInlinkLabel_LinkClicked);
            // 
            // UnsubscribelinkLabel
            // 
            this.UnsubscribelinkLabel.AutoSize = true;
            this.UnsubscribelinkLabel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UnsubscribelinkLabel.Location = new System.Drawing.Point(707, 809);
            this.UnsubscribelinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnsubscribelinkLabel.Name = "UnsubscribelinkLabel";
            this.UnsubscribelinkLabel.Size = new System.Drawing.Size(165, 37);
            this.UnsubscribelinkLabel.TabIndex = 4;
            this.UnsubscribelinkLabel.TabStop = true;
            this.UnsubscribelinkLabel.Text = "账号注销";
            this.UnsubscribelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UnsubscribelinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("思源宋体 CN", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(310, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(973, 184);
            this.label2.TabIndex = 6;
            this.label2.Text = "图书借阅客户端";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1571, 1022);
            this.Controls.Add(this.UnsubscribelinkLabel);
            this.Controls.Add(this.SignInlinkLabel);
            this.Controls.Add(this.LogInlinkLabel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LogInlinkLabel;
        private System.Windows.Forms.LinkLabel SignInlinkLabel;
        private System.Windows.Forms.LinkLabel UnsubscribelinkLabel;
        private System.Windows.Forms.Label label2;
    }
}

