namespace StandardVesselEstimator
{
    partial class VesselSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VesselSelectionForm));
            this.button_vesselLaunch = new System.Windows.Forms.Button();
            this.comboBox_vesselTypes = new System.Windows.Forms.ComboBox();
            this.comboBox_vesselSizes = new System.Windows.Forms.ComboBox();
            this.button_full_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_vesselLaunch
            // 
            this.button_vesselLaunch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_vesselLaunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_vesselLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vesselLaunch.ForeColor = System.Drawing.Color.Black;
            this.button_vesselLaunch.Location = new System.Drawing.Point(405, 18);
            this.button_vesselLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_vesselLaunch.Name = "button_vesselLaunch";
            this.button_vesselLaunch.Size = new System.Drawing.Size(184, 32);
            this.button_vesselLaunch.TabIndex = 0;
            this.button_vesselLaunch.Text = "RUN";
            this.button_vesselLaunch.UseVisualStyleBackColor = false;
            this.button_vesselLaunch.Click += new System.EventHandler(this.button_vesselLaunch_Click);
            // 
            // comboBox_vesselTypes
            // 
            this.comboBox_vesselTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vesselTypes.FormattingEnabled = true;
            this.comboBox_vesselTypes.Location = new System.Drawing.Point(18, 18);
            this.comboBox_vesselTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_vesselTypes.MaxDropDownItems = 25;
            this.comboBox_vesselTypes.Name = "comboBox_vesselTypes";
            this.comboBox_vesselTypes.Size = new System.Drawing.Size(182, 28);
            this.comboBox_vesselTypes.TabIndex = 2;
            this.comboBox_vesselTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_vesselTypes_SelectedIndexChanged);
            // 
            // comboBox_vesselSizes
            // 
            this.comboBox_vesselSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vesselSizes.FormattingEnabled = true;
            this.comboBox_vesselSizes.Location = new System.Drawing.Point(212, 18);
            this.comboBox_vesselSizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_vesselSizes.MaxDropDownItems = 25;
            this.comboBox_vesselSizes.Name = "comboBox_vesselSizes";
            this.comboBox_vesselSizes.Size = new System.Drawing.Size(182, 28);
            this.comboBox_vesselSizes.TabIndex = 2;
            // 
            // button_full_report
            // 
            this.button_full_report.BackColor = System.Drawing.Color.Red;
            this.button_full_report.Cursor = System.Windows.Forms.Cursors.No;
            this.button_full_report.Enabled = false;
            this.button_full_report.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_full_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_full_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_full_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_full_report.Location = new System.Drawing.Point(731, 13);
            this.button_full_report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_full_report.Name = "button_full_report";
            this.button_full_report.Size = new System.Drawing.Size(196, 43);
            this.button_full_report.TabIndex = 4;
            this.button_full_report.Text = "do not press";
            this.button_full_report.UseVisualStyleBackColor = false;
            this.button_full_report.Visible = false;
            this.button_full_report.Click += new System.EventHandler(this.button_full_report_Click);
            // 
            // VesselSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(940, 356);
            this.ControlBox = false;
            this.Controls.Add(this.button_full_report);
            this.Controls.Add(this.comboBox_vesselSizes);
            this.Controls.Add(this.comboBox_vesselTypes);
            this.Controls.Add(this.button_vesselLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(940, 356);
            this.Name = "VesselSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick Vessel For Extreme Estimation!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_vesselLaunch;
        private System.Windows.Forms.ComboBox comboBox_vesselTypes;
        private System.Windows.Forms.ComboBox comboBox_vesselSizes;
        private System.Windows.Forms.Button button_full_report;
    }
}