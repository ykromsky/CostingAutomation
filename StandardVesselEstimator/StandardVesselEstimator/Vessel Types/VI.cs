
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VI : Vessel
    {
        public VI(ProductInfo info) : base(info) { }

        public List<ListItem> VI_16_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 83);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_leg_item(3, 3, 0.25, 60.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 63.5);
            Add_distribution_box_items(3);
            Add_angle_item(1, "BOOSTER SUPPORT", "SA36", 2, 0.25, 15, 0.25);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1, "S/80", 2);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 3, "S/40", 11);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_20_108()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 93);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 61.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 78.5);
            Add_distribution_box_items(3);
            Add_angle_item(1, "BOOSTER SUPPORT", "SA36", 2, 0.25, 15, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1, "S/80", 6);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 57.5);
            Add_ubend_item(1, 1.25, "S/80");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 3, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_24_112()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 61.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 78);
            Add_distribution_box_items(4);
            Add_angle_item(1, "BOOSTER SUPPORT", "SA36", 2, 0.25, 7.25, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 6);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 75);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 4);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 4, "S/40", 13.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_30_115()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 63.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 79.25);
            Add_distribution_box_items(5);
            Add_angle_item(2, "BOOSTER SUPPORT", "SA36", 2, 0.25, 8.125, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 7);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 68.75);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 6);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 5, "S/40", 15);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_36_118()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 64.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 76.75);
            Add_distribution_box_items(6);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 10.5, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 8.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 72);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 8);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 6, "S/40", 16.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);          
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 21.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_42_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 66);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 99.75);
            Add_distribution_box_items(6);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 17.25, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 8.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 104);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 8);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 6, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 23);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_48_147()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 67.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 8, "S/40", 95.75);
            Add_distribution_box_items(8);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 19.25, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 9);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 101.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 8);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 8, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 24.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_54_150()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 69);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 8, "S/40", 96.75);
            Add_distribution_box_items(8);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 22.125, 0.25);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 10);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 100);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 11.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 8, "S/40", 22.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 15);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 14.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 26);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_60_153()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 70.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 8, "S/40", 98.75);
            Add_distribution_box_items(8);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 25.125, 0.25);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 10);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 103.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 15);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 8, "S/40", 25.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 15);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 16);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 27.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_72_159()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 73.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 10, "S/40", 92.75);
            Add_distribution_box_items(10);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 29.875, 0.25);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 12);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 100.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 15);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 10, "S/40", 28.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 18);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 19);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 30.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_blank_item();
            Add_purge_kit_items();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_84_165()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 76.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_repad_item(1, "SA516-70", 15, 0.375, 10);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 10, "S/40", 94.75);
            Add_distribution_box_items(10);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 35.875, 0.25);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 15);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 100);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 15);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 10, "S/40", 34.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 21);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 19);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 33.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_96_171()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 79.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_repad_item(1, "SA516-70", 19, 0.375, 12);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 12, "STD", 89.75);
            Add_distribution_box_items(12);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 40.875, 0.25);
            Add_repad_item(1, "SA516-70", 22, 0.5, 12);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 15);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 94.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 22);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 12, "STD", 37.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 24);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 22.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 36.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_108_177()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 1.25);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_weldpad_item(4, "SA36", 12, 0.375);
            Add_beam_leg_item(4, 8, "48#", 86.375);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.625, 12, 0);
            Add_repad_item(1, "SA516-70", 19, 0.375, 12);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 12, "STD", 90.75);
            Add_distribution_box_items(12);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 46.75, 0.25);
            Add_repad_item(1, "SA516-70", 22, 0.75, 12);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 18);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 93);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 28.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 12, "STD", 43.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 27);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 22.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 39.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_120_183()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1.25);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_weldpad_item(4, "SA36", 12, 0.375);
            Add_beam_leg_item(4, 8, "48#", 89.375);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.625, 12, 0);
            Add_repad_item(1, "SA516-70", 19, 0.375, 14);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 14, "STD", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 14, "STD", 88.75);
            Add_distribution_box_items(14);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 51.875, 0.25);
            Add_repad_item(1, "SA516-70", 25, 0.625, 14);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 20);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 90);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 28.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 14, "STD", 46.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 30);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 2, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 26);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 42.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VI_144_195()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_weldpad_item(4, "SA36", 10, 0.625);
            Add_weldpad_item(4, "SA36", 14, 0.75);
            Add_beam_leg_item(4, 10, "68#", 97.375);
            Add_plate_item(4, "BASE PLATE", "SA36", 14, 0.625, 14, 0);
            Add_repad_item(1, "SA516-70", 26, 0.5, 16);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 16, "STD", 85.75);
            Add_distribution_box_items(16);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 62.875, 0.25);
            Add_repad_item(1, "SA516-70", 28, 0.875, 16);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 24);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 84);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 28.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 16, "STD", 55.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 38);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 2, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 30);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 48.5);

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