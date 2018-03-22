using System;
using System.Windows.Forms;

namespace StandardVesselEstimator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_main_vessel_Click(object sender, EventArgs e)
        {
            VesselSelectionForm vesselSelectionForm = new VesselSelectionForm();

            this.Visible = false;

            vesselSelectionForm.Visible = true;
        }

        private void button_main_package_Click(object sender, EventArgs e)
        {
            PackageSelectionForm packageSelectionForm = new PackageSelectionForm();

            this.Visible = false;

            packageSelectionForm.Visible = true;
        }

        private void button_main_liquidFeed_Click(object sender, EventArgs e)
        {
            LiqFeedSelectionForm liqFeedSelectionForm = new LiqFeedSelectionForm();

            this.Visible = false;

            liqFeedSelectionForm.Visible = true;
        }
    }
}
