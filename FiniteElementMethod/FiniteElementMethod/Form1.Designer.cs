
namespace FiniteElementMethod
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T_function = new System.Windows.Forms.TextBox();
            this.f_function = new System.Windows.Forms.TextBox();
            this.q_value = new System.Windows.Forms.TextBox();
            this.n_value = new System.Windows.Forms.TextBox();
            this.calc_button = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uh0_value = new System.Windows.Forms.TextBox();
            this.uh1_value = new System.Windows.Forms.TextBox();
            this.realChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.u_function = new System.Windows.Forms.TextBox();
            this.u_uh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.allCharts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCharts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "T(x) = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "f(x) = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "q = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(52, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "n = ";
            // 
            // T_function
            // 
            this.T_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_function.Location = new System.Drawing.Point(96, 25);
            this.T_function.Name = "T_function";
            this.T_function.Size = new System.Drawing.Size(301, 27);
            this.T_function.TabIndex = 4;
            this.T_function.Text = "3*ln(x) + 2^x -8*x";
            // 
            // f_function
            // 
            this.f_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_function.Location = new System.Drawing.Point(96, 68);
            this.f_function.Name = "f_function";
            this.f_function.Size = new System.Drawing.Size(301, 27);
            this.f_function.TabIndex = 5;
            this.f_function.Text = "18*x*ln(x)+9*x+3*ln(2)*(2^x)*x*x+3*(2^(x+1))*x-72*x^2";
            // 
            // q_value
            // 
            this.q_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q_value.Location = new System.Drawing.Point(94, 109);
            this.q_value.Name = "q_value";
            this.q_value.Size = new System.Drawing.Size(303, 27);
            this.q_value.TabIndex = 6;
            this.q_value.Text = "0";
            // 
            // n_value
            // 
            this.n_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_value.Location = new System.Drawing.Point(96, 148);
            this.n_value.Name = "n_value";
            this.n_value.Size = new System.Drawing.Size(301, 27);
            this.n_value.TabIndex = 7;
            this.n_value.Text = "4";
            // 
            // calc_button
            // 
            this.calc_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc_button.Location = new System.Drawing.Point(481, 68);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(212, 68);
            this.calc_button.TabIndex = 8;
            this.calc_button.Text = "Обчислити";
            this.calc_button.UseVisualStyleBackColor = false;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 7.304786F;
            legend4.Position.Width = 20.19231F;
            legend4.Position.X = 76.80769F;
            legend4.Position.Y = 3F;
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(57, 282);
            this.chart.Name = "chart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Aqua;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(521, 398);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "||Uh||0 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(356, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "||Uh||1 = ";
            // 
            // uh0_value
            // 
            this.uh0_value.Enabled = false;
            this.uh0_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uh0_value.Location = new System.Drawing.Point(134, 221);
            this.uh0_value.Name = "uh0_value";
            this.uh0_value.Size = new System.Drawing.Size(113, 27);
            this.uh0_value.TabIndex = 12;
            // 
            // uh1_value
            // 
            this.uh1_value.Enabled = false;
            this.uh1_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uh1_value.Location = new System.Drawing.Point(437, 221);
            this.uh1_value.Name = "uh1_value";
            this.uh1_value.Size = new System.Drawing.Size(113, 27);
            this.uh1_value.TabIndex = 13;
            // 
            // realChart
            // 
            chartArea5.Name = "ChartArea1";
            this.realChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            legend5.Position.Auto = false;
            legend5.Position.Height = 7.304786F;
            legend5.Position.Width = 23.22457F;
            legend5.Position.X = 73.77544F;
            legend5.Position.Y = 3F;
            this.realChart.Legends.Add(legend5);
            this.realChart.Location = new System.Drawing.Point(603, 282);
            this.realChart.Name = "realChart";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Real chart";
            this.realChart.Series.Add(series5);
            this.realChart.Size = new System.Drawing.Size(522, 398);
            this.realChart.TabIndex = 14;
            this.realChart.Text = "realChart";
            // 
            // u_function
            // 
            this.u_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u_function.Location = new System.Drawing.Point(803, 29);
            this.u_function.Name = "u_function";
            this.u_function.Size = new System.Drawing.Size(246, 27);
            this.u_function.TabIndex = 15;
            this.u_function.Text = "-x^3 + 1";
            // 
            // u_uh
            // 
            this.u_uh.Enabled = false;
            this.u_uh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u_uh.Location = new System.Drawing.Point(792, 221);
            this.u_uh.Name = "u_uh";
            this.u_uh.Size = new System.Drawing.Size(113, 27);
            this.u_uh.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(739, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "u(x) = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(693, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "||U-Uh||1 = ";
            // 
            // allCharts
            // 
            chartArea6.Name = "ChartArea1";
            this.allCharts.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.allCharts.Legends.Add(legend6);
            this.allCharts.Location = new System.Drawing.Point(57, 702);
            this.allCharts.Name = "allCharts";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Real Chart";
            this.allCharts.Series.Add(series6);
            this.allCharts.Size = new System.Drawing.Size(1056, 570);
            this.allCharts.TabIndex = 19;
            this.allCharts.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1137, 706);
            this.Controls.Add(this.allCharts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.u_uh);
            this.Controls.Add(this.u_function);
            this.Controls.Add(this.realChart);
            this.Controls.Add(this.uh1_value);
            this.Controls.Add(this.uh0_value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.n_value);
            this.Controls.Add(this.q_value);
            this.Controls.Add(this.f_function);
            this.Controls.Add(this.T_function);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCharts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox T_function;
        private System.Windows.Forms.TextBox f_function;
        private System.Windows.Forms.TextBox q_value;
        private System.Windows.Forms.TextBox n_value;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uh0_value;
        private System.Windows.Forms.TextBox uh1_value;
        private System.Windows.Forms.DataVisualization.Charting.Chart realChart;
        private System.Windows.Forms.TextBox u_function;
        private System.Windows.Forms.TextBox u_uh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart allCharts;
    }
}

