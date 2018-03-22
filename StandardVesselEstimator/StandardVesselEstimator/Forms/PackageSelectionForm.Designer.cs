namespace StandardVesselEstimator
{
    partial class PackageSelectionForm
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
            this.comboBox_packageVesselSizes = new System.Windows.Forms.ComboBox();
            this.comboBox_packageTypes = new System.Windows.Forms.ComboBox();
            this.button_packageLaunch = new System.Windows.Forms.Button();
            this.comboBox_packageSecondarySizes = new System.Windows.Forms.ComboBox();
            this.checkBox_hxIsolationValves = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox_packageVesselSizes
            // 
            this.comboBox_packageVesselSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_packageVesselSizes.FormattingEnabled = true;
            this.comboBox_packageVesselSizes.Location = new System.Drawing.Point(207, 14);
            this.comboBox_packageVesselSizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_packageVesselSizes.MaxDropDownItems = 25;
            this.comboBox_packageVesselSizes.Name = "comboBox_packageVesselSizes";
            this.comboBox_packageVesselSizes.Size = new System.Drawing.Size(182, 28);
            this.comboBox_packageVesselSizes.TabIndex = 5;
            // 
            // comboBox_packageTypes
            // 
            this.comboBox_packageTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_packageTypes.FormattingEnabled = true;
            this.comboBox_packageTypes.Location = new System.Drawing.Point(13, 14);
            this.comboBox_packageTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_packageTypes.MaxDropDownItems = 25;
            this.comboBox_packageTypes.Name = "comboBox_packageTypes";
            this.comboBox_packageTypes.Size = new System.Drawing.Size(182, 28);
            this.comboBox_packageTypes.TabIndex = 4;
            this.comboBox_packageTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_packageTypes_SelectedIndexChanged);
            // 
            // button_packageLaunch
            // 
            this.button_packageLaunch.AutoSize = true;
            this.button_packageLaunch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_packageLaunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_packageLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_packageLaunch.ForeColor = System.Drawing.Color.Black;
            this.button_packageLaunch.Location = new System.Drawing.Point(587, 11);
            this.button_packageLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_packageLaunch.Name = "button_packageLaunch";
            this.button_packageLaunch.Size = new System.Drawing.Size(62, 29);
            this.button_packageLaunch.TabIndex = 3;
            this.button_packageLaunch.Text = "RUN";
            this.button_packageLaunch.UseVisualStyleBackColor = false;
            this.button_packageLaunch.Click += new System.EventHandler(this.button_packageLaunch_Click);
            // 
            // comboBox_packageSecondarySizes
            // 
            this.comboBox_packageSecondarySizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_packageSecondarySizes.FormattingEnabled = true;
            this.comboBox_packageSecondarySizes.Location = new System.Drawing.Point(397, 14);
            this.comboBox_packageSecondarySizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_packageSecondarySizes.MaxDropDownItems = 25;
            this.comboBox_packageSecondarySizes.Name = "comboBox_packageSecondarySizes";
            this.comboBox_packageSecondarySizes.Size = new System.Drawing.Size(182, 28);
            this.comboBox_packageSecondarySizes.TabIndex = 5;
            // 
            // checkBox_hxIsolationValves
            // 
            this.checkBox_hxIsolationValves.AutoSize = true;
            this.checkBox_hxIsolationValves.Checked = true;
            this.checkBox_hxIsolationValves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_hxIsolationValves.Location = new System.Drawing.Point(397, 50);
            this.checkBox_hxIsolationValves.Name = "checkBox_hxIsolationValves";
            this.checkBox_hxIsolationValves.Size = new System.Drawing.Size(173, 24);
            this.checkBox_hxIsolationValves.TabIndex = 6;
            this.checkBox_hxIsolationValves.Text = "HX Isolation Valves";
            this.checkBox_hxIsolationValves.UseVisualStyleBackColor = true;
            this.checkBox_hxIsolationValves.Visible = false;
            // 
            // PackageSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(940, 356);
            this.Controls.Add(this.checkBox_hxIsolationValves);
            this.Controls.Add(this.comboBox_packageSecondarySizes);
            this.Controls.Add(this.comboBox_packageVesselSizes);
            this.Controls.Add(this.comboBox_packageTypes);
            this.Controls.Add(this.button_packageLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(940, 356);
            this.Name = "PackageSelectionForm";
            this.Text = "PackageSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_packageVesselSizes;
        private System.Windows.Forms.ComboBox comboBox_packageTypes;
        private System.Windows.Forms.Button button_packageLaunch;
        private System.Windows.Forms.ComboBox comboBox_packageSecondarySizes;
        private System.Windows.Forms.CheckBox checkBox_hxIsolationValves;
    }
}