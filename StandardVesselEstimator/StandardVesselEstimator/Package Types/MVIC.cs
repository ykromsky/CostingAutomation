
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class MVIC : Package
    {
        VIC vic;
        HOP hop;


        public MVIC(ProductInfo info) : base(info) { }


        public List<ListItem> Assemble_package_list()
        {
            SectionA_list();

            SectionB_list();

            return ListItems;
        }


        public void SectionA_list()
        {
            Add_section_block("A");

            VIC_list(); //VI VESSEL

            HOP_list(); //HOP VESSEL

            Level_column_list(); //LEVEL COLUMN

            Relief_list(); //RELIEF

            Skid_list(); //SKID
        }


        public void VIC_list()
        {
            Add_block_title("VIC VESSEL");

            vic = new VIC(productInfo);
            switch (productInfo.PackageSize)
            {
                case "MVIC-16":
                    productInfo.VesselSize = 24;
                    productInfo.VesselShellLength = 96;
                    productInfo.VesselOAL = 112;
                    Copy_list(vic.VIC_24_112());
                    break;

                case "MVIC-20":
                    productInfo.VesselSize = 24;
                    productInfo.VesselShellLength = 96;
                    productInfo.VesselOAL = 112;
                    Copy_list(vic.VIC_24_112());
                    break;

                case "MVIC-24":
                    productInfo.VesselSize = 24;
                    productInfo.VesselShellLength = 96;
                    productInfo.VesselOAL = 112;
                    Copy_list(vic.VIC_24_112());
                    break;

                case "MVIC-30":
                    productInfo.VesselSize = 30;
                    productInfo.VesselShellLength = 96;
                    productInfo.VesselOAL = 115;
                    Copy_list(vic.VIC_30_115());
                    break;

                case "MVIC-36":
                    productInfo.VesselSize = 36;
                    productInfo.VesselShellLength = 96;
                    productInfo.VesselOAL = 118;
                    Copy_list(vic.VIC_36_118());
                    break;

                case "MVIC-42":
                    productInfo.VesselSize = 42;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 144;
                    Copy_list(vic.VIC_42_144());
                    break;

                case "MVIC-48":
                    productInfo.VesselSize = 48;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 147;
                    Copy_list(vic.VIC_48_147());
                    break;

                case "MVIC-54":
                    productInfo.VesselSize = 54;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 150;
                    Copy_list(vic.VIC_54_150());
                    break;

                case "MVIC-60":
                    productInfo.VesselSize = 60;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 153;
                    Copy_list(vic.VIC_60_153());
                    break;

                case "MVIC-72":
                    productInfo.VesselSize = 72;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 159;
                    Copy_list(vic.VIC_72_159());
                    break;

                case "MVIC-84":
                    productInfo.VesselSize = 84;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 165;
                    Copy_list(vic.VIC_84_165());
                    break;

                case "MVIC-96":
                    productInfo.VesselSize = 96;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 171;
                    Copy_list(vic.VIC_96_171());
                    break;

                case "MVIC-108":
                    productInfo.VesselSize = 108;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 177;
                    Copy_list(vic.VIC_108_177());
                    break;

                case "MVIC-120":
                    productInfo.VesselSize = 120;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 183;
                    Copy_list(vic.VIC_120_183());
                    break;

                case "MVIC-144":
                    productInfo.VesselSize = 144;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 195;
                    Copy_list(vic.VIC_144_195());
                    break;

                default:
                    break;
            }

            Add_blank_item();
            Add_labor_item("MOUNT VESSEL", 1.5);
            Add_blank_item();
        }


        public void HOP_list()
        {
            Add_block_title("HOP VESSEL");

            hop = new HOP(productInfo);
            switch (productInfo.PackageSize)
            {
                case "MVIC-16":
                case "MVIC-20":
                case "MVIC-24":
                case "MVIC-30":
                case "MVIC-36":
                case "MVIC-42":
                case "MVIC-48":
                case "MVIC-54":
                case "MVIC-60":
                    productInfo.VesselSize = 8;
                    productInfo.VesselShellLength = 28;
                    productInfo.VesselOAL = 36;
                    Copy_list(hop.HOP_8_36());
                    break;

                case "MVIC-72":
                case "MVIC-84":
                case "MVIC-96":
                case "MVIC-108":
                case "MVIC-120":
                case "MVIC-144":
                    productInfo.VesselSize = 10;
                    productInfo.VesselShellLength = 26;
                    productInfo.VesselOAL = 36;
                    Copy_list(hop.HOP_10_36());
                    break;

                default:
                    break;
            }

            //add HOP piping items
            Add_blank_item();
            switch (productInfo.PackageSize)
            {
                case "MVIC-16":
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5372");
                    Add_sw_valve_item(1, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5362");
                    Add_thd_valve_item(1, "FPT QUICK CLOSING VALVE", "", "DANFOSS", 0.75, "148H3274");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5732");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
                    Add_pressure_gauge_item(1, "0-600#", 2.5, "311D-254CK");
                    Add_custom_item(1, "Q.R. CARTRIDGE RELIEF VALVE SET", "50#", "SHANK", "0.5 X 0.75", "800QRW", "", 1);
                    Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
                    Add_sw_fitting_item(2, "S.W. 45 ELBOW", "", "SA105", 2, "3000#");
                    Add_sw_fitting_item(2, "S.W. 45 ELBOW", "", "SA105", 0.75, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.75", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.5", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "0.75 x 0.5", "SA105", 0.75, "3000#");
                    Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(3, "S.W. 90 ELBOW", "", "SA105", 0.75, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 0.5, "S/80", 3);
                    Add_sw_pipe_item(3, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 24);
                    Add_sw_pipe_item(2, "", "SA106B", 0.75, "S/80", 36);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(2, "", "SA106B", 2, "S/80", 12);
                    break;

                case "MVIC-20":
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5372");
                    Add_sw_valve_item(1, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5362");
                    Add_thd_valve_item(1, "FPT QUICK CLOSING VALVE", "", "DANFOSS", 0.75, "148H3274");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5732");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
                    Add_pressure_gauge_item(1, "0-600#", 2.5, "311D-254CK");
                    Add_custom_item(1, "Q.R. CARTRIDGE RELIEF VALVE SET", "50#", "SHANK", "0.5 X 0.75", "800QRW", "", 1);
                    Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.75", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.5", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "0.75 x 0.5", "SA105", 0.75, "3000#");
                    Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(5, "S.W. 90 ELBOW", "", "SA105", 0.75, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 0.5, "S/80", 3);
                    Add_sw_pipe_item(5, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 24);
                    Add_sw_pipe_item(2, "", "SA106B", 0.75, "S/80", 36);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(1, "", "SA106B", 2, "S/80", 12);
                    break;

                case "MVIC-24":
                case "MVIC-30":
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5362");
                    Add_thd_valve_item(1, "FPT QUICK CLOSING VALVE", "", "DANFOSS", 0.75, "148H3274");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5732");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
                    Add_pressure_gauge_item(1, "0-600#", 2.5, "311D-254CK");
                    Add_custom_item(1, "Q.R. CARTRIDGE RELIEF VALVE SET", "50#", "SHANK", "0.5 X 0.75", "800QRW", "", 1);
                    Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.75", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.5", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "0.75 x 0.5", "SA105", 0.75, "3000#");
                    Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(4, "S.W. 90 ELBOW", "", "SA105", 0.75, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 0.5, "S/80", 3);
                    Add_sw_pipe_item(3, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(3, "", "SA106B", 0.75, "S/80", 24);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(1, "", "SA106B", 2, "S/80", 12);
                    break;

                case "MVIC-36":
                case "MVIC-42":
                case "MVIC-48":
                case "MVIC-54":
                case "MVIC-60":
                case "MVIC-72":
                case "MVIC-84":
                case "MVIC-96":
                case "MVIC-108":
                case "MVIC-120":
                case "MVIC-144":
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5362");
                    Add_thd_valve_item(1, "FPT QUICK CLOSING VALVE", "", "DANFOSS", 0.75, "148H3274");
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5732");
                    Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
                    Add_pressure_gauge_item(1, "0-600#", 2.5, "311D-254CK");
                    Add_custom_item(1, "Q.R. CARTRIDGE RELIEF VALVE SET", "50#", "SHANK", "0.5 X 0.75", "800QRW", "", 1);
                    Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.75", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.5", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "0.75 x 0.5", "SA105", 0.75, "3000#");
                    Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 0.75, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 0.5, "S/80", 3);
                    Add_sw_pipe_item(3, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 24);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(1, "", "SA106B", 2, "S/80", 12);
                    break;

                default:
                    break;
            }

            Add_labor_item("MOUNT HOP", 1);
            Add_blank_item();
        }


        public void Level_column_list()
        {
            Add_block_title("LEVEL COLUMN");
            Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 110);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
            Add_custom_item(1, "BACKING RING", "", "SA414", 3, "3/32\"", "", 0);
            Add_custom_item(1, "PROBE COLUMN CAP", "", "HANSEN", 3.5, "77-0129", "", 0.5);
            Add_sw_pipe_item(2, "", "SA106B", 1.5, "S/80", 7.5);
            Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 8);
            Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 10);
            Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 7.5);
            Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 4);
            Add_custom_item(5, "LEVEL INDICATOR", "FROST SHIELD", "HANSEN", "", "H1100-RN", "", 0.75);
            Add_blank_item();
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 3);
            Add_flat_bar_item(2, "", "SA36", 3, 0.25, 11);
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
            Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
            Add_sw_valve_item(2, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5672");
            if (productInfo.PackageSize == "MVIC-144")
            {
                Add_sw_fitting_item(2, "S.W. FLANGED UNION", "", "HENRY", 1.5, "S2SW-2x1 1/2");
                Add_sw_pipe_item(2, "", "SA106B", 1.5, "S/80", 3);
            }
            Add_custom_item(1, "H.L.L. FLOAT SWITCH", "", "HANSEN", "", "HLL", "", 0.5);
            Add_custom_item(1, "LIQUID LEVEL SENSOR", "CABLE TYPE", "DANFOSS", "AKS-4100U", "084H4521", "", 1);
            Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
            Add_sw_fitting_item(4, "S.W. REDUCING INSERT", "0.75 X 0.5", "SA105", 0.75, "3000#");
            Add_thd_fitting_item(1, "THD PIPE CAP", "", "SA105", 0.75, "3000#");
            Add_last_item();
            Add_blank_item();
        }


        public void Relief_list()
        {
            Add_block_title("RELIEF");

            switch (productInfo.PackageSize)
            {
                case "MVIC-16":
                case "MVIC-20":
                case "MVIC-24":
                case "MVIC-30":
                case "MVIC-36":
                case "MVIC-42":
                case "MVIC-48":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "0.75 x 1", "H5632RD", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 0.75, "S/80");
                    Add_thd_fitting_item(1, "THD 90 ELBOW", "", "SA105", 0.75, "3000#");
                    break;

                case "MVIC-54":
                case "MVIC-60":
                case "MVIC-72":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "1.25 x 1.5", "H5634RD", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 1.25, "S/80");
                    Add_thd_fitting_item(1, "THD 90 ELBOW", "", "SA105", 1.25, "3000#");
                    break;

                case "MVIC-84":
                case "MVIC-96":
                case "MVIC-108":
                    Add_custom_item(2, "SINGLE RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "1 x 1.25", "H5613", "", 0);
                    Add_custom_item(1, "3-WAY MANIFOLD", "", "SHANK", "1.25 x 1", "850MW-1", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 1, "S/80");
                    Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "1.5 x 1.25", "SA105", 1.5, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 1.25, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1.25, "3000#");
                    break;

                case "MVIC-120":
                case "MVIC-144":
                    Add_custom_item(2, "SINGLE RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "1.25 x 1.5", "H5604", "", 0);
                    Add_custom_item(1, "3-WAY MANIFOLD", "", "SHANK", "2 x 1.25", "900MW-1 1/4", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 1.25, "S/80");
                    Add_sw_fitting_item(1, "S.W. CPLG", "", "SA105", 2, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 2, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 2, "3000#");
                    break;

                default:
                    break;
            }

            Add_blank_item();
        }


        public void Skid_list()
        {
            Add_block_title("SKID");

            switch (productInfo.PackageSize)
            {
                //small
                case "MVIC-16":
                case "MVIC-20":
                case "MVIC-24":
                case "MVIC-30":
                case "MVIC-36":
                case "MVIC-42":
                    Add_channel_item(2, "", 6, "10.5#", 103, 1);
                    Add_channel_item(3, "", 6, "10.5#", 71.875, 1);
                    Add_beam_item(2, "", 6, "15#", 71.875, 2);
                    Add_plate_item(2, "", "SA36", 15, 0.625, 27, 1);
                    Add_plate_item(1, "", "SA36", 8, 0.625, 32, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 66, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 15, 1);
                    break;

                //medium
                case "MVIC-48":
                case "MVIC-54":
                case "MVIC-60":
                case "MVIC-72":
                case "MVIC-84":
                    Add_beam_item(2, "", 6, "15#", 121.875, 2);
                    Add_channel_item(2, "", 6, "10.5#", 96, 1);
                    Add_channel_item(1, "", 6, "10.5#", 89.75, 1);
                    Add_beam_item(2, "", 6, "15#", 89.75, 2);
                    Add_plate_item(3, "", "SA36", 15, 0.625, 39, 1);
                    Add_plate_item(1, "", "SA36", 12, 0.625, 60, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 60, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 15, 1);
                    Add_angle_item(1, "", "SA36", 3, 0.25, 45, 1);
                    break;

                //large
                case "MVIC-96":
                case "MVIC-108":
                case "MVIC-120":
                case "MVIC-144":
                    Add_channel_item(1, "", 8, "13.75#", 134, 1);
                    Add_beam_item(2, "", 8, "31#", 164.625, 2);
                    Add_beam_item(2, "", 8, "31#", 125.75, 2);
                    Add_plate_item(2, "", "SA36", 18, 0.625, 38, 1);
                    Add_channel_item(1, "", 8, "13.75#", 125.75, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 60, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 15, 1);
                    Add_plate_item(4, "", "SA36", 3.875, 0.5, 7.125, 0.25);
                    break;

                default:
                    break;
            }

            Add_last_item();
            Add_blank_item();
        }


        public void SectionB_list()
        {
            Add_section_block("B");
            Add_blank_item();
        }
    }
}
