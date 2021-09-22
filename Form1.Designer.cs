
namespace testCharts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_chart = new System.Windows.Forms.PictureBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.button_createChart = new System.Windows.Forms.Button();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.label_equation = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_chart
            // 
            this.pictureBox_chart.Location = new System.Drawing.Point(57, 34);
            this.pictureBox_chart.Name = "pictureBox_chart";
            this.pictureBox_chart.Size = new System.Drawing.Size(780, 480);
            this.pictureBox_chart.TabIndex = 0;
            this.pictureBox_chart.TabStop = false;
            this.pictureBox_chart.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox_chart_Layout);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_a.Location = new System.Drawing.Point(157, 584);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(61, 22);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "x^2 + ";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_b.Location = new System.Drawing.Point(296, 584);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(35, 22);
            this.label_b.TabIndex = 4;
            this.label_b.Text = "x +";
            // 
            // textBox_a
            // 
            this.textBox_a.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_a.Location = new System.Drawing.Point(57, 581);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 29);
            this.textBox_a.TabIndex = 6;
            // 
            // textBox_b
            // 
            this.textBox_b.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_b.Location = new System.Drawing.Point(196, 581);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 29);
            this.textBox_b.TabIndex = 7;
            // 
            // textBox_c
            // 
            this.textBox_c.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_c.Location = new System.Drawing.Point(337, 581);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(100, 29);
            this.textBox_c.TabIndex = 8;
            // 
            // button_createChart
            // 
            this.button_createChart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_createChart.Location = new System.Drawing.Point(57, 622);
            this.button_createChart.Name = "button_createChart";
            this.button_createChart.Size = new System.Drawing.Size(380, 30);
            this.button_createChart.TabIndex = 9;
            this.button_createChart.Text = "Построить график";
            this.button_createChart.UseVisualStyleBackColor = true;
            this.button_createChart.Click += new System.EventHandler(this.button_createChart_Click);
            // 
            // textBox_info
            // 
            this.textBox_info.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_info.Location = new System.Drawing.Point(592, 520);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.Size = new System.Drawing.Size(245, 132);
            this.textBox_info.TabIndex = 11;
            // 
            // label_equation
            // 
            this.label_equation.AutoSize = true;
            this.label_equation.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_equation.Location = new System.Drawing.Point(128, 531);
            this.label_equation.Name = "label_equation";
            this.label_equation.Size = new System.Drawing.Size(247, 36);
            this.label_equation.TabIndex = 12;
            this.label_equation.Text = "y = ax^2 + bx + c";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(57, 4);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(262, 21);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "График квадратного уравнения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 705);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_equation);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.button_createChart);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.pictureBox_chart);
            this.Name = "Form1";
            this.Text = "Charts";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_chart;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Button button_createChart;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Label label_equation;
        private System.Windows.Forms.Label label_title;
    }
}

