using System;
using System.Windows.Forms;

namespace StandardVesselEstimator
{
    public partial class VesselSelectionForm : Form
    {
        ProductInfo productInfo;
        QuoteSheet qsheet;


        public VesselSelectionForm()
        {
            InitializeComponent();

            populate_vessel_type_combobox();
            populate_vessel_size_combobox();
            productInfo = new ProductInfo();
        }


        private void button_vesselLaunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            productInfo.productClass = "vessel";
            productInfo.VesselType = this.comboBox_vesselTypes.Text;
            productInfo.Tag = this.comboBox_vesselSizes.Text;
            productInfo.getVesselValues();

            qsheet = new QuoteSheet(productInfo);

            qsheet.Run_quotesheet();

            this.Close();
        }


        private void comboBox_vesselTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_vessel_size_combobox();
        }


        private void populate_vessel_type_combobox()
        {
            ComboBox box = this.comboBox_vesselTypes;

            box.Items.Clear();
            box.Items.Add("HHPR");
            box.Items.Add("VHPR");
            box.Items.Add("VHPTSR");
            box.Items.Add("HTSR");
            box.Items.Add("VTSR");
            box.Items.Add("VCPR");
            box.Items.Add("VPR");
            box.Items.Add("VR");
            box.Items.Add("HR");
            box.Items.Add("VI");
            box.Items.Add("VIC");
            box.Items.Add("HA");
            box.Items.Add("VA");
            box.Items.Add("VAC");
            box.Items.Add("VSD");
            box.Items.Add("HSD");
            box.Items.Add("MHSD");
            box.Items.Add("HOP");
            box.SelectedIndex = 0;
        }


        private void populate_vessel_size_combobox()
        {
            ComboBox box = this.comboBox_vesselSizes;

            box.Items.Clear();

            switch(this.comboBox_vesselTypes.Text)
            {
                case "HHPR":
                    hhpr_sizes(box);
                    break;

                case "VHPR":
                    vhpr_sizes(box);
                    break;

                case "VHPTSR":
                    vhptsr_sizes(box);
                    break;

                case "HTSR":
                    htsr_sizes(box);
                    break;

                case "VTSR":
                    vtsr_sizes(box);
                    break;

                case "VCPR":
                    vcpr_sizes(box);
                    break;

                case "VPR":
                    vpr_sizes(box);
                    break;

                case "VR":
                    vr_sizes(box);
                    break;

                case "HR":
                    hr_sizes(box);
                    break;

                case "VI":
                    vi_sizes(box);
                    break;

                case "VIC":
                    vic_sizes(box);
                    break;

                case "HA":
                    ha_sizes(box);
                    break;

                case "VA":
                    va_sizes(box);
                    break;

                case "VAC":
                    vac_sizes(box);
                    break;

                case "VSD":
                    vsd_sizes(box);
                    break;

                case "HSD":
                    hsd_sizes(box);
                    break;

                case "MHSD":
                    mhsd_sizes(box);
                    break;

                case "HOP":
                    hop_sizes(box);
                    break;

                default:
                    box.Items.Add("UNKNOWN VESSEL TYPE");
                    break;
            }

            box.SelectedIndex = 0;
        }


        private void hhpr_sizes(ComboBox box)
        {
            box.Items.Add("HHPR20-96");
            box.Items.Add("HHPR20-144");
            box.Items.Add("HHPR24-144");
            box.Items.Add("HHPR24-192");
            box.Items.Add("HHPR30-138");
            box.Items.Add("HHPR36-141");
            box.Items.Add("HHPR42-144");
            box.Items.Add("HHPR48-147");
            box.Items.Add("HHPR48-266");
            box.Items.Add("HHPR54-150");
            box.Items.Add("HHPR54-269");
            box.Items.Add("HHPR60-153");
            box.Items.Add("HHPR60-272");
            box.Items.Add("HHPR72-159");
            box.Items.Add("HHPR72-276");
            box.Items.Add("HHPR84-165");
            box.Items.Add("HHPR84-282");
            box.Items.Add("HHPR96-171");
            box.Items.Add("HHPR96-288");
            box.Items.Add("HHPR108-177");
            box.Items.Add("HHPR108-296");
            box.Items.Add("HHPR120-183");
            box.Items.Add("HHPR120-302");
            box.Items.Add("HHPR144-195");
            box.Items.Add("HHPR144-314");
        }

        private void vhpr_sizes(ComboBox box)
        {
            box.Items.Add("VHPR20-144");
            box.Items.Add("VHPR24-144");
            box.Items.Add("VHPR30-138");
            box.Items.Add("VHPR36-141");
            box.Items.Add("VHPR42-144");
            box.Items.Add("VHPR48-147");
            box.Items.Add("VHPR48-195");
            box.Items.Add("VHPR54-150");
            box.Items.Add("VHPR54-198");
            box.Items.Add("VHPR60-153");
            box.Items.Add("VHPR60-201");
            box.Items.Add("VHPR72-159");
            box.Items.Add("VHPR72-207");
            box.Items.Add("VHPR84-165");
            box.Items.Add("VHPR84-213");
            box.Items.Add("VHPR96-171");
            box.Items.Add("VHPR96-219");
            box.Items.Add("VHPR108-177");
            box.Items.Add("VHPR108-225");
            box.Items.Add("VHPR120-183");
            box.Items.Add("VHPR120-231");
            box.Items.Add("VHPR144-195");
            box.Items.Add("VHPR144-243");
        }

        private void vhptsr_sizes(ComboBox box)
        {
            box.Items.Add("VHPTSR36-141");
            box.Items.Add("VHPTSR48-195");
            box.Items.Add("VHPTSR54-198");
            box.Items.Add("VHPTSR60-201");
            box.Items.Add("VHPTSR72-207");
            box.Items.Add("VHPTSR84-213");
            box.Items.Add("VHPTSR96-219");
            box.Items.Add("VHPTSR108-225");
            box.Items.Add("VHPTSR120-231");
            box.Items.Add("VHPTSR144-243");
        }

        private void htsr_sizes(ComboBox box)
        {
            box.Items.Add("HTSR8-48");
            box.Items.Add("HTSR10-48");
            box.Items.Add("HTSR12-48");
            box.Items.Add("HTSR12-72");
            box.Items.Add("HTSR16-72");
            box.Items.Add("HTSR20-72");
            box.Items.Add("HTSR24-72");
            box.Items.Add("HTSR30-84");
            box.Items.Add("HTSR36-96");
            box.Items.Add("HTSR42-120");
            box.Items.Add("HTSR48-147");
        }

        private void vtsr_sizes(ComboBox box)
        {
            box.Items.Add("VTSR8-48");
            box.Items.Add("VTSR10-48");
            box.Items.Add("VTSR12-48");
            box.Items.Add("VTSR12-72");
            box.Items.Add("VTSR16-72");
            box.Items.Add("VTSR20-72");
            box.Items.Add("VTSR24-72");
            box.Items.Add("VTSR30-84");
        }

        private void vcpr_sizes(ComboBox box)
        {
            box.Items.Add("VCPR20-144");
            box.Items.Add("VCPR24-144");
            box.Items.Add("VCPR30-138");
            box.Items.Add("VCPR36-141");
            box.Items.Add("VCPR42-144");
            box.Items.Add("VCPR48-147");
            box.Items.Add("VCPR54-150");
            box.Items.Add("VCPR60-153");
            box.Items.Add("VCPR72-159");
            box.Items.Add("VCPR84-165");
            box.Items.Add("VCPR96-171");
        }

        private void vpr_sizes(ComboBox box)
        {
            box.Items.Add("VPR10-48");
            box.Items.Add("VPR12-48");
            box.Items.Add("VPR16-60");
            box.Items.Add("VPR20-60");
            box.Items.Add("VPR24-72");
        }

        private void vr_sizes(ComboBox box)
        {
            box.Items.Add("VR24-112");
            box.Items.Add("VR30-115");
            box.Items.Add("VR36-118");
            box.Items.Add("VR42-144");
            box.Items.Add("VR48-147");
            box.Items.Add("VR54-150");
            box.Items.Add("VR60-153");
            box.Items.Add("VR72-159");
            box.Items.Add("VR84-165");
            box.Items.Add("VR96-171");
            box.Items.Add("VR108-177");
            box.Items.Add("VR120-183");
            box.Items.Add("VR144-195");
        }

        private void hr_sizes(ComboBox box)
        {
            box.Items.Add("HR24-135");
            box.Items.Add("HR30-138");
            box.Items.Add("HR36-141");
            box.Items.Add("HR42-144");
            box.Items.Add("HR48-147");
            box.Items.Add("HR54-150");
            box.Items.Add("HR60-153");
            box.Items.Add("HR72-159");
            box.Items.Add("HR84-165");
            box.Items.Add("HR96-171");
            box.Items.Add("HR108-177");
            box.Items.Add("HR120-183");
            box.Items.Add("HR144-195");
        }

        private void vi_sizes(ComboBox box)
        {
            box.Items.Add("VI16-96");
            box.Items.Add("VI20-108");
            box.Items.Add("VI24-112");
            box.Items.Add("VI30-115");
            box.Items.Add("VI36-118");
            box.Items.Add("VI42-144");
            box.Items.Add("VI48-147");
            box.Items.Add("VI54-150");
            box.Items.Add("VI60-153");
            box.Items.Add("VI72-159");
            box.Items.Add("VI84-165");
            box.Items.Add("VI96-171");
            box.Items.Add("VI108-177");
            box.Items.Add("VI120-183");
            box.Items.Add("VI144-195");
        }

        private void vic_sizes(ComboBox box)
        {
            box.Items.Add("VIC16-96");
            box.Items.Add("VIC20-108");
            box.Items.Add("VIC24-112");
            box.Items.Add("VIC30-115");
            box.Items.Add("VIC36-118");
            box.Items.Add("VIC42-144");
            box.Items.Add("VIC48-147");
            box.Items.Add("VIC54-150");
            box.Items.Add("VIC60-153");
            box.Items.Add("VIC72-159");
            box.Items.Add("VIC84-165");
            box.Items.Add("VIC96-171");
            box.Items.Add("VIC108-177");
            box.Items.Add("VIC120-183");
            box.Items.Add("VIC144-195");
        }

        private void ha_sizes(ComboBox box)
        {
            box.Items.Add("HA24-135");
            box.Items.Add("HA30-138");
            box.Items.Add("HA36-141");
            box.Items.Add("HA42-144");
            box.Items.Add("HA48-147");
            box.Items.Add("HA54-150");
            box.Items.Add("HA60-153");
            box.Items.Add("HA72-159");
            box.Items.Add("HA84-165");
            box.Items.Add("HA96-171");
            box.Items.Add("HA108-177");
            box.Items.Add("HA120-183");
            box.Items.Add("HA144-195");
        }

        private void va_sizes(ComboBox box)
        {
            box.Items.Add("VA12-72");
            box.Items.Add("VA16-85");
            box.Items.Add("VA20-87");
            box.Items.Add("VA24-88");
            box.Items.Add("VA30-115");
            box.Items.Add("VA36-118");
            box.Items.Add("VA42-121");
            box.Items.Add("VA48-147");
            box.Items.Add("VA54-150");
            box.Items.Add("VA60-153");
            box.Items.Add("VA72-159");
            box.Items.Add("VA84-165");
            box.Items.Add("VA96-171");
            box.Items.Add("VA108-177");
            box.Items.Add("VA120-183");
            box.Items.Add("VA144-195");
        }

        private void vac_sizes(ComboBox box)
        {
            box.Items.Add("VAC16-85");
            box.Items.Add("VAC20-87");
            box.Items.Add("VAC24-88");
            box.Items.Add("VAC30-115");
            box.Items.Add("VAC36-118");
            box.Items.Add("VAC42-121");
            box.Items.Add("VAC48-147");
            box.Items.Add("VAC54-150");
            box.Items.Add("VAC60-153");
            box.Items.Add("VAC72-159");
            box.Items.Add("VAC84-165");
            box.Items.Add("VAC96-171");
            box.Items.Add("VAC108-177");
            box.Items.Add("VAC120-183");
            box.Items.Add("VAC144-195");
        }

        private void vsd_sizes(ComboBox box)
        {
            box.Items.Add("VSD12-48");
            box.Items.Add("VSD16-54");
            box.Items.Add("VSD20-60");
            box.Items.Add("VSD24-60");
            box.Items.Add("VSD30-72");
            box.Items.Add("VSD36-78");
            box.Items.Add("VSD42-84");
        }

        private void hsd_sizes(ComboBox box)
        {
            box.Items.Add("HSD12-48");
            box.Items.Add("HSD16-60");
            box.Items.Add("HSD20-72");
            box.Items.Add("HSD24-72");
            box.Items.Add("HSD30-96");
            box.Items.Add("HSD36-96");
            box.Items.Add("HSD42-120");
        }

        private void mhsd_sizes(ComboBox box)
        {
            box.Items.Add("MHSD20-96");
            box.Items.Add("MHSD24-96");
            box.Items.Add("MHSD30-96");
            box.Items.Add("MHSD36-96");
            box.Items.Add("MHSD42-96");
            box.Items.Add("MHSD48-120");
            box.Items.Add("MHSD54-144");
            box.Items.Add("MHSD60-144");
        }

        private void hop_sizes(ComboBox box)
        {
            box.Items.Add("HOP8-36");
            box.Items.Add("HOP10-36");
        }


        private void button_full_report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure that you want to delete your hard drive?", "Last chance to turn back", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            FullReport fr = new FullReport();

            fr.run_full_report();

            this.Close();
        }
    }
}
