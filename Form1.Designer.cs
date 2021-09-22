
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.button_createChart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_chart
            // 
            this.pictureBox_chart.Location = new System.Drawing.Point(57, 22);
            this.pictureBox_chart.Name = "pictureBox_chart";
            this.pictureBox_chart.Size = new System.Drawing.Size(780, 480);
            this.pictureBox_chart.TabIndex = 0;
            this.pictureBox_chart.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(369, 552);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(13, 15);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "a";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(369, 581);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(14, 15);
            this.label_b.TabIndex = 4;
            this.label_b.Text = "b";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(369, 610);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(13, 15);
            this.label_c.TabIndex = 5;
            this.label_c.Text = "c";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(389, 543);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 23);
            this.textBox_a.TabIndex = 6;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(389, 572);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 23);
            this.textBox_b.TabIndex = 7;
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(389, 601);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(100, 23);
            this.textBox_c.TabIndex = 8;
            // 
            // button_createChart
            // 
            this.button_createChart.Location = new System.Drawing.Point(369, 651);
            this.button_createChart.Name = "button_createChart";
            this.button_createChart.Size = new System.Drawing.Size(120, 23);
            this.button_createChart.TabIndex = 9;
            this.button_createChart.Text = "Построить";
            this.button_createChart.UseVisualStyleBackColor = true;
            this.button_createChart.Click += new System.EventHandler(this.button_createChart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 705);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_createChart);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Button button_createChart;
        private System.Windows.Forms.Label label3;
    }
}

