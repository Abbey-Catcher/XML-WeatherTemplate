namespace XML_WeatherTemplate
{
    partial class CurrentScreen
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
            this.todaysForecast = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.conditionsBox = new System.Windows.Forms.PictureBox();
            this.date1 = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // todaysForecast
            // 
            this.todaysForecast.BackColor = System.Drawing.Color.Transparent;
            this.todaysForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysForecast.ForeColor = System.Drawing.Color.White;
            this.todaysForecast.Location = new System.Drawing.Point(13, 10);
            this.todaysForecast.Name = "todaysForecast";
            this.todaysForecast.Size = new System.Drawing.Size(83, 28);
            this.todaysForecast.TabIndex = 62;
            this.todaysForecast.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(118, 10);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 63;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.SystemColors.Highlight;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.min.Location = new System.Drawing.Point(66, 344);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(50, 50);
            this.min.TabIndex = 67;
            this.min.Text = "min";
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Red;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.max.Location = new System.Drawing.Point(14, 344);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(50, 50);
            this.max.TabIndex = 66;
            this.max.Text = "max";
            // 
            // conditionsBox
            // 
            this.conditionsBox.BackColor = System.Drawing.Color.Transparent;
            this.conditionsBox.Location = new System.Drawing.Point(90, 127);
            this.conditionsBox.Name = "conditionsBox";
            this.conditionsBox.Size = new System.Drawing.Size(150, 150);
            this.conditionsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.conditionsBox.TabIndex = 65;
            this.conditionsBox.TabStop = false;
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.date1.Location = new System.Drawing.Point(163, 62);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(159, 74);
            this.date1.TabIndex = 64;
            this.date1.Text = "date";
            this.date1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // current
            // 
            this.current.BackColor = System.Drawing.Color.Transparent;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.current.Location = new System.Drawing.Point(51, 280);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(229, 36);
            this.current.TabIndex = 68;
            this.current.Text = "current";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cityOutput.Location = new System.Drawing.Point(3, 62);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(159, 62);
            this.cityOutput.TabIndex = 69;
            this.cityOutput.Text = "city";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastUpdatedLabel.Location = new System.Drawing.Point(23, 411);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(277, 48);
            this.lastUpdatedLabel.TabIndex = 70;
            this.lastUpdatedLabel.Text = "lastUpdated";
            this.lastUpdatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunriseLabel.Location = new System.Drawing.Point(165, 316);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(135, 38);
            this.sunriseLabel.TabIndex = 71;
            this.sunriseLabel.Text = "sunrise";
            this.sunriseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunsetLabel.Location = new System.Drawing.Point(165, 371);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(135, 38);
            this.sunsetLabel.TabIndex = 72;
            this.sunsetLabel.Text = "sunset";
            this.sunsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(217, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 28);
            this.searchButton.TabIndex = 73;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.lastUpdatedLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.current);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.conditionsBox);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todaysForecast);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(325, 475);
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label todaysForecast;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.PictureBox conditionsBox;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label lastUpdatedLabel;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label searchButton;
    }
}
