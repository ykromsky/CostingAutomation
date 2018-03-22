
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class MPC : Package
    {
        MPC_HSD mpc_hsd;
        HOP hop;


        public MPC(ProductInfo info) : base(info) { }


        public List<ListItem> Assemble_package_list()
        {
            SectionA_list();

            SectionB_list();

            return ListItems;
        }


        public void SectionA_list()
        {
            Add_section_block("A");

            MPC_HSD_list(); //VESSEL

            HOP_list(); //HOP

            Level_column_list(); //LEVEL COLUMN

            Relief_list(); //RELIEF

            Skid_list(); //SKID
        }


        public void MPC_HSD_list()
        {
            Add_block_title("MHSD VESSEL");

            mpc_hsd = new MPC_HSD(productInfo);
            switch (productInfo.PackageSize)
            {
                case "MPC-20":
                    productInfo.VesselSize = 20;
                    productInfo.VesselShellLength = 81;
                    productInfo.VesselOAL = 96;
                    Copy_list(mpc_hsd.MPC_HSD_20_96());
                    break;

                case "MPC-24":
                    productInfo.VesselSize = 24;
                    productInfo.VesselShellLength = 79.5;
                    productInfo.VesselOAL = 96;
                    Copy_list(mpc_hsd.MPC_HSD_24_96());
                    break;

                case "MPC-30":
                    productInfo.VesselSize = 30;
                    productInfo.VesselShellLength = 77;
                    productInfo.VesselOAL = 96;
                    Copy_list(mpc_hsd.MPC_HSD_30_96());
                    break;

                case "MPC-36":
                    productInfo.VesselSize = 36;
                    productInfo.VesselShellLength = 76;
                    productInfo.VesselOAL = 96;
                    Copy_list(mpc_hsd.MPC_HSD_36_96());
                    break;

                case "MPC-42":
                    productInfo.VesselSize = 42;
                    productInfo.VesselShellLength = 71;
                    productInfo.VesselOAL = 96;
                    Copy_list(mpc_hsd.MPC_HSD_42_96());
                    break;

                case "MPC-48":
                    productInfo.VesselSize = 48;
                    productInfo.VesselShellLength = 92;
                    productInfo.VesselOAL = 120;
                    Copy_list(mpc_hsd.MPC_HSD_48_120());
                    break;

                case "MPC-54":
                    productInfo.VesselSize = 54;
                    productInfo.VesselShellLength = 113;
                    productInfo.VesselOAL = 144;
                    Copy_list(mpc_hsd.MPC_HSD_54_144());
                    break;

                case "MPC-60":
                    productInfo.VesselSize = 60;
                    productInfo.VesselShellLength = 110;
                    productInfo.VesselOAL = 144;
                    Copy_list(mpc_hsd.MPC_HSD_60_144());
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
                case "MPC-20":
                case "MPC-24":
                case "MPC-30":
                case "MPC-36":
                case "MPC-42":
                case "MPC-48":
                case "MPC-54":
                case "MPC-60":
                    productInfo.VesselSize = 8;
                    productInfo.VesselShellLength = 28;
                    productInfo.VesselOAL = 36;
                    Copy_list(hop.HOP_8_36());
                    break;

                default:
                    break;
            }

            //add HOP piping items
            Add_blank_item();
            Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1, "148B5462");
            Add_sw_valve_item(1, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5372");
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5363");
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 0.75, "148B5362");
            Add_thd_valve_item(1, "FPT QUICK CLOSING VALVE", "", "DANFOSS", 0.75, "148H3274");
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.5, "148B5263");
            Add_pressure_gauge_item(1, "0-600#", 2.5, "311D-254CK");
            Add_custom_item(1, "EZ-SRV CARTRIDGE RELIEF VALVE SET", "150#", "HANSEN", "0.5 X 0.75", "EZB-150#", "", 1);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "", "SA105", 1, "3000#");
            Add_sw_fitting_item(2, "S.W. 45 ELBOW", "", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 48);
            Add_sw_pipe_item(2, "", "SA106B", 0.75, "S/80", 48);
            Add_sw_fitting_item(1, "LONG COUPLING", "", "SA105", 0.25, "3000#");
            Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "0.75 x 0.5", "SA105", 0.75, "3000#");
            Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. REDUCING INSERT", "1.5 x 0.5", "SA105", 1.5, "3000#");
            Add_labor_item("MOUNT HOP", 1);
            Add_blank_item();
        }


        public void Level_column_list()
        {
            Add_block_title("LEVEL COLUMN");

            switch (productInfo.PackageSize)
            {
                case "MPC-20":
                    Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 34.25);
                    Add_bw_fitting_item(1, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
                    Add_custom_item(1, "BACKING RING", "", "SA414", 3, "3/32\"", "", 0);
                    Add_custom_item(1, "PROBE COLUMN CAP", "", "HANSEN", 3.5, "77-0129", "", 0.5);
                    Add_sw_pipe_item(2, "", "SA106B", 1.5, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 8);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 10);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 4);
                    Add_custom_item(3, "LEVEL INDICATOR", "FROST SHIELD", "HANSEN", "", "H1100-RN", "", 0.75);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1, "3000#");
                    Add_blank_item();
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5662");
                    Add_sw_valve_item(2, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5672");
                    Add_custom_item(1, "H.L.L. FLOAT SWITCH", "", "HANSEN", "", "HLL", "", 0.5);
                    Add_custom_item(1, "LIQUID LEVEL SENSOR", "CABLE TYPE", "DANFOSS", "AKS-4100U", "084H4533", "", 1);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 3);
                    Add_thd_fitting_item(1, "THD PIPE CAP", "", "SA105", 0.75, "3000#");
                    Add_last_item();
                    Add_blank_item();
                    break;

                case "MPC-24":
                case "MPC-30":
                    Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 34.25);
                    Add_bw_fitting_item(1, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
                    Add_custom_item(1, "BACKING RING", "", "SA414", 3, "3/32\"", "", 0);
                    Add_custom_item(1, "PROBE COLUMN CAP", "", "HANSEN", 3.5, "77-0129", "", 0.5);
                    Add_sw_pipe_item(2, "", "SA106B", 1.5, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 8);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 10);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 4);
                    Add_custom_item(3, "LEVEL INDICATOR", "FROST SHIELD", "HANSEN", "", "H1100-RN", "", 0.75);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1, "3000#");
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 6.5);
                    Add_blank_item();
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5662");
                    Add_sw_valve_item(2, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5672");
                    Add_custom_item(1, "H.L.L. FLOAT SWITCH", "", "HANSEN", "", "HLL", "", 0.5);
                    Add_custom_item(1, "LIQUID LEVEL SENSOR", "CABLE TYPE", "DANFOSS", "AKS-4100U", "084H4533", "", 1);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 3);
                    Add_thd_fitting_item(1, "THD PIPE CAP", "", "SA105", 0.75, "3000#");
                    Add_last_item();
                    Add_blank_item();
                    break;

                case "MPC-36":
                case "MPC-42":
                case "MPC-48":
                    Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 44.25);
                    Add_bw_fitting_item(1, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
                    Add_custom_item(1, "BACKING RING", "", "SA414", 3, "3/32\"", "", 0);
                    Add_custom_item(1, "PROBE COLUMN CAP", "", "HANSEN", 3.5, "77-0129", "", 0.5);
                    Add_sw_pipe_item(2, "", "SA106B", 1.5, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 8);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 10);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 4);
                    Add_custom_item(3, "LEVEL INDICATOR", "FROST SHIELD", "HANSEN", "", "H1100-RN", "", 0.75);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1, "3000#");
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 6.5);
                    Add_blank_item();
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5662");
                    Add_sw_valve_item(2, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5672");
                    Add_custom_item(1, "H.L.L. FLOAT SWITCH", "", "HANSEN", "", "HLL", "", 0.5);
                    Add_custom_item(1, "LIQUID LEVEL SENSOR", "CABLE TYPE", "DANFOSS", "AKS-4100U", "084H4521", "", 1);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 3);
                    Add_thd_fitting_item(1, "THD PIPE CAP", "", "SA105", 0.75, "3000#");
                    Add_last_item();
                    Add_blank_item();
                    break;

                case "MPC-54":
                case "MPC-60":
                    Add_bw_pipe_item(1, "", "SA106B", 3, "S/40", 54.25);
                    Add_bw_fitting_item(1, "B.W. PIPE CAP", "", "SA234-WPB", 3, "S/40", "");
                    Add_custom_item(1, "BACKING RING", "", "SA414", 3, "3/32\"", "", 0);
                    Add_custom_item(1, "PROBE COLUMN CAP", "", "HANSEN", 3.5, "77-0129", "", 0.5);
                    Add_sw_pipe_item(2, "", "SA106B", 1.5, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 8);
                    Add_sw_pipe_item(1, "", "SA106B", 1, "S/80", 10);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 7.5);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 4);
                    Add_custom_item(3, "LEVEL INDICATOR", "FROST SHIELD", "HANSEN", "", "H1100-RN", "", 0.75);
                    Add_sw_pipe_item(1, "", "SA106B", 1.5, "S/80", 4);
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1.5, "3000#");
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", 1, "3000#");
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 6.5);
                    Add_blank_item();
                    Add_sw_valve_item(1, "S.W. GLOBE VALVE", "SEAL CAP, EXT NECK", "DANFOSS", 0.75, "148B5373");
                    Add_sw_valve_item(2, "S.W. ANGLE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5662");
                    Add_sw_valve_item(2, "S.W. GLOBE VALVE", "HAND WHEEL, EXT NECK", "DANFOSS", 1.5, "148B5672");
                    Add_custom_item(1, "H.L.L. FLOAT SWITCH", "", "HANSEN", "", "HLL", "", 0.5);
                    Add_custom_item(1, "LIQUID LEVEL SENSOR", "CABLE TYPE", "DANFOSS", "AKS-4100U", "084H4521", "", 1);
                    Add_sw_pipe_item(1, "", "SA106B", 0.75, "S/80", 3);
                    Add_thd_fitting_item(1, "THD PIPE CAP", "", "SA105", 0.75, "3000#");
                    Add_last_item();
                    Add_blank_item();
                    break;

                default:
                    break;
            }
        }


        public void Relief_list()
        {
            Add_block_title("RELIEF");

            switch (productInfo.PackageSize)
            {
                case "MPC-20":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "0.5 x 0.75", "H5600RD", "", 0);
                    Add_thd_fitting_item(1, "THD NIPPLE", "", "SA106B", 0.5, "S/80");
                    break;



                case "MPC-24":
                case "MPC-30":
                case "MPC-36":
                case "MPC-42":
                case "MPC-48":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "0.75 x 1", "H5632RD", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 0.75, "S/80");
                    break;

                case "MPC-54":
                case "MPC-60":
                    Add_custom_item(1, "DUAL RELIEF VALVE ASSY", "SET @ 250#", "HANSEN", "1.25 x 1.5", "H5634RD", "", 0);
                    Add_thd_fitting_item(2, "THD NIPPLE", "", "SA106B", 1.25, "S/80");
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
                case "MPC-20":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 63, 1);
                    Add_channel_item(1, "", 6, "10.5#", 46, 1);
                    Add_beam_item(2, "", 6, "15#", 104, 2);
                    Add_beam_item(2, "", 6, "15#", 39.75, 2);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 14, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 1);
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 18.5);
                    Add_plate_item(1, "", "SA36", 9, 0.375, 18.5, 1);
                    break;

                case "MPC-24":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 63.875, 1);
                    Add_channel_item(1, "", 6, "10.5#", 50, 1);
                    Add_beam_item(2, "", 6, "15#", 104, 2);
                    Add_beam_item(2, "", 6, "15#", 43.75, 2);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 14, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 1);
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 18.5);
                    Add_plate_item(1, "", "SA36", 9, 0.375, 18.5, 1);
                    break;

                case "MPC-30":
                case "MPC-36":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 81, 1);
                    Add_channel_item(1, "", 6, "10.5#", 58, 1);
                    Add_beam_item(2, "", 6, "15#", 119.5, 2);
                    Add_beam_item(2, "", 6, "15#", 51.75, 2);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 14, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 1);
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 18.5);
                    Add_plate_item(1, "", "SA36", 9, 0.375, 18.5, 1);
                    break;

                case "MPC-42":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 81.375, 1);
                    Add_channel_item(1, "", 6, "10.5#", 60, 1);
                    Add_beam_item(2, "", 6, "15#", 119.5, 2);
                    Add_beam_item(2, "", 6, "15#", 53.75, 2);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 14, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 1);
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 18.5);
                    Add_plate_item(1, "", "SA36", 9, 0.375, 18.5, 1);
                    break;

                case "MPC-48":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 110.875, 1);
                    Add_channel_item(1, "", 6, "10.5#", 72, 1);
                    Add_beam_item(2, "", 6, "15#", 133, 2);
                    Add_beam_item(2, "", 6, "15#", 65.75, 2);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 14, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 1);
                    Add_plate_item(1, "", "SA36", 13, 0.625, 41.5, 1);
                    Add_plate_item(1, "", "SA36", 10, 0.625, 10, 1);
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 18.5);
                    Add_plate_item(1, "", "SA36", 9, 0.375, 18.5, 1);
                    Add_angle_item(4, "", "SA36", 3, 0.25, 6, 1);
                    Add_plate_item(8, "", "SA36", 2.875, 0.375, 5.375, 1);
                    break;

                case "MPC-54":
                case "MPC-60":
                    Add_pipe_item(4, "", "SA106B", 3, "S/40", 110.875, 1);
                    Add_channel_item(1, "", 6, "10.5#", 72, 1);
                    Add_beam_item(2, "", 6, "15#", 149, 2);
                    Add_beam_item(2, "", 6, "15#", 65.75, 2);
                    Add_angle_item(2, "", "SA36", 3, 0.25, 14, 1);
                    Add_plate_item(4, "", "SA36", 3, 0.375, 14.5, 1);
                    Add_plate_item(1, "", "SA36", 13, 0.625, 41.5, 1);
                    Add_plate_item(1, "", "SA36", 10, 0.625, 10, 1);
                    Add_flat_bar_item(1, "", "SA36", 3, 0.25, 18.5);
                    Add_plate_item(1, "", "SA36", 9, 0.375, 18.5, 1);
                    Add_angle_item(4, "", "SA36", 3, 0.25, 6, 1);
                    Add_plate_item(8, "", "SA36", 2.875, 0.375, 5.375, 1);
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
            SectionB_piping_items();

            //items present in every MRP-H
            SectionB_static_items();

            Add_last_item();
        }


        protected void SectionB_piping_items()
        {
            Add_blank_item();
            
            switch (productInfo.SecondarySize)
            {
                case "4\" PORTS":
                    Add_bw_pipe_item(4, "", "SA106B", 4, "S/40", 18);
                    Flange_items("LAP", 2, 4);
                    if (productInfo.MpcHxIsolationValves)
                    {
                        Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 4, "148B6020");
                    }
                    else
                    {
                        Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 4, "S/40", "L.R.");
                    }

                    break;

                case "6\" PORTS":
                    Add_bw_pipe_item(4, "", "SA106B", 6, "S/40", 24);
                    Flange_items("RFWN", 2, 6);
                    if (productInfo.MpcHxIsolationValves)
                    {
                        Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 6, "148B6220");
                    }
                    else
                    {
                        Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 6, "S/40", "L.R.");
                    }
                    break;

                case "8\" PORTS":
                    Add_bw_pipe_item(4, "", "SA106B", 8, "S/40", 30);
                    Flange_items("RFWN", 2, 8);
                    if (productInfo.MpcHxIsolationValves)
                    {
                        Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 8, "148B6320");
                    }
                    else
                    {
                        Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 8, "S/40", "L.R.");
                    }
                    break;

                case "10\" PORTS":
                    Add_bw_pipe_item(4, "", "SA106B", 10, "S/40", 36);
                    Flange_items("RFWN", 2, 10);
                    if (productInfo.MpcHxIsolationValves)
                    {
                        Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 10, "148B3767");
                    }
                    else
                    {
                        Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 10, "S/40", "L.R.");
                    }
                    break;

                case "12\" PORTS":
                    Add_bw_pipe_item(4, "", "SA53B-ERW", 12, "STD", 42);
                    Flange_items("RFWN", 2, 12);
                    if (productInfo.MpcHxIsolationValves)
                    {
                        Add_bw_valve_item(2, "B.W. ANGLE VALVE", "HAND WHEEL", "DANFOSS", 12, "?");
                    }
                    else
                    {
                        Add_bw_fitting_item(2, "B.W. 90 ELBOW", "", "SA234-WPB", 12, "STD", "L.R.");
                    }
                    break;

                default:
                    break;
            }
        }


        protected void SectionB_static_items()
        {
            Add_blank_item();
            Add_labor_item("MOUNT HX", 1);

            //HX drain items
            Add_sw_fitting_item(1, "S.W. CPLG", "HX DRAIN", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(2, "HX DRAIN", "SA106B", 0.75, "S/80", 3);
            Add_sw_valve_item(1, "S.W. ANGLE VALVE", "EXT. NECK, S.C.", "DANFOSS", 0.75, "148B5363");
            Add_thd_fitting_item(2, "THD PIPE CAP", "HX DRAIN", "SA105", 0.75, "3000#");

            //HX relief items
            if (productInfo.MpcHxIsolationValves)
            {
                Add_sw_fitting_item(2, "S.W. CPLG", "HX RELIEF", "SA105", 1.25, "3000#");
                Add_sw_pipe_item(4, "HX RELIEF", "SA106B", 1.25, "S/80", 4);
                Add_sw_fitting_item(2, "S.W. 90 ELBOW", "HX RELIEF", "SA105", 1.25, "3000#");
                Add_custom_item(1, "SINGLE RELIEF VALVE ASSY", "SET @ 50 PSI", "HANSEN", "1.25 x 1.5", "H5604", "", 0.5);
            }
        }


        protected void Flange_items(string type, int quantity, double size)
        {
            if (type == "RFWN") Add_rfwn_flange_item(quantity, size, "300#");
            if (type == "LAP") Add_lap_flange_item(quantity, size, "S/40");
            Add_gasket_item(quantity, size, "300#");

            switch (size)
            {
                case 4:
                    Add_stud_bolt_item(quantity * 4, 0.75);
                    Add_hex_nut_item(quantity * 4, 0.75);
                    break;

                case 6:
                    Add_stud_bolt_item(quantity * 12, 0.75);
                    Add_hex_nut_item(quantity * 12, 0.75);
                    break;

                case 8:
                    Add_stud_bolt_item(quantity * 12, 0.875);
                    Add_hex_nut_item(quantity * 12, 0.875);
                    break;

                case 10:
                    Add_stud_bolt_item(quantity * 16, 1);
                    Add_hex_nut_item(quantity * 16, 1);
                    break;

                case 12:
                    Add_stud_bolt_item(quantity * 16, 1.125);
                    Add_hex_nut_item(quantity * 16, 1.125);
                    break;

                default:
                    break;
            }
        }
    }
}
