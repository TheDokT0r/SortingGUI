namespace SortingGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbx_data = new System.Windows.Forms.ListBox();
            this.txt_amountOfDataPoints = new System.Windows.Forms.TextBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.txt_loops = new System.Windows.Forms.Label();
            this.btn_undo = new System.Windows.Forms.Button();
            this.chart_SortingProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmb_sortingAlgrs = new System.Windows.Forms.ComboBox();
            this.btn_logs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_isSorted = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_randomize = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SortingProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(464, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(127, 39);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sorting";
            // 
            // lbx_data
            // 
            this.lbx_data.FormattingEnabled = true;
            this.lbx_data.Location = new System.Drawing.Point(847, 84);
            this.lbx_data.Name = "lbx_data";
            this.lbx_data.Size = new System.Drawing.Size(276, 537);
            this.lbx_data.TabIndex = 1;
            // 
            // txt_amountOfDataPoints
            // 
            this.txt_amountOfDataPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amountOfDataPoints.Location = new System.Drawing.Point(633, 84);
            this.txt_amountOfDataPoints.Name = "txt_amountOfDataPoints";
            this.txt_amountOfDataPoints.Size = new System.Drawing.Size(193, 31);
            this.txt_amountOfDataPoints.TabIndex = 2;
            this.txt_amountOfDataPoints.Text = "Index";
            this.txt_amountOfDataPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gen.Location = new System.Drawing.Point(677, 121);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(112, 35);
            this.btn_gen.TabIndex = 3;
            this.btn_gen.Text = "Generate";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Location = new System.Drawing.Point(684, 569);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(142, 52);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // txt_loops
            // 
            this.txt_loops.AutoSize = true;
            this.txt_loops.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loops.Location = new System.Drawing.Point(661, 169);
            this.txt_loops.Name = "txt_loops";
            this.txt_loops.Size = new System.Drawing.Size(137, 25);
            this.txt_loops.TabIndex = 5;
            this.txt_loops.Text = "Loops: NULL";
            // 
            // btn_undo
            // 
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_undo.Location = new System.Drawing.Point(536, 569);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(142, 52);
            this.btn_undo.TabIndex = 6;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // chart_SortingProgress
            // 
            chartArea2.Name = "cool";
            this.chart_SortingProgress.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "progress";
            legend2.Title = "Sorting Progress";
            this.chart_SortingProgress.Legends.Add(legend2);
            this.chart_SortingProgress.Location = new System.Drawing.Point(12, 74);
            this.chart_SortingProgress.Name = "chart_SortingProgress";
            series2.ChartArea = "cool";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "progress";
            series2.Name = "sorted (%)";
            this.chart_SortingProgress.Series.Add(series2);
            this.chart_SortingProgress.Size = new System.Drawing.Size(606, 314);
            this.chart_SortingProgress.TabIndex = 7;
            this.chart_SortingProgress.Text = "chart1";
            // 
            // txt_time
            // 
            this.txt_time.AutoSize = true;
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(661, 194);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(125, 25);
            this.txt_time.TabIndex = 8;
            this.txt_time.Text = "Time: NULL";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cmb_sortingAlgrs
            // 
            this.cmb_sortingAlgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sortingAlgrs.FormattingEnabled = true;
            this.cmb_sortingAlgrs.Location = new System.Drawing.Point(388, 539);
            this.cmb_sortingAlgrs.Name = "cmb_sortingAlgrs";
            this.cmb_sortingAlgrs.Size = new System.Drawing.Size(438, 24);
            this.cmb_sortingAlgrs.TabIndex = 9;
            // 
            // btn_logs
            // 
            this.btn_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logs.Location = new System.Drawing.Point(21, 569);
            this.btn_logs.Name = "btn_logs";
            this.btn_logs.Size = new System.Drawing.Size(181, 52);
            this.btn_logs.TabIndex = 10;
            this.btn_logs.Text = "Open logs";
            this.btn_logs.UseVisualStyleBackColor = true;
            this.btn_logs.Click += new System.EventHandler(this.btn_logs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(970, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load existing list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(21, 530);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(181, 39);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Remove Logs";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_isSorted
            // 
            this.btn_isSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_isSorted.Location = new System.Drawing.Point(729, 333);
            this.btn_isSorted.Name = "btn_isSorted";
            this.btn_isSorted.Size = new System.Drawing.Size(112, 35);
            this.btn_isSorted.TabIndex = 13;
            this.btn_isSorted.Text = "Is Sorted";
            this.btn_isSorted.UseVisualStyleBackColor = true;
            this.btn_isSorted.Click += new System.EventHandler(this.btn_isSorted_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 394);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(606, 37);
            this.progressBar.TabIndex = 14;
            this.progressBar.Visible = false;
            // 
            // btn_randomize
            // 
            this.btn_randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_randomize.Location = new System.Drawing.Point(388, 568);
            this.btn_randomize.Name = "btn_randomize";
            this.btn_randomize.Size = new System.Drawing.Size(142, 52);
            this.btn_randomize.TabIndex = 15;
            this.btn_randomize.Text = "Randomize";
            this.btn_randomize.UseVisualStyleBackColor = true;
            this.btn_randomize.Click += new System.EventHandler(this.btn_randomize_Click);
            // 
            // btn_config
            // 
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.Location = new System.Drawing.Point(208, 568);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(151, 52);
            this.btn_config.TabIndex = 16;
            this.btn_config.Text = "Config";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 633);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_randomize);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_isSorted);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_logs);
            this.Controls.Add(this.cmb_sortingAlgrs);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.chart_SortingProgress);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.txt_loops);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.txt_amountOfDataPoints);
            this.Controls.Add(this.lbx_data);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_SortingProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox lbx_data;
        private System.Windows.Forms.TextBox txt_amountOfDataPoints;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Label txt_loops;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SortingProgress;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmb_sortingAlgrs;
        private System.Windows.Forms.Button btn_logs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_isSorted;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_randomize;
        private System.Windows.Forms.Button btn_config;
    }
}

