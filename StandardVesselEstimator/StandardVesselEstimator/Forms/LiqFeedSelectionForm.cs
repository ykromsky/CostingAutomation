using System;
using System.Windows.Forms;

namespace StandardVesselEstimator
{
    public partial class LiqFeedSelectionForm : Form
    {
        ProductInfo productInfo;
        QuoteSheet qsheet;
        private bool isRvsStandard;


        public LiqFeedSelectionForm()
        {
            InitializeComponent();

            populate_input_size_combobox();
            populate_output_size_combobox();
            populate_expansion_size_combobox();
            populate_standard_type_combobox();
            populate_standard_size_combobox();

            this.radioButton_lfHW.Checked = true;
            this.radioButton_lfHX.Checked = true;

            isRvsStandard = false;
            this.checkBox_lfStandard.Checked = isRvsStandard;
            this.label_type.Visible = isRvsStandard;
            this.label_size.Visible = isRvsStandard;
            this.comboBox_lfStandardType.Visible = isRvsStandard;
            this.comboBox_lfStandardType.Enabled = isRvsStandard;
            this.comboBox_lfStandardSize.Visible = isRvsStandard;
            this.comboBox_lfStandardSize.Enabled = isRvsStandard;

            productInfo = new ProductInfo();
        }


        private void button_packageLaunch_Click(object sender, EventArgs e)
        {
            if(checkForInvalidInputs())
            {
                this.Hide();

                productInfo.productClass = "liquid feed";
                productInfo.lfIsSTD = this.checkBox_lfStandard.Checked;
                productInfo.lfType = this.comboBox_lfStandardType.Text;
                productInfo.lfSize = this.comboBox_lfStandardSize.Text;
                productInfo.lfIsHW = this.radioButton_lfHW.Checked;
                productInfo.lfIsHX = this.radioButton_lfHX.Checked;
                productInfo.lfInputSize = parseInch(this.comboBox_lfInputSize.Text);
                productInfo.lfOutputSize = parseInch(this.comboBox_lfOutputSize.Text);
                productInfo.lfExpansionSize = parseInch(this.comboBox_lfExpansionSize.Text);

                productInfo.getLiqFeedValues();

                qsheet = new QuoteSheet(productInfo);

                qsheet.Run_quotesheet();
                this.Close();
            }
        }


        private void populate_output_size_combobox()
        {
            ComboBox box = this.comboBox_lfOutputSize;

            box.Items.Clear();
            box.Items.Add("1\"");
            box.Items.Add("1.5\"");
            box.Items.Add("2\"");
            box.Items.Add("2.5\"");
            box.Items.Add("3\"");
            box.Items.Add("4\"");
            box.Items.Add("5\"");
            box.Items.Add("6\"");
            box.SelectedIndex = 0;
        }


        private void populate_input_size_combobox()
        {
            ComboBox box = this.comboBox_lfInputSize;

            box.Items.Clear();
            box.Items.Add("0.75\"");
            box.Items.Add("1\"");
            box.Items.Add("1.25\"");
            box.Items.Add("1.5\"");
            box.Items.Add("2\"");
            box.Items.Add("2.5\"");
            box.Items.Add("3\"");
   
            box.SelectedIndex = 0;
        }


        private void populate_expansion_size_combobox()
        {
            ComboBox box = this.comboBox_lfExpansionSize;

            box.Items.Clear();
            box.Items.Add("0.75\"");
            box.Items.Add("1\"");
            box.Items.Add("1.25\"");
            box.Items.Add("1.5\"");
            box.Items.Add("2\"");
            box.Items.Add("2.5\"");

            box.SelectedIndex = 0;
        }


        private void populate_standard_type_combobox()
        {
            ComboBox box = this.comboBox_lfStandardType;

            box.Items.Clear();
            box.Items.Add("DHXHTHW");
            box.Items.Add("DHXHTSC");
            box.Items.Add("DHXLTHW");
            box.Items.Add("DHXLTSC");
            box.Items.Add("DMHTHW");
            box.Items.Add("DMHTSC");
            box.Items.Add("DMLTHW");
            box.Items.Add("DMLTSC");

            box.SelectedIndex = 0;
        }


        private void populate_standard_size_combobox()
        {
            ComboBox box = this.comboBox_lfStandardSize;

            box.Items.Clear();
            box.Items.Add("075");
            box.Items.Add("100");
            box.Items.Add("125");
            box.Items.Add("150");
            box.Items.Add("200");
            box.Items.Add("250");
            box.Items.Add("300");

            box.SelectedIndex = 0;
        }


        private void checkBox_standard_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("check mark clicked");
            isRvsStandard = this.checkBox_lfStandard.Checked;

            this.label_type.Visible = isRvsStandard;
            this.label_size.Visible = isRvsStandard;
            this.comboBox_lfStandardType.Visible = isRvsStandard;
            this.comboBox_lfStandardType.Enabled = isRvsStandard;
            this.comboBox_lfStandardSize.Visible = isRvsStandard;
            this.comboBox_lfStandardSize.Enabled = isRvsStandard;

            this.comboBox_lfInputSize.Enabled = !isRvsStandard;
            this.comboBox_lfOutputSize.Enabled = !isRvsStandard;
            this.comboBox_lfExpansionSize.Enabled = !isRvsStandard;
            this.radioButton_lfHW.Enabled = !isRvsStandard;
            this.radioButton_lfSC.Enabled = !isRvsStandard;
            this.radioButton_lfHX.Enabled = !isRvsStandard;
            this.radioButton_lfM.Enabled = !isRvsStandard;
        }


        private double parseInch(string input)
        {
            return Convert.ToDouble(input.Remove(input.Length - 1));
        }


        private void comboBox_lfStandardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_lfStandardSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool checkForInvalidInputs()
        {
            if (parseInch(this.comboBox_lfOutputSize.Text) < parseInch(this.comboBox_lfInputSize.Text))
            {
                MessageBox.Show("output >= input");
                return false;
            }

            if (parseInch(this.comboBox_lfInputSize.Text) < parseInch(this.comboBox_lfExpansionSize.Text))
            {
                MessageBox.Show("input >= expansion");
                return false;
            }

            return true;
        }
    }
}
