using System.Collections.Generic;


namespace StandardVesselEstimator
{
    public class ProductInfo
    {
        //general properties
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Temperature { get; set; }
        public string Pressure { get; set; }
        public double CorrosionAllowance { get; set; }
        public string MaterialClass { get; set; }
        private Dictionary<string, string> descriptionDictionary;
        public string productClass { get; set; }

        //vessel properties
        public string VesselType { get; set; }
        public double VesselSize { get; set; }
        public double VesselShellLength { get; set; }
        public double VesselOAL { get; set; }
        private Dictionary<double, double> headHeightDictionary;

        //package properties
        public string PackageType { get; set; }
        public string PackageSize { get; set; }
        public string SecondarySize { get; set; }
        public bool MpcHxIsolationValves { get; set; }

        //liquid feed properties
        public string lfType { get; set; }
        public string lfSize { get; set; }
        public bool lfIsHX { get; set; }
        public bool lfIsHW { get; set; }
        public bool lfIsSTD { get; set; }
        public double lfInputSize { get; set; }
        public double lfOutputSize { get; set; }
        public double lfExpansionSize { get; set; }


        public ProductInfo()
        {
            setupDescriptionDictionary();
            setupHeadHeightDictionary();

            //defaults
            Pressure = "250#";
            Temperature = "-20°/+200°F";
            CorrosionAllowance = 0;
            MaterialClass = "CS";
        }


        public void getVesselValues()
        {
            string tag, size_oal, size, oal;

            int index = -1;
            double hh = 0;

            Description = descriptionDictionary[VesselType];

            tag = Tag;
            index = tag.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            size_oal = tag.Substring(index);
            index = size_oal.IndexOfAny(new char[] { '-' });
            size = size_oal.Remove(index);
            oal = size_oal.Substring(index + 1);

            VesselSize = double.Parse(size);
            VesselOAL = double.Parse(oal);
            hh = headHeightDictionary[VesselSize];

            VesselShellLength = VesselOAL - 2 * hh;
        }


        public void getPackageValues()
        {
            Description = descriptionDictionary[PackageType];

            Tag = PackageSize + "-" + SecondarySize;
        }


        public void getLiqFeedValues()
        {
            if (!lfIsSTD) {
                constructLiqFeedType();
                Tag = lfType;
            }
            else
            {
                Tag = lfType + "-" + lfSize;
            }

            Description = descriptionDictionary[lfType];
        }


        private void setupDescriptionDictionary()
        {
            descriptionDictionary = new Dictionary<string, string>();

            //vessels
            descriptionDictionary.Add("HHPR", "Horizontal High Pressure Receiver");
            descriptionDictionary.Add("VHPR", "Vertical High Pressure Receiver");
            descriptionDictionary.Add("VHPTSR", "Vertical High Pressure / Thermosyphon Receiver");
            descriptionDictionary.Add("HTSR", "Horizontal Thermosyphon Receiver");
            descriptionDictionary.Add("VTSR", "Vertical Thermosyphon Receiver");
            descriptionDictionary.Add("VCPR", "Vertical Control Pressure Receiver");
            descriptionDictionary.Add("VPR", "Vertical Pilot Receiver");
            descriptionDictionary.Add("VR", "Vertical Recirculator");
            descriptionDictionary.Add("HR", "Horizontal Recirculator");
            descriptionDictionary.Add("VI", "Vertical Intercooler");
            descriptionDictionary.Add("VIC", "Vertical Intercooler w/ Coil");
            descriptionDictionary.Add("HA", "Horizontal Accumulator");
            descriptionDictionary.Add("VA", "Vertical Accumulator");
            descriptionDictionary.Add("VAC", "Vertical Accumulator w/ Coil");
            descriptionDictionary.Add("VSD", "Vertical Surge Drum");
            descriptionDictionary.Add("HSD", "Horizontal Surge Drum");
            descriptionDictionary.Add("MHSD", "Split Flow Horizontal Surge Drum");
            descriptionDictionary.Add("HOP", "Horizontal Oil Pot");

            //packages
            descriptionDictionary.Add("MRP-V", "Vertical Recirculator Package");
            descriptionDictionary.Add("MRP-H", "Horizontal Recirculator Package");
            descriptionDictionary.Add("MPC", "Horizontal Plate Chiller Package");
            descriptionDictionary.Add("MVI", "Vertical Intercooler Package");
            descriptionDictionary.Add("MVIC", "Vertical Intercooler w/ Coil Package");

            //liquid feeds
            descriptionDictionary.Add("DHXHTHW", "Liquid Feed (Hand Expansion, High Temp, Hand Wheel)");
            descriptionDictionary.Add("DHXHTSC", "Liquid Feed (Hand Expansion, High Temp, Seal Cap)");
            descriptionDictionary.Add("DHXLTHW", "Liquid Feed (Hand Expansion, Low Temp, Hand Wheel)");
            descriptionDictionary.Add("DHXLTSC", "Liquid Feed (Hand Expansion, Low Temp, Seal Cap)");
            descriptionDictionary.Add("DMHTHW", "Liquid Feed (Motorized, High Temp, Hand Wheel)");
            descriptionDictionary.Add("DMHTSC", "Liquid Feed (Motorized, High Temp, Seal Cap)");
            descriptionDictionary.Add("DMLTHW", "Liquid Feed (Motorized, Low Temp, Hand Wheel)");
            descriptionDictionary.Add("DMLTSC", "Liquid Feed (Motorized, Low Temp, Seal Cap)");

            descriptionDictionary.Add("DHXHW", "Custom Liquid Feed (Hand Expansion, Hand Wheel)");
            descriptionDictionary.Add("DHXSC", "Custom Liquid Feed (Hand Expansion, Seal Cap)");
            descriptionDictionary.Add("DMHW", "Custom Liquid Feed (Motorized, Hand Wheel)");
            descriptionDictionary.Add("DMSC", "Custom Liquid Feed (Motorized, Seal Cap)");
        }


        private void constructLiqFeedType()
        {
            string type = "D";

            if(lfIsHX) { type += "HX"; }
            else { type += "M"; }

            if (lfIsHW) { type += "HW"; }
            else { type += "SC"; }

            lfType = type;
        }


        private void setupHeadHeightDictionary()
        {
            headHeightDictionary = new Dictionary<double, double>();
            headHeightDictionary.Add(8, 4);
            headHeightDictionary.Add(10, 5);
            headHeightDictionary.Add(12, 5.5);
            headHeightDictionary.Add(16, 6.5);
            headHeightDictionary.Add(20, 7.5);
            headHeightDictionary.Add(24, 8.25);
            headHeightDictionary.Add(30, 9.5);
            headHeightDictionary.Add(36, 11);
            headHeightDictionary.Add(42, 12.5);
            headHeightDictionary.Add(48, 14);
            headHeightDictionary.Add(54, 15.5);
            headHeightDictionary.Add(60, 17);
            headHeightDictionary.Add(72, 20);
            headHeightDictionary.Add(84, 23);
            headHeightDictionary.Add(96, 26);
            headHeightDictionary.Add(108, 29);
            headHeightDictionary.Add(120, 32);
            headHeightDictionary.Add(144, 38);
        }
    }
}
