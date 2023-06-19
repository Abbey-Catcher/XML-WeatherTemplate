namespace XML_WeatherTemplate
{
    partial class SearchScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todaysForecast = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.goForecastBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(243, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 28);
            this.searchButton.TabIndex = 76;
            this.searchButton.Text = "Search";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(144, 13);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 75;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // todaysForecast
            // 
            this.todaysForecast.BackColor = System.Drawing.Color.Transparent;
            this.todaysForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysForecast.ForeColor = System.Drawing.Color.White;
            this.todaysForecast.Location = new System.Drawing.Point(39, 13);
            this.todaysForecast.Name = "todaysForecast";
            this.todaysForecast.Size = new System.Drawing.Size(83, 28);
            this.todaysForecast.TabIndex = 74;
            this.todaysForecast.Text = "Today";
            this.todaysForecast.Click += new System.EventHandler(this.todaysForecast_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchBox.Location = new System.Drawing.Point(44, 79);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(282, 35);
            this.searchBox.TabIndex = 77;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.goButton.Location = new System.Drawing.Point(44, 160);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(282, 84);
            this.goButton.TabIndex = 78;
            this.goButton.Text = "Get My Current Weather";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // goForecastBtn
            // 
            this.goForecastBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.goForecastBtn.Location = new System.Drawing.Point(44, 267);
            this.goForecastBtn.Name = "goForecastBtn";
            this.goForecastBtn.Size = new System.Drawing.Size(282, 84);
            this.goForecastBtn.TabIndex = 79;
            this.goForecastBtn.Text = "Get Forecast Weather";
            this.goForecastBtn.UseVisualStyleBackColor = true;
            this.goForecastBtn.Click += new System.EventHandler(this.goForecastBtn_Click);
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.goForecastBtn);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todaysForecast);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(379, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchButton;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todaysForecast;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button goForecastBtn;
    }
}
