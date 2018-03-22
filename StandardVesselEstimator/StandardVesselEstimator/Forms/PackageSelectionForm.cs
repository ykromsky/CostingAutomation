using System;
using System.Windows.Forms;

namespace StandardVesselEstimator
{
    public partial class PackageSelectionForm : Form
    {
        ProductInfo productInfo;
        QuoteSheet qsheet;


        public PackageSelectionForm()
        {
            InitializeComponent();

            populate_package_type_combobox();
            populate_package_vessel_size_combobox();
            populate_secondary_sizes();
            productInfo = new ProductInfo();
        }


        private void button_packageLaunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            productInfo.productClass = "package";
            productInfo.PackageType = this.comboBox_packageTypes.Text;
            productInfo.PackageSize = this.comboBox_packageVesselSizes.Text;
            productInfo.SecondarySize = this.comboBox_packageSecondarySizes.Text;
            productInfo.MpcHxIsolationValves = this.checkBox_hxIsolationValves.Checked;


            productInfo.getPackageValues();

            qsheet = new QuoteSheet(productInfo);

            qsheet.Run_quotesheet();
            this.Close();
        }


        private void comboBox_packageTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_package_vessel_size_combobox();
            populate_secondary_sizes();

            switch (this.comboBox_packageTypes.Text)
            {
                case "MRP-V":
                case "MRP-H":
                case "MVI":
                case "MVIC":
                    this.checkBox_hxIsolationValves.Visible = false;
                    break;

                case "MPC":
                    this.checkBox_hxIsolationValves.Visible = true;
                    break;

                default:
                    break;
            }
        }


        private void populate_package_type_combobox()
        {
            ComboBox box = this.comboBox_packageTypes;

            box.Items.Clear();
            box.Items.Add("MRP-V");
            box.Items.Add("MRP-H");
            box.Items.Add("MPC");
            box.Items.Add("MVI");
            box.Items.Add("MVIC");
            box.SelectedIndex = 0;
        }


        private void populate_package_vessel_size_combobox()
        {
            ComboBox box = this.comboBox_packageVesselSizes;

            box.Items.Clear();

            switch (this.comboBox_packageTypes.Text)
            {
                case "MRP-V":
                    mrpv_sizes(box);
                    break;

                case "MRP-H":
                    mrph_sizes(box);
                    break;

                case "MPC":
                    mpc_sizes(box);
                    break;

                case "MVI":
                    mvi_sizes(box);
                    break;

                case "MVIC":
                    mvic_sizes(box);
                    break;

                default:
                    box.Items.Add("UNKNOWN PACKAGE TYPE");
                    break;
            }
        }


        private void mrpv_sizes(ComboBox box)
        {
            box.Items.Add("MRP-24V");
            box.Items.Add("MRP-30V");
            box.Items.Add("MRP-36V");
            box.Items.Add("MRP-42V");
            box.Items.Add("MRP-48V");
            box.Items.Add("MRP-54V");
            box.Items.Add("MRP-60V");
            box.Items.Add("MRP-72V");
            box.Items.Add("MRP-84V");
            box.Items.Add("MRP-96V");
            box.Items.Add("MRP-108V");
            box.Items.Add("MRP-120V");
            box.Items.Add("MRP-144V");

            box.SelectedIndex = 0;
        }


        private void mrph_sizes(ComboBox box)
        {
            box.Items.Add("MRP-24H");
            box.Items.Add("MRP-30H");
            box.Items.Add("MRP-36H");
            box.Items.Add("MRP-42H");
            box.Items.Add("MRP-48H");
            box.Items.Add("MRP-54H");
            box.Items.Add("MRP-60H");
            box.Items.Add("MRP-72H");
            box.Items.Add("MRP-84H");
            box.Items.Add("MRP-96H");
            box.Items.Add("MRP-108H");
            box.Items.Add("MRP-120H");
            box.Items.Add("MRP-144H");

            box.SelectedIndex = 0;
        }


        private void mpc_sizes(ComboBox box)
        {
            box.Items.Add("MPC-20");
            box.Items.Add("MPC-24");
            box.Items.Add("MPC-30");
            box.Items.Add("MPC-36");
            box.Items.Add("MPC-42");
            box.Items.Add("MPC-48");
            box.Items.Add("MPC-54");
            box.Items.Add("MPC-60");

            box.SelectedIndex = 0;
        }


        private void mvi_sizes(ComboBox box)
        {
            box.Items.Add("MVI-16");
            box.Items.Add("MVI-20");
            box.Items.Add("MVI-24");
            box.Items.Add("MVI-30");
            box.Items.Add("MVI-36");
            box.Items.Add("MVI-42");
            box.Items.Add("MVI-48");
            box.Items.Add("MVI-54");
            box.Items.Add("MVI-60");
            box.Items.Add("MVI-72");
            box.Items.Add("MVI-84");
            box.Items.Add("MVI-96");
            box.Items.Add("MVI-108");
            box.Items.Add("MVI-120");
            box.Items.Add("MVI-144");

            box.SelectedIndex = 0;
        }


        private void mvic_sizes(ComboBox box)
        {
            box.Items.Add("MVIC-16");
            box.Items.Add("MVIC-20");
            box.Items.Add("MVIC-24");
            box.Items.Add("MVIC-30");
            box.Items.Add("MVIC-36");
            box.Items.Add("MVIC-42");
            box.Items.Add("MVIC-48");
            box.Items.Add("MVIC-54");
            box.Items.Add("MVIC-60");
            box.Items.Add("MVIC-72");
            box.Items.Add("MVIC-84");
            box.Items.Add("MVIC-96");
            box.Items.Add("MVIC-108");
            box.Items.Add("MVIC-120");
            box.Items.Add("MVIC-144");

            box.SelectedIndex = 0;
        }


        private void populate_secondary_sizes()
        {
            ComboBox box = this.comboBox_packageSecondarySizes;

            box.Items.Clear();

            switch (this.comboBox_packageTypes.Text)
            {
                case "MRP-H":
                case "MRP-V":
                    box.Items.Add("60-30");
                    box.Items.Add("60-45");
                    box.Items.Add("120-30");
                    box.Items.Add("120-45");
                    box.Items.Add("160-70");
                    box.Items.Add("190-30");
                    box.Items.Add("190-45");
                    box.Items.Add("270-30");
                    box.Items.Add("270-45");
                    box.Items.Add("375-30");
                    box.Items.Add("375-45");
                    box.Items.Add("480-30");
                    box.Items.Add("480-45");
                    break;

                case "MPC":
                    box.Items.Add("4\" PORTS");
                    box.Items.Add("6\" PORTS");
                    box.Items.Add("8\" PORTS");
                    box.Items.Add("10\" PORTS");
                    box.Items.Add("12\" PORTS");
                    break;

                case "MVI":
                case "MVIC":
                default:
                    break;
            }

            if(box.Items.Count > 0) box.SelectedIndex = 0;
        }
    }
}
