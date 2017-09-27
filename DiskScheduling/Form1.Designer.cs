namespace DiskScheduling
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtTHM = new System.Windows.Forms.TextBox();
            this.cmbAlgo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.chrtSched = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtQue = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSol = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAbs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSched)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cylinder Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diskhead Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Work Que";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "THM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chart";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(68, 196);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(180, 28);
            this.txtSize.TabIndex = 5;
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(68, 260);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(180, 28);
            this.txtStart.TabIndex = 6;
            // 
            // txtTHM
            // 
            this.txtTHM.Enabled = false;
            this.txtTHM.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtTHM.Location = new System.Drawing.Point(331, 525);
            this.txtTHM.Name = "txtTHM";
            this.txtTHM.Size = new System.Drawing.Size(111, 24);
            this.txtTHM.TabIndex = 8;
            // 
            // cmbAlgo
            // 
            this.cmbAlgo.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgo.FormattingEnabled = true;
            this.cmbAlgo.Items.AddRange(new object[] {
            "FCFS",
            "SSTF",
            "SCAN",
            "LOOK",
            "CSCAN",
            "CLOOK"});
            this.cmbAlgo.Location = new System.Drawing.Point(68, 132);
            this.cmbAlgo.Name = "cmbAlgo";
            this.cmbAlgo.Size = new System.Drawing.Size(180, 28);
            this.cmbAlgo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Algorithm";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(111, 463);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 42);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chrtSched
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtSched.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtSched.Legends.Add(legend2);
            this.chrtSched.Location = new System.Drawing.Point(311, 129);
            this.chrtSched.Name = "chrtSched";
            this.chrtSched.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Work Que";
            this.chrtSched.Series.Add(series2);
            this.chrtSched.Size = new System.Drawing.Size(545, 291);
            this.chrtSched.TabIndex = 12;
            this.chrtSched.Text = "chart1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(231, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 37);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Disk Scheduling Algorithm";
            // 
            // txtQue
            // 
            this.txtQue.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQue.Location = new System.Drawing.Point(68, 358);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(180, 96);
            this.txtQue.TabIndex = 14;
            this.txtQue.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "*Separate values with comma";
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol.Location = new System.Drawing.Point(307, 488);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(15, 17);
            this.lblSol.TabIndex = 16;
            this.lblSol.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "=";
            // 
            // lblAbs
            // 
            this.lblAbs.AutoSize = true;
            this.lblAbs.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbs.Location = new System.Drawing.Point(307, 456);
            this.lblAbs.Name = "lblAbs";
            this.lblAbs.Size = new System.Drawing.Size(15, 17);
            this.lblAbs.TabIndex = 18;
            this.lblAbs.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblAbs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chrtSched);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlgo);
            this.Controls.Add(this.txtTHM);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtSched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtTHM;
        private System.Windows.Forms.ComboBox cmbAlgo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSched;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtQue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAbs;
    }
}

