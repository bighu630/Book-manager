namespace book_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_登录 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.textbox_账号 = new book_system.Textboxpor();
            this.textbox_密码 = new book_system.Textboxpor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(92, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(92, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书管理系统";
            // 
            // button_登录
            // 
            this.button_登录.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_登录.Location = new System.Drawing.Point(49, 192);
            this.button_登录.Name = "button_登录";
            this.button_登录.Size = new System.Drawing.Size(83, 28);
            this.button_登录.TabIndex = 6;
            this.button_登录.Text = "登录";
            this.button_登录.UseVisualStyleBackColor = true;
            this.button_登录.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_取消
            // 
            this.button_取消.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_取消.Location = new System.Drawing.Point(199, 192);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(83, 28);
            this.button_取消.TabIndex = 7;
            this.button_取消.Text = "注册";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // textbox_账号
            // 
            this.textbox_账号.Location = new System.Drawing.Point(134, 96);
            this.textbox_账号.Name = "textbox_账号";
            this.textbox_账号.Size = new System.Drawing.Size(108, 21);
            this.textbox_账号.TabIndex = 8;
            this.textbox_账号.WatermarkText = "学号";
            // 
            // textbox_密码
            // 
            this.textbox_密码.Location = new System.Drawing.Point(134, 138);
            this.textbox_密码.Name = "textbox_密码";
            this.textbox_密码.Size = new System.Drawing.Size(108, 21);
            this.textbox_密码.TabIndex = 9;
            this.textbox_密码.WatermarkText = "默认身份证后六位";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 252);
            this.Controls.Add(this.textbox_密码);
            this.Controls.Add(this.textbox_账号);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_登录);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_登录;
        private System.Windows.Forms.Button button_取消;
        private Textboxpor textbox_账号;
        private Textboxpor textbox_密码;
    }
}

