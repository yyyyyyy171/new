namespace 图书管理系统
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.UsersManageButton = new System.Windows.Forms.Button();
            this.BookManageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersManageButton
            // 
            this.UsersManageButton.Location = new System.Drawing.Point(30, 34);
            this.UsersManageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersManageButton.Name = "UsersManageButton";
            this.UsersManageButton.Size = new System.Drawing.Size(70, 37);
            this.UsersManageButton.TabIndex = 0;
            this.UsersManageButton.Text = "用户管理";
            this.UsersManageButton.UseVisualStyleBackColor = true;
            this.UsersManageButton.Click += new System.EventHandler(this.UsersManageButton_Click);
            // 
            // BookManageButton
            // 
            this.BookManageButton.Location = new System.Drawing.Point(124, 34);
            this.BookManageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookManageButton.Name = "BookManageButton";
            this.BookManageButton.Size = new System.Drawing.Size(70, 37);
            this.BookManageButton.TabIndex = 1;
            this.BookManageButton.Text = "图书管理";
            this.BookManageButton.UseVisualStyleBackColor = true;
            this.BookManageButton.Click += new System.EventHandler(this.BookManageButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(124, 95);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "退出登陆";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "登陆记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.BookManageButton);
            this.Controls.Add(this.UsersManageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersManageButton;
        private System.Windows.Forms.Button BookManageButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
    }
}