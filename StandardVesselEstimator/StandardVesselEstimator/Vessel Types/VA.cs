
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VA : Vessel
    {
        public VA(ProductInfo info) : base(info) { }

        public List<ListItem> VA_12_72()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 61);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_leg_item(3, 3, 0.25, 47.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_16_85()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 72);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_leg_item(3, 3, 0.25, 48.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_20_87()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 72);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 49.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_24_88()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 72);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 55.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 51);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 14.25);   

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_30_115()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 57.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 71);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 21);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 14.25);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_36_118()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 58.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 70);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 28);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 17);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_42_121()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 60);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 68);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 34, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 18.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_48_147()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 61.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 87.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 48, 0.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 20);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_54_150()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 63);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 85);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 46, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 21.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_60_153()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 64.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 84);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 52, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 23);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_72_159()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 67.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 80.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 72, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 26);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_84_165()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 70.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 78.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 76, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 16);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 29);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_96_171()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 73.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 14, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 75);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 88, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 19);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 32);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_108_177()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_weldpad_item(4, "SA36", 12, 0.5);
            Add_beam_leg_item(4, 8, "31#", 76.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 71.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 100, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 22);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 35);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_120_183()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1);
            Add_weldpad_item(4, "SA36", 14, 0.5);
            Add_beam_leg_item(4, 8, "31#", 94.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 14, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 68.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 112, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 25);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 38);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VA_144_195()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_weldpad_item(4, "SA36", 14, 0.5);
            Add_beam_leg_item(4, 10, "68#", 100.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 20, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 36, 0.375, 20);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 62.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 135, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 20, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "GAS OUTLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 28);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 44);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }
    }
}