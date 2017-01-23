namespace LibraryMS00
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labTittle = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            this.labBookId = new System.Windows.Forms.Label();
            this.labBookName = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.labLine2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTittle.Location = new System.Drawing.Point(12, 9);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(406, 32);
            this.labTittle.TabIndex = 0;
            this.labTittle.Text = "Library Management System";
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.Location = new System.Drawing.Point(12, 41);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(833, 12);
            this.labLine.TabIndex = 1;
            this.labLine.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------------------------";
            // 
            // labBookId
            // 
            this.labBookId.AutoSize = true;
            this.labBookId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBookId.Location = new System.Drawing.Point(14, 57);
            this.labBookId.Name = "labBookId";
            this.labBookId.Size = new System.Drawing.Size(74, 21);
            this.labBookId.TabIndex = 2;
            this.labBookId.Text = "图书编号";
            // 
            // labBookName
            // 
            this.labBookName.AutoSize = true;
            this.labBookName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBookName.Location = new System.Drawing.Point(14, 87);
            this.labBookName.Name = "labBookName";
            this.labBookName.Size = new System.Drawing.Size(74, 21);
            this.labBookName.TabIndex = 3;
            this.labBookName.Text = "图书名称";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(94, 57);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(106, 21);
            this.txtBookId.TabIndex = 4;
            // 
            // labLine2
            // 
            this.labLine2.AutoSize = true;
            this.labLine2.Location = new System.Drawing.Point(12, 118);
            this.labLine2.Name = "labLine2";
            this.labLine2.Size = new System.Drawing.Size(833, 12);
            this.labLine2.TabIndex = 5;
            this.labLine2.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------------------------";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(94, 87);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(106, 21);
            this.txtBookName.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(95, 133);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "查看";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(834, 420);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(257, 133);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewForm
            // 
            this.btnNewForm.Location = new System.Drawing.Point(338, 134);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(75, 23);
            this.btnNewForm.TabIndex = 12;
            this.btnNewForm.Text = "打开新窗口";
            this.btnNewForm.UseVisualStyleBackColor = true;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 595);
            this.Controls.Add(this.btnNewForm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.labLine2);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.labBookName);
            this.Controls.Add(this.labBookId);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.labTittle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.Label labBookId;
        private System.Windows.Forms.Label labBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label labLine2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewForm;
    }
}

