namespace book_system
{
    partial class Form_借书
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
            this.button_查询 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_借书 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxpor_借书 = new book_system.Textboxpor();
            this.textboxpor_查询 = new book_system.Textboxpor();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_查询
            // 
            this.button_查询.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_查询.Location = new System.Drawing.Point(173, 22);
            this.button_查询.Name = "button_查询";
            this.button_查询.Size = new System.Drawing.Size(75, 23);
            this.button_查询.TabIndex = 1;
            this.button_查询.Text = "查询";
            this.button_查询.UseVisualStyleBackColor = true;
            this.button_查询.Click += new System.EventHandler(this.button_查询_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(538, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "图书ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "图书名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "作者";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "馆藏";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button_借书
            // 
            this.button_借书.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_借书.Location = new System.Drawing.Point(452, 24);
            this.button_借书.Name = "button_借书";
            this.button_借书.Size = new System.Drawing.Size(75, 23);
            this.button_借书.TabIndex = 4;
            this.button_借书.Text = "借书";
            this.button_借书.UseVisualStyleBackColor = true;
            this.button_借书.Click += new System.EventHandler(this.button_借书_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "图书ID可选中后Ctrl+C复制";
            // 
            // textboxpor_借书
            // 
            this.textboxpor_借书.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textboxpor_借书.Location = new System.Drawing.Point(292, 24);
            this.textboxpor_借书.Name = "textboxpor_借书";
            this.textboxpor_借书.Size = new System.Drawing.Size(154, 23);
            this.textboxpor_借书.TabIndex = 3;
            this.textboxpor_借书.WatermarkText = "图书ID";
            // 
            // textboxpor_查询
            // 
            this.textboxpor_查询.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textboxpor_查询.Location = new System.Drawing.Point(13, 22);
            this.textboxpor_查询.Name = "textboxpor_查询";
            this.textboxpor_查询.Size = new System.Drawing.Size(154, 23);
            this.textboxpor_查询.TabIndex = 0;
            this.textboxpor_查询.WatermarkText = "书名/作者";
            // 
            // Form_借书
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_借书);
            this.Controls.Add(this.textboxpor_借书);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_查询);
            this.Controls.Add(this.textboxpor_查询);
            this.Name = "Form_借书";
            this.Text = "Form_借书";
            this.Load += new System.EventHandler(this.Form_借书_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Textboxpor textboxpor_查询;
        private System.Windows.Forms.Button button_查询;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Textboxpor textboxpor_借书;
        private System.Windows.Forms.Button button_借书;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
    }
}