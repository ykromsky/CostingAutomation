
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class MRP_H : Package
    {
        HR hr;
        HOP hop;


        public MRP_H(ProductInfo info) : base(info) { }


        public List<ListItem> Assemble_package_list()
        {
            SectionA_list();

            SectionB_list();

            return ListItems;
        }


        public void SectionA_list()
        {
            Add_section_block("A");

            HR_list(); //VR VESSEL

            HOP_list(); //HOP VESSEL

            Level_column_list(); //LEVEL COLUMN

            Relief_list(); //RELIEF

            Skid_list(); //SKID
        }


        public void HR_list()
        {
            Add_block_title("HR VESSEL");

            hr = new HR(productInfo);
            switch (productInfo.PackageSize)
            {
                case "MRP-24H":
                    productInfo.VesselSize = 24;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 135;
                    Copy_list(hr.HR_24_135());
                    break;

                case "MRP-30H":
                    productInfo.VesselSize = 30;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 138;
                    Copy_list(hr.HR_30_138());
                    break;

                case "MRP-36H":
                    productInfo.VesselSize = 36;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 141;
                    Copy_list(hr.HR_36_141());
                    break;

                case "MRP-42H":
                    productInfo.VesselSize = 42;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 144;
                    Copy_list(hr.HR_42_144());
                    break;

                case "MRP-48H":
                    productInfo.VesselSize = 48;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 147;
                    Copy_list(hr.HR_48_147());
                    break;

                case "MRP-54H":
                    productInfo.VesselSize = 54;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 150;
                    Copy_list(hr.HR_54_150());
                    break;

                case "MRP-60H":
                    productInfo.VesselSize = 60;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 153;
                    Copy_list(hr.HR_60_153());
                    break;

                case "MRP-72H":
                    productInfo.VesselSize = 72;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 159;
                    Copy_list(hr.HR_72_159());
                    break;

                case "MRP-84H":
                    productInfo.VesselSize = 84;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 165;
                    Copy_list(hr.HR_84_165());
                    break;

                case "MRP-96H":
                    productInfo.VesselSize = 96;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 171;
                    Copy_list(hr.HR_96_171());
                    break;

                case "MRP-108H":
                    productInfo.VesselSize = 108;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 177;
                    Copy_list(hr.HR_108_177());
                    break;

                case "MRP-120H":
                    productInfo.VesselSize = 120;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 183;
                    Copy_list(hr.HR_120_183());
                    break;

                case "MRP-144H":
                    productInfo.VesselSize = 144;
                    productInfo.VesselShellLength = 119;
                    productInfo.VesselOAL = 195;
                    Copy_list(hr.HR_144_195());
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
                case "MRP-24H":
                case "MRP-30H":
                case "MRP-36H":
                case "MRP-42H":
                case "MRP-48H":
                case "MRP-54H":
                case "MRP-60H":
                    productInfo.VesselSize = 8;
                    productInfo.VesselShellLength = 28;
                    productInfo.VesselOAL = 36;
                    Copy_list(hop.HOP_8_36());
                    break;

                case "MRP-72H":
                case "MRP-84H":
                case "MRP-96H":
                case "MRP-108H":
                case "MRP-120H":
                case "MRP-144H":
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
            Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5362");
            Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5372");
            Add_thd_valve_item(1, "FPT QUICK CLOSING VALVE", "", "DANFOSS", 0.75, "148H3274");
            Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5732");
            Add_pressure_gauge_item(1, "0-600#", 2.5, "311D-254CK");
            Add_custom_item(1, "Q.R. CARTRIDGE RELIEF VALVE SET", "50#", "SHANK", "0.5 X 0.75", "800QRW", "", 1);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 0.75, "3000#");
            Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
            Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "0.75 x 0.5", "SA105", 0.75, "3000#");
            Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.5", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "1.5 x 0.75", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "", "SA106B", 0.5, "S/80", 3);
            Add_sw_pipe_item(2, "", "SA106B", 0.75, "S/80", 6);
            Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 18);
            Add_sw_pipe_item(1, "", "SA106B", 2, "S/80", 18);
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
                case "MRP-24H":
                case "MRP-30H":
                case "MRP-36H":
                case "MRP-42H":
                case "MRP-48H":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "0.75 x 1", "H5632RD", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 0.75, "S/80");
                    Add_thd_fitting_item(1, "THD 90 ELBOW", "", "SA105", 0.75, "3000#");
                    break;

                case "MRP-54H":
                case "MRP-60H":
                case "MRP-66H":
                case "MRP-72H":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "1.25 x 1.5", "H5634RD", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 1.25, "S/80");
                    Add_thd_fitting_item(1, "THD 90 ELBOW", "", "SA105", 1.25, "3000#");
                    break;

                case "MRP-84H":
                case "MRP-96H":
                case "MRP-108H":
                    Add_custom_item(2, "SINGLE RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "1 x 1.25", "H5613", "", 0);
                    Add_custom_item(1, "3-WAY MANIFOLD", "", "SHANK", "1.25 x 1", "850MW-1", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 1, "S/80");
                    Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "1.5 x 1.25", "SA105", 1.5, "3000#");
                    Add_sw_pipe_item(1, "", "SA106B", 1.25, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1.25, "3000#");
                    break;

                case "MRP-120H":
                case "MRP-144H":
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
                case "MRP-24H":
                case "MRP-30H":
                case "MRP-36H":
                case "MRP-42H":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 75.5, 1);
                    Add_beam_item(2, "", 6, "15#", 131.5, 2);
                    Add_channel_item(2, "", 6, "10.5#", 56, 1);
                    Add_channel_item(2, "", 6, "10.5#", 49.75, 1);
                    Add_plate_item(2, "", "SA36", 15, 0.625, 30, 1);
                    Add_plate_item(1, "", "SA36", 12, 0.625, 50, 1);
                    Add_angle_item(1, "", "SA36", 3, 0.25, 10, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 0.5);
                    Add_plate_item(4, "", "SA36", 11, 0.625, 11, 0.5);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 10, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 56, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 15, 1);
                    Add_angle_item(1, "", "SA36", 3, 0.25, 6.75, 1);
                    Add_angle_item(3, "", "SA36", 3, 0.25, 6, 1);
                    break;

                //medium
                case "MRP-48H":
                case "MRP-54H":
                case "MRP-60H":
                case "MRP-72H":
                case "MRP-84H":
                    Add_beam_item(2, "", 8, "31#", 165, 2);
                    Add_beam_item(5, "", 8, "31#", 66.75, 2);
                    Add_beam_item(2, "", 8, "31#", 74.25, 2);
                    Add_beam_item(4, "", 8, "31#", 46.375, 2);
                    Add_plate_item(3, "", "SA36", 15, 0.625, 43, 1);
                    Add_plate_item(4, "", "SA36", 8, 0.375, 8, 1);
                    Add_plate_item(4, "", "SA36", 14, 0.625, 14, 1);
                    Add_plate_item(4, "", "SA36", 12, 0.5, 12, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 57, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 15, 1);
                    Add_angle_item(1, "", "SA36", 3, 0.25, 11, 1);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 11, 1);
                    Add_angle_item(1, "", "SA36", 3, 0.25, 36, 1);
                    Add_angle_item(1, "", "SA36", 3, 0.25, 8, 1);
                    break;

                //large
                case "MRP-96H":
                case "MRP-108H":
                case "MRP-120H":
                case "MRP-144H":
                    Add_beam_item(2, "", 8, "48#", 188, 2);
                    Add_beam_item(5, "", 8, "48#", 118.125, 2);
                    Add_beam_item(2, "", 8, "48#", 126, 2);
                    Add_beam_item(4, "", 8, "48#", 51, 2);
                    Add_plate_item(4, "", "SA36", 17, 0.625, 46, 1);
                    Add_plate_item(8, "", "SA36", 12, 0.5, 12, 1);
                    Add_plate_item(4, "", "SA36", 8.125, 0.5, 8.5, 1);
                    Add_stud_bolt_item(8, 0.875);
                    Add_hex_nut_item(16, 0.875);
                    Add_plate_item(4, "", "SA36", 3.75, 0.5, 7, 1);
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

            //Pumps + piping
            SectionB_pump_items();

            //items present in every MRP-H
            SectionB_static_items();

            Add_last_item();
        }


        protected void SectionB_static_items()
        {
            Add_blank_item();
            Add_sw_valve_item(2, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
            Add_sw_valve_item(8, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
            Add_thd_valve_item(2, "THD GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.5, "148B275");
            Add_custom_item(2, "RELIEF REGULATOR", "RESEATING, S.W. FLANGE", "HANSEN", 0.5, "HA2BK", "", 0.5);
            Add_pressure_gauge_item(1, "0-300#", 4, "401LFW-404CH");
            Add_pressure_gauge_item(2, "0-300#", 2.5, "401LFW-254CH");
            Add_sw_fitting_item(4, "LONG COUPLING", "", "SA105", 0.25, "3000#");
            Add_sw_fitting_item(4, "S.W. REDUCING INSERT", "0.75 X 0.5", "SA105", 0.75, "3000#");
            Add_thd_fitting_item(2, "THD PIPE CAP", "", "SA105", 0.75, "3000#");
            Add_thd_fitting_item(2, "THD PIPE CAP", "", "SA105", 0.5, "3000#");
            Add_thd_fitting_item(2, "THD STREET ELBOW", "", "SA105", 0.5, "3000#");
            Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. TEE", "", "SA105", 0.75, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(7, "S.W. 90 ELBOW", "", "SA105", 0.75, "3000#");
        }


        protected void SectionB_pump_items()
        {
            Add_blank_item();
            switch (productInfo.SecondarySize)
            {
                case "60-30":
                    Add_pump_item(2, "RVS60-30");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6030");
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5722");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 2, "HCK4-8LR");
                    Add_sw_valve_item(2, "S.W. EXP. ANGLE VALVE", "SEAL CAP", "DANFOSS", 1, "148B5404");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1, "148X0180");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1, "148X0125");
                    Flange_items("RFWN", 2, 2);
                    Flange_items("RFWN", 2, 1.5);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "4 x 2", "SA234-WPB", 4, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "2 x 1.5", "SA234-WPB", 2, "S/80", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 4, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 50);

                    Add_bw_pipe_item(4, "", "SA106B", 4, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 2, "S/80", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "60-45":
                    Add_pump_item(2, "RVS60-45");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6030");
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 2, "148B5722");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 2, "HCK4-8LR");
                    Add_sw_valve_item(2, "S.W. EXP. ANGLE VALVE", "SEAL CAP", "DANFOSS", 1, "148B5404");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1, "148X0180");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1, "148X0125");
                    Flange_items("RFWN", 2, 2.5);
                    Flange_items("RFSO", 2, 2);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "4 x 2.5", "SA234-WPB", 4, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 4, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 50);

                    Add_bw_pipe_item(4, "", "SA106B", 4, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 2, "S/80", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "120-30":
                    Add_pump_item(2, "RVS120-30");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6030");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 2.5, "148B5820");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 2.5, "HCK4-9");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1, "148B5414");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1, "148X0180");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1, "148X0125");
                    Flange_items("RFWN", 2, 2.5);
                    Flange_items("RFWN", 2, 2);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "4 x 2.5", "SA234-WPB", 4, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. CONCENTRIC REDUCER", "2.5 x 2", "SA234-WPB", 2.5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 4, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 4, "S/40", 47);

                    Add_bw_pipe_item(4, "", "SA106B", 4, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 2.5, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "120-45":
                    Add_pump_item(2, "RVS120-45");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6030");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 2.5, "148B5820");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 2.5, "HCK4-9");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1, "148B5414");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1, "148X0180");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1, "148X0125");
                    Flange_items("RFWN", 2, 2.5);
                    Flange_items("RFWN", 2, 2);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "4 x 2.5", "SA234-WPB", 4, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. CONCENTRIC REDUCER", "2.5 x 2", "SA234-WPB", 2.5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 4, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 4, "S/40", 47);

                    Add_bw_pipe_item(4, "", "SA106B", 4, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 2.5, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "160-70":
                    Add_pump_item(2, "RVS160-70");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 5, "148B6130");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 3, "148B5920");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 3, "HCK4-0LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 4);
                    Flange_items("RFSO", 2, 3);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "5 x 4", "SA234-WPB", 5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 5, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 4, "S/40", 35.75);
                    Add_bw_fitting_item(2, "B.W. REDUCING TEE", "4 X 3", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(2, "", "SA106B", 4, "S/40", 6);

                    Add_bw_pipe_item(4, "", "SA106B", 5, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 3, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "190-30":
                    Add_pump_item(2, "RVS190-30");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 5, "148B6130");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 3, "148B5920");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 3, "HCK4-0LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 3);
                    Flange_items("RFWN", 2, 2.5);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "5 x 3", "SA234-WPB", 5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. CONCENTRIC REDUCER", "3 x 2.5", "SA234-WPB", 3, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 5, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 4, "S/40", 27.75);
                    Add_bw_fitting_item(2, "B.W. REDUCING TEE", "4 X 3", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(2, "", "SA106B", 4, "S/40", 6);

                    Add_bw_pipe_item(4, "", "SA106B", 5, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 3, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "190-45":
                    Add_pump_item(2, "RVS190-45");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 5, "148B6130");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 3, "148B5920");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 3, "HCK4-0LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 4);
                    Flange_items("RFSO", 2, 3);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "5 x 4", "SA234-WPB", 5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 5, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 4, "S/40", 35.75);
                    Add_bw_fitting_item(2, "B.W. REDUCING TEE", "4 X 3", "SA234-WPB", 4, "S/40", "");
                    Add_bw_pipe_item(2, "", "SA106B", 4, "S/40", 6);

                    Add_bw_pipe_item(4, "", "SA106B", 5, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 3, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "270-30":
                    Add_pump_item(2, "RVS270-30");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 6, "148B6230");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6020");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 4, "HCK4-1LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 5);
                    Flange_items("RFSO", 2, 4);
                    Flange_items("RFSO", 2, 0.5);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "6 x 5", "SA234-WPB", 6, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 6, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 6, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 6, "S/40", 62);

                    Add_bw_pipe_item(4, "", "SA106B", 6, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 4, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "270-45":
                    Add_pump_item(2, "RVS270-45");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 6, "148B6230");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6020");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 4, "HCK4-1LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 5);
                    Flange_items("RFSO", 2, 4);
                    Flange_items("RFSO", 2, 0.75);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "6 x 5", "SA234-WPB", 6, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 6, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 6, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 6, "S/40", 52);

                    Add_bw_pipe_item(4, "", "SA106B", 6, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 4, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "375-30":
                    Add_pump_item(2, "RVS375-30");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 8, "148B6330");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6020");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 4, "HCK4-1LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 5);
                    Flange_items("RFSO", 2, 4);
                    Flange_items("RFSO", 2, 0.75);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "8 x 5", "SA234-WPB", 8, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 8, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 6, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 8, "S/40", 96);

                    Add_bw_pipe_item(4, "", "SA106B", 8, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 4, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "375-45":
                    Add_pump_item(2, "RVS375-45");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 8, "148B6330");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6020");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "HANSEN", 4, "HCK4-1LR");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 5);
                    Flange_items("RFSO", 2, 4);
                    Flange_items("RFSO", 2, 0.75);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "8 x 5", "SA234-WPB", 8, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 8, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 6, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 8, "S/40", 96);

                    Add_bw_pipe_item(4, "", "SA106B", 8, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 4, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "480-30":
                    Add_pump_item(2, "RVS480-30");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 8, "148B6330");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 5, "148B6120");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "R/S", 5, "CK4A-20");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 5);
                    Flange_items("RFSO", 2, 4);
                    Flange_items("RFSO", 2, 0.75);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "8 x 5", "SA234-WPB", 8, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. CONCENTRIC REDUCER", "5 x 4", "SA234-WPB", 5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 8, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 8, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 8, "S/40", 82);

                    Add_bw_pipe_item(4, "", "SA106B", 8, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 5, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                case "480-45":
                    Add_pump_item(2, "RVS480-45");
                    Add_bw_valve_item(2, "B.W. GLOBE VALVE", "HAND WHEEL", "DANFOSS", 8, "148B6330");
                    Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 5, "148B6120");
                    Add_sw_valve_item(2, "S.W. DISK CHECK VALVE", "", "R/S", 5, "CK4A-20");
                    Add_sw_valve_item(2, "S.W. EXP. GLOBE VALVE", "SEAL CAP", "DANFOSS", 1.5, "148B5615");
                    Add_sw_valve_item(2, "PORT SOLENOID VALVE", "", "DANFOSS", 1.5, "148X0226");
                    Add_custom_item(2, "VAC COIL", "TERMINAL BOX, PILOT, LED", "DANFOSS", 110, "018F6816", "", 0.1);
                    Add_sw_valve_item(2, "S.W. GLOBE STRAINER", "", "DANFOSS", 1.5, "148X0133");
                    Flange_items("RFWN", 2, 5);
                    Flange_items("RFSO", 2, 4);
                    Flange_items("RFSO", 2, 0.75);
                    Add_bw_fitting_item(2, "B.W. ECCENTRIC REDUCER", "8 x 5", "SA234-WPB", 8, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. CONCENTRIC REDUCER", "5 x 4", "SA234-WPB", 5, "S/40", "");
                    Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 8, "S/40", "L.R.");
                    Add_bw_fitting_item(2, "B.W. PIPE CAP", "", "SA234-WPB", 8, "S/40", "");
                    Add_bw_pipe_item(1, "", "SA106B", 8, "S/40", 82);

                    Add_bw_pipe_item(4, "", "SA106B", 8, "S/40", 36);
                    Add_bw_pipe_item(6, "", "SA106B", 5, "S/40", 8);
                    Add_sw_pipe_item(8, "", "SA106B", 1.5, "S/80", 6);
                    Add_sw_pipe_item(17, "", "SA106B", 0.75, "S/80", 6);
                    Add_sw_pipe_item(4, "", "SA106B", 0.5, "S/80", 6);
                    break;

                default:
                    break;
            }
        }

        protected void Flange_items(string type, int quantity, double size)
        {
            if (type == "RFWN") Add_rfwn_flange_item(quantity, size, "300#");
            if (type == "RFSO") Add_rfso_flange_item(quantity, size, "300#");
            Add_gasket_item(quantity, size, "300#");

            switch (size)
            {
                case 0.5:
                    Add_stud_bolt_item(quantity * 4, 0.5);
                    Add_hex_nut_item(quantity * 8, 0.5);
                    break;

                case 0.75:
                    Add_stud_bolt_item(quantity * 4, 0.625);
                    Add_hex_nut_item(quantity * 8, 0.625);
                    break;

                case 1.5:
                    Add_stud_bolt_item(quantity * 4, 0.75);
                    Add_hex_nut_item(quantity * 8, 0.75);
                    break;

                case 2:
                    Add_stud_bolt_item(quantity * 8, 0.625);
                    Add_hex_nut_item(quantity * 16, 0.625);
                    break;

                case 2.5:
                case 3:
                case 4:
                case 5:
                    Add_stud_bolt_item(quantity * 8, 0.75);
                    Add_hex_nut_item(quantity * 16, 0.75);
                    break;

                default:
                    break;
            }
        }
    }
}
