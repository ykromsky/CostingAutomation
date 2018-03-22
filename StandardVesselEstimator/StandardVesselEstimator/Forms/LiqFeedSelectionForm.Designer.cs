namespace StandardVesselEstimator
{
    partial class LiqFeedSelectionForm
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
            this.button_packageLaunch = new System.Windows.Forms.Button();
            this.groupBox_HW_SC = new System.Windows.Forms.GroupBox();
            this.radioButton_lfSC = new System.Windows.Forms.RadioButton();
            this.radioButton_lfHW = new System.Windows.Forms.RadioButton();
            this.groupBox_HX_M = new System.Windows.Forms.GroupBox();
            this.radioButton_lfM = new System.Windows.Forms.RadioButton();
            this.radioButton_lfHX = new System.Windows.Forms.RadioButton();
            this.checkBox_lfStandard = new System.Windows.Forms.CheckBox();
            this.comboBox_lfInputSize = new System.Windows.Forms.ComboBox();
            this.comboBox_lfOutputSize = new System.Windows.Forms.ComboBox();
            this.comboBox_lfExpansionSize = new System.Windows.Forms.ComboBox();
            this.comboBox_lfStandardType = new System.Windows.Forms.ComboBox();
            this.comboBox_lfStandardSize = new System.Windows.Forms.ComboBox();
            this.label_input = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.label_expansion = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.groupBox_HW_SC.SuspendLayout();
            this.groupBox_HX_M.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_packageLaunch
            // 
            this.button_packageLaunch.AutoSize = true;
            this.button_packageLaunch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_packageLaunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_packageLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_packageLaunch.ForeColor = System.Drawing.Color.Black;
            this.button_packageLaunch.Location = new System.Drawing.Point(802, 281);
            this.button_packageLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_packageLaunch.Name = "button_packageLaunch";
            this.button_packageLaunch.Size = new System.Drawing.Size(62, 29);
            this.button_packageLaunch.TabIndex = 4;
            this.button_packageLaunch.Text = "RUN";
            this.button_packageLaunch.UseVisualStyleBackColor = false;
            this.button_packageLaunch.Click += new System.EventHandler(this.button_packageLaunch_Click);
            // 
            // groupBox_HW_SC
            // 
            this.groupBox_HW_SC.Controls.Add(this.radioButton_lfSC);
            this.groupBox_HW_SC.Controls.Add(this.radioButton_lfHW);
            this.groupBox_HW_SC.Location = new System.Drawing.Point(262, 43);
            this.groupBox_HW_SC.Name = "groupBox_HW_SC";
            this.groupBox_HW_SC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_HW_SC.Size = new System.Drawing.Size(222, 119);
            this.groupBox_HW_SC.TabIndex = 5;
            this.groupBox_HW_SC.TabStop = false;
            // 
            // radioButton_lfSC
            // 
            this.radioButton_lfSC.AutoSize = true;
            this.radioButton_lfSC.Location = new System.Drawing.Point(24, 73);
            this.radioButton_lfSC.Name = "radioButton_lfSC";
            this.radioButton_lfSC.Size = new System.Drawing.Size(112, 24);
            this.radioButton_lfSC.TabIndex = 0;
            this.radioButton_lfSC.Text = "SEAL CAP";
            this.radioButton_lfSC.UseVisualStyleBackColor = true;
            // 
            // radioButton_lfHW
            // 
            this.radioButton_lfHW.AutoSize = true;
            this.radioButton_lfHW.Location = new System.Drawing.Point(24, 27);
            this.radioButton_lfHW.Name = "radioButton_lfHW";
            this.radioButton_lfHW.Size = new System.Drawing.Size(142, 24);
            this.radioButton_lfHW.TabIndex = 0;
            this.radioButton_lfHW.Text = "HAND WHEEL";
            this.radioButton_lfHW.UseVisualStyleBackColor = true;
            // 
            // groupBox_HX_M
            // 
            this.groupBox_HX_M.Controls.Add(this.radioButton_lfM);
            this.groupBox_HX_M.Controls.Add(this.radioButton_lfHX);
            this.groupBox_HX_M.Location = new System.Drawing.Point(262, 192);
            this.groupBox_HX_M.Name = "groupBox_HX_M";
            this.groupBox_HX_M.Size = new System.Drawing.Size(222, 117);
            this.groupBox_HX_M.TabIndex = 6;
            this.groupBox_HX_M.TabStop = false;
            // 
            // radioButton_lfM
            // 
            this.radioButton_lfM.AutoSize = true;
            this.radioButton_lfM.Location = new System.Drawing.Point(24, 71);
            this.radioButton_lfM.Name = "radioButton_lfM";
            this.radioButton_lfM.Size = new System.Drawing.Size(130, 24);
            this.radioButton_lfM.TabIndex = 0;
            this.radioButton_lfM.Text = "MOTORIZED";
            this.radioButton_lfM.UseVisualStyleBackColor = true;
            // 
            // radioButton_lfHX
            // 
            this.radioButton_lfHX.AutoSize = true;
            this.radioButton_lfHX.Location = new System.Drawing.Point(24, 25);
            this.radioButton_lfHX.Name = "radioButton_lfHX";
            this.radioButton_lfHX.Size = new System.Drawing.Size(177, 24);
            this.radioButton_lfHX.TabIndex = 0;
            this.radioButton_lfHX.Text = "HAND EXPANSION";
            this.radioButton_lfHX.UseVisualStyleBackColor = true;
            // 
            // checkBox_lfStandard
            // 
            this.checkBox_lfStandard.AutoSize = true;
            this.checkBox_lfStandard.Location = new System.Drawing.Point(535, 52);
            this.checkBox_lfStandard.Name = "checkBox_lfStandard";
            this.checkBox_lfStandard.Size = new System.Drawing.Size(162, 24);
            this.checkBox_lfStandard.TabIndex = 7;
            this.checkBox_lfStandard.Text = "RVS STANDARD";
            this.checkBox_lfStandard.UseVisualStyleBackColor = true;
            this.checkBox_lfStandard.CheckedChanged += new System.EventHandler(this.checkBox_standard_CheckedChanged);
            // 
            // comboBox_lfInputSize
            // 
            this.comboBox_lfInputSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lfInputSize.FormattingEnabled = true;
            this.comboBox_lfInputSize.Location = new System.Drawing.Point(52, 66);
            this.comboBox_lfInputSize.Name = "comboBox_lfInputSize";
            this.comboBox_lfInputSize.Size = new System.Drawing.Size(139, 28);
            this.comboBox_lfInputSize.TabIndex = 8;
            // 
            // comboBox_lfOutputSize
            // 
            this.comboBox_lfOutputSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lfOutputSize.FormattingEnabled = true;
            this.comboBox_lfOutputSize.Location = new System.Drawing.Point(52, 176);
            this.comboBox_lfOutputSize.Name = "comboBox_lfOutputSize";
            this.comboBox_lfOutputSize.Size = new System.Drawing.Size(139, 28);
            this.comboBox_lfOutputSize.TabIndex = 9;
            // 
            // comboBox_lfExpansionSize
            // 
            this.comboBox_lfExpansionSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lfExpansionSize.FormattingEnabled = true;
            this.comboBox_lfExpansionSize.Location = new System.Drawing.Point(53, 281);
            this.comboBox_lfExpansionSize.Name = "comboBox_lfExpansionSize";
            this.comboBox_lfExpansionSize.Size = new System.Drawing.Size(138, 28);
            this.comboBox_lfExpansionSize.TabIndex = 10;
            // 
            // comboBox_lfStandardType
            // 
            this.comboBox_lfStandardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lfStandardType.FormattingEnabled = true;
            this.comboBox_lfStandardType.Location = new System.Drawing.Point(535, 127);
            this.comboBox_lfStandardType.Name = "comboBox_lfStandardType";
            this.comboBox_lfStandardType.Size = new System.Drawing.Size(162, 28);
            this.comboBox_lfStandardType.TabIndex = 8;
            this.comboBox_lfStandardType.SelectedIndexChanged += new System.EventHandler(this.comboBox_lfStandardType_SelectedIndexChanged);
            // 
            // comboBox_lfStandardSize
            // 
            this.comboBox_lfStandardSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lfStandardSize.FormattingEnabled = true;
            this.comboBox_lfStandardSize.Location = new System.Drawing.Point(535, 223);
            this.comboBox_lfStandardSize.Name = "comboBox_lfStandardSize";
            this.comboBox_lfStandardSize.Size = new System.Drawing.Size(162, 28);
            this.comboBox_lfStandardSize.TabIndex = 8;
            this.comboBox_lfStandardSize.SelectedIndexChanged += new System.EventHandler(this.comboBox_lfStandardSize_SelectedIndexChanged);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(48, 43);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(97, 20);
            this.label_input.TabIndex = 11;
            this.label_input.Text = "INPUT SIZE";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(48, 153);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(114, 20);
            this.label_output.TabIndex = 11;
            this.label_output.Text = "OUTPUT SIZE";
            // 
            // label_expansion
            // 
            this.label_expansion.AutoSize = true;
            this.label_expansion.Location = new System.Drawing.Point(48, 254);
            this.label_expansion.Name = "label_expansion";
            this.label_expansion.Size = new System.Drawing.Size(143, 20);
            this.label_expansion.TabIndex = 11;
            this.label_expansion.Text = "EXPANSION SIZE";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(531, 104);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(50, 20);
            this.label_type.TabIndex = 11;
            this.label_type.Text = "TYPE";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(531, 200);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(46, 20);
            this.label_size.TabIndex = 11;
            this.label_size.Text = "SIZE";
            // 
            // LiqFeedSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(940, 356);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_expansion);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.comboBox_lfExpansionSize);
            this.Controls.Add(this.comboBox_lfOutputSize);
            this.Controls.Add(this.comboBox_lfStandardSize);
            this.Controls.Add(this.comboBox_lfStandardType);
            this.Controls.Add(this.comboBox_lfInputSize);
            this.Controls.Add(this.checkBox_lfStandard);
            this.Controls.Add(this.groupBox_HX_M);
            this.Controls.Add(this.groupBox_HW_SC);
            this.Controls.Add(this.button_packageLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(940, 356);
            this.Name = "LiqFeedSelectionForm";
            this.Text = "LiqFeedSelectionForm";
            this.groupBox_HW_SC.ResumeLayout(false);
            this.groupBox_HW_SC.PerformLayout();
            this.groupBox_HX_M.ResumeLayout(false);
            this.groupBox_HX_M.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_packageLaunch;
        private System.Windows.Forms.GroupBox groupBox_HW_SC;
        private System.Windows.Forms.RadioButton radioButton_lfSC;
        private System.Windows.Forms.RadioButton radioButton_lfHW;
        private System.Windows.Forms.GroupBox groupBox_HX_M;
        private System.Windows.Forms.RadioButton radioButton_lfM;
        private System.Windows.Forms.RadioButton radioButton_lfHX;
        private System.Windows.Forms.CheckBox checkBox_lfStandard;
        private System.Windows.Forms.ComboBox comboBox_lfInputSize;
        private System.Windows.Forms.ComboBox comboBox_lfOutputSize;
        private System.Windows.Forms.ComboBox comboBox_lfExpansionSize;
        private System.Windows.Forms.ComboBox comboBox_lfStandardType;
        private System.Windows.Forms.ComboBox comboBox_lfStandardSize;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_expansion;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_size;
    }
}