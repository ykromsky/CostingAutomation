using Microsoft.Office.Tools.Ribbon;

namespace StandardVesselEstimator
{
    public partial class CustomRibbon
    {
        private void CustomRibbon_Load(object sender, RibbonUIEventArgs e) { }

        private void button_start_Click(object sender, RibbonControlEventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.Visible = true;
        }
    }
}
