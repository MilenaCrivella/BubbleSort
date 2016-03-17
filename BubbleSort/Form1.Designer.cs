namespace BubbleSort
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Elementos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddNumbers);
            // 
            // Graphic
            // 
            chartArea2.Name = "ChartArea1";
            this.Graphic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Graphic.Legends.Add(legend2);
            this.Graphic.Location = new System.Drawing.Point(3, 3);
            this.Graphic.Name = "Graphic";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.Graphic.Series.Add(series2);
            this.Graphic.Size = new System.Drawing.Size(300, 300);
            this.Graphic.TabIndex = 2;
            this.Graphic.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 334);
            this.Controls.Add(this.Graphic);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BubbleSort";
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic;
    }
}

