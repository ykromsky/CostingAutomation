namespace StandardVesselEstimator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_main_vessel = new System.Windows.Forms.Button();
            this.button_main_package = new System.Windows.Forms.Button();
            this.button_main_liquidFeed = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_main_vessel);
            this.flowLayoutPanel1.Controls.Add(this.button_main_package);
            this.flowLayoutPanel1.Controls.Add(this.button_main_liquidFeed);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1381, 332);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button_main_vessel
            // 
            this.button_main_vessel.AutoSize = true;
            this.button_main_vessel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_main_vessel.Image = global::StandardVesselEstimator.Properties.Resources.vessel;
            this.button_main_vessel.Location = new System.Drawing.Point(3, 3);
            this.button_main_vessel.Name = "button_main_vessel";
            this.button_main_vessel.Size = new System.Drawing.Size(454, 328);
            this.button_main_vessel.TabIndex = 0;
            this.button_main_vessel.Text = "STANDARD VESSEL";
            this.button_main_vessel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_main_vessel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_main_vessel.UseVisualStyleBackColor = true;
            this.button_main_vessel.Click += new System.EventHandler(this.button_main_vessel_Click);
            // 
            // button_main_package
            // 
            this.button_main_package.AutoSize = true;
            this.button_main_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_main_package.Image = global::StandardVesselEstimator.Properties.Resources.package;
            this.button_main_package.Location = new System.Drawing.Point(463, 3);
            this.button_main_package.Name = "button_main_package";
            this.button_main_package.Size = new System.Drawing.Size(454, 328);
            this.button_main_package.TabIndex = 0;
            this.button_main_package.Text = "STANDARD PACKAGE";
            this.button_main_package.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_main_package.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_main_package.UseVisualStyleBackColor = true;
            this.button_main_package.Click += new System.EventHandler(this.button_main_package_Click);
            // 
            // button_main_liquidFeed
            // 
            this.button_main_liquidFeed.AutoSize = true;
            this.button_main_liquidFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_main_liquidFeed.Image = global::StandardVesselEstimator.Properties.Resources.lf_25;
            this.button_main_liquidFeed.Location = new System.Drawing.Point(923, 3);
            this.button_main_liquidFeed.Name = "button_main_liquidFeed";
            this.button_main_liquidFeed.Size = new System.Drawing.Size(454, 328);
            this.button_main_liquidFeed.TabIndex = 0;
            this.button_main_liquidFeed.Text = "LIQUID FEED";
            this.button_main_liquidFeed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_main_liquidFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_main_liquidFeed.UseVisualStyleBackColor = true;
            this.button_main_liquidFeed.Click += new System.EventHandler(this.button_main_liquidFeed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1405, 356);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 356);
            this.Name = "MainForm";
            this.Text = "Do you want to estimate a vessel or a package?";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_main_vessel;
        private System.Windows.Forms.Button button_main_package;
        private System.Windows.Forms.Button button_main_liquidFeed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}