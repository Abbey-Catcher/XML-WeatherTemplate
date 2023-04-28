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
            this.conditions6 = new System.Windows.Forms.PictureBox();
            this.date1 = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditions6)).BeginInit();
            this.SuspendLayout();
            // 
            // todaysForecast
            // 
            this.todaysForecast.BackColor = System.Drawing.Color.Transparent;
            this.todaysForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysForecast.ForeColor = System.Drawing.Color.White;
            this.todaysForecast.Location = new System.Drawing.Point(50, 10);
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
            this.forecastLabel.Location = new System.Drawing.Point(175, 10);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 63;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.SystemColors.Highlight;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.min.Location = new System.Drawing.Point(149, 345);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(50, 50);
            this.min.TabIndex = 67;
            this.min.Text = "min";
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Red;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.max.Location = new System.Drawing.Point(98, 344);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(50, 50);
            this.max.TabIndex = 66;
            this.max.Text = "max";
            // 
            // conditions6
            // 
            this.conditions6.Location = new System.Drawing.Point(99, 158);
            this.conditions6.Name = "conditions6";
            this.conditions6.Size = new System.Drawing.Size(100, 100);
            this.conditions6.TabIndex = 65;
            this.conditions6.TabStop = false;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.date1.Location = new System.Drawing.Point(36, 64);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(240, 74);
            this.date1.TabIndex = 64;
            this.date1.Text = "date";
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current
            // 
            this.current.BackColor = System.Drawing.Color.Transparent;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.current.Location = new System.Drawing.Point(101, 280);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(100, 32);
            this.current.TabIndex = 68;
            this.current.Text = "current";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.current);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.conditions6);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todaysForecast);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(325, 475);
            ((System.ComponentModel.ISupportInitialize)(this.conditions6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label todaysForecast;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.PictureBox conditions6;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label current;
    }
}
