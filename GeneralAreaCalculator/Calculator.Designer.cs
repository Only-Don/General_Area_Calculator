
namespace GeneralAreaCalculator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SqaureLable = new System.Windows.Forms.Label();
            this.RectangleLengthLable = new System.Windows.Forms.Label();
            this.RectangleWidthLable = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TriangleBaseLable = new System.Windows.Forms.Label();
            this.TriangleHeightLable = new System.Windows.Forms.Label();
            this.CircleLable = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadHistory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(293, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "通用面积计算器";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(649, 172);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 38);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(644, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "图形";
            // 
            // SqaureLable
            // 
            this.SqaureLable.AutoSize = true;
            this.SqaureLable.Font = new System.Drawing.Font("宋体", 18F);
            this.SqaureLable.Location = new System.Drawing.Point(79, 121);
            this.SqaureLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SqaureLable.Name = "SqaureLable";
            this.SqaureLable.Size = new System.Drawing.Size(73, 30);
            this.SqaureLable.TabIndex = 6;
            this.SqaureLable.Text = "边长";
            this.SqaureLable.UseWaitCursor = true;
            this.SqaureLable.Visible = false;
            // 
            // RectangleLengthLable
            // 
            this.RectangleLengthLable.AutoSize = true;
            this.RectangleLengthLable.Font = new System.Drawing.Font("宋体", 18F);
            this.RectangleLengthLable.Location = new System.Drawing.Point(79, 121);
            this.RectangleLengthLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleLengthLable.Name = "RectangleLengthLable";
            this.RectangleLengthLable.Size = new System.Drawing.Size(43, 30);
            this.RectangleLengthLable.TabIndex = 8;
            this.RectangleLengthLable.Text = "长";
            this.RectangleLengthLable.UseWaitCursor = true;
            this.RectangleLengthLable.Visible = false;
            // 
            // RectangleWidthLable
            // 
            this.RectangleWidthLable.AutoSize = true;
            this.RectangleWidthLable.Font = new System.Drawing.Font("宋体", 18F);
            this.RectangleWidthLable.Location = new System.Drawing.Point(360, 121);
            this.RectangleWidthLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleWidthLable.Name = "RectangleWidthLable";
            this.RectangleWidthLable.Size = new System.Drawing.Size(43, 30);
            this.RectangleWidthLable.TabIndex = 10;
            this.RectangleWidthLable.Text = "宽";
            this.RectangleWidthLable.UseWaitCursor = true;
            this.RectangleWidthLable.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox2.Location = new System.Drawing.Point(365, 169);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 42);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // TriangleBaseLable
            // 
            this.TriangleBaseLable.AutoSize = true;
            this.TriangleBaseLable.Font = new System.Drawing.Font("宋体", 18F);
            this.TriangleBaseLable.Location = new System.Drawing.Point(79, 121);
            this.TriangleBaseLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TriangleBaseLable.Name = "TriangleBaseLable";
            this.TriangleBaseLable.Size = new System.Drawing.Size(43, 30);
            this.TriangleBaseLable.TabIndex = 12;
            this.TriangleBaseLable.Text = "底";
            this.TriangleBaseLable.UseWaitCursor = true;
            this.TriangleBaseLable.Visible = false;
            // 
            // TriangleHeightLable
            // 
            this.TriangleHeightLable.AutoSize = true;
            this.TriangleHeightLable.Font = new System.Drawing.Font("宋体", 18F);
            this.TriangleHeightLable.Location = new System.Drawing.Point(360, 121);
            this.TriangleHeightLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TriangleHeightLable.Name = "TriangleHeightLable";
            this.TriangleHeightLable.Size = new System.Drawing.Size(43, 30);
            this.TriangleHeightLable.TabIndex = 14;
            this.TriangleHeightLable.Text = "高";
            this.TriangleHeightLable.UseWaitCursor = true;
            this.TriangleHeightLable.Visible = false;
            // 
            // CircleLable
            // 
            this.CircleLable.AutoSize = true;
            this.CircleLable.Font = new System.Drawing.Font("宋体", 18F);
            this.CircleLable.Location = new System.Drawing.Point(79, 121);
            this.CircleLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CircleLable.Name = "CircleLable";
            this.CircleLable.Size = new System.Drawing.Size(73, 30);
            this.CircleLable.TabIndex = 15;
            this.CircleLable.Text = "直径";
            this.CircleLable.UseWaitCursor = true;
            this.CircleLable.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(84, 290);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(525, 229);
            this.textBox3.TabIndex = 16;
            this.textBox3.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(79, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "计算结果";
            // 
            // LoadHistory
            // 
            this.LoadHistory.BackgroundImage = global::GeneralAreaCalculator.Properties.Resources.未标题_11;
            this.LoadHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadHistory.FlatAppearance.BorderSize = 0;
            this.LoadHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadHistory.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadHistory.Location = new System.Drawing.Point(649, 290);
            this.LoadHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadHistory.Name = "LoadHistory";
            this.LoadHistory.Size = new System.Drawing.Size(160, 88);
            this.LoadHistory.TabIndex = 18;
            this.LoadHistory.Text = "加载\r\n历史记录";
            this.LoadHistory.UseVisualStyleBackColor = true;
            this.LoadHistory.Click += new System.EventHandler(this.LoadHistory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(644, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "历史记录";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox1.Location = new System.Drawing.Point(84, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 42);
            this.textBox1.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(3, 24);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 22);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "cm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(63, 25);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 22);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.Text = "inch";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.Location = new System.Drawing.Point(67, 25);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 22);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.Text = "inch";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(7, 25);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 22);
            this.radioButton3.TabIndex = 27;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "cm";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(176, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(132, 68);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(471, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(140, 68);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = global::GeneralAreaCalculator.Properties.Resources.未标题_11;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("宋体", 14.25F);
            this.clearButton.Location = new System.Drawing.Point(844, 289);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 88);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "清除\r\n历史记录";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GeneralAreaCalculator.Properties.Resources.未标题_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(649, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 121);
            this.button1.TabIndex = 21;
            this.button1.Text = "计算！";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoadHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TriangleHeightLable);
            this.Controls.Add(this.RectangleWidthLable);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SqaureLable);
            this.Controls.Add(this.CircleLable);
            this.Controls.Add(this.TriangleBaseLable);
            this.Controls.Add(this.RectangleLengthLable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SqaureLable;
        private System.Windows.Forms.Label RectangleLengthLable;
        private System.Windows.Forms.Label RectangleWidthLable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TriangleBaseLable;
        private System.Windows.Forms.Label TriangleHeightLable;
        private System.Windows.Forms.Label CircleLable;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoadHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearButton;
    }
}

