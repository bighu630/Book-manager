namespace book_system
{
    partial class Form_学生
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_还书 = new System.Windows.Forms.Button();
            this.button_续借 = new System.Windows.Forms.Button();
            this.button_借书 = new System.Windows.Forms.Button();
            this.button_刷新 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "图书id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "图书名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "借书时间";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "还书时间";
            this.Column4.Name = "Column4";
            // 
            // button_还书
            // 
            this.button_还书.Location = new System.Drawing.Point(60, 465);
            this.button_还书.Name = "button_还书";
            this.button_还书.Size = new System.Drawing.Size(87, 40);
            this.button_还书.TabIndex = 1;
            this.button_还书.Text = "还书";
            this.button_还书.UseVisualStyleBackColor = true;
            this.button_还书.Click += new System.EventHandler(this.button_还书_Click);
            // 
            // button_续借
            // 
            this.button_续借.Location = new System.Drawing.Point(208, 466);
            this.button_续借.Name = "button_续借";
            this.button_续借.Size = new System.Drawing.Size(88, 40);
            this.button_续借.TabIndex = 2;
            this.button_续借.Text = "续借";
            this.button_续借.UseVisualStyleBackColor = true;
            this.button_续借.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_借书
            // 
            this.button_借书.Location = new System.Drawing.Point(363, 465);
            this.button_借书.Name = "button_借书";
            this.button_借书.Size = new System.Drawing.Size(88, 43);
            this.button_借书.TabIndex = 3;
            this.button_借书.Text = "借书";
            this.button_借书.UseVisualStyleBackColor = true;
            this.button_借书.Click += new System.EventHandler(this.button_借书_Click);
            // 
            // button_刷新
            // 
            this.button_刷新.Location = new System.Drawing.Point(514, 466);
            this.button_刷新.Name = "button_刷新";
            this.button_刷新.Size = new System.Drawing.Size(96, 43);
            this.button_刷新.TabIndex = 4;
            this.button_刷新.Text = "刷新";
            this.button_刷新.UseVisualStyleBackColor = true;
            this.button_刷新.Click += new System.EventHandler(this.button_刷新_Click);
            // 
            // Form_学生
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 539);
            this.Controls.Add(this.button_刷新);
            this.Controls.Add(this.button_借书);
            this.Controls.Add(this.button_续借);
            this.Controls.Add(this.button_还书);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_学生";
            this.Text = "Form_学生";
            this.Load += new System.EventHandler(this.Form_学生_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button_还书;
        private System.Windows.Forms.Button button_续借;
        private System.Windows.Forms.Button button_借书;
        private System.Windows.Forms.Button button_刷新;
    }
}