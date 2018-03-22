
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VIC : Vessel
    {
        public VIC(ProductInfo info) : base(info) { }

        public List<ListItem> VIC_16_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 83);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_leg_item(3, 3, 0.25, 60.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 66.5);
            Add_distribution_box_items(3);
            Add_coil_item("COIL (1W)", "SA106B", 0.75, "S/80", "75 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_angle_item(6, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 3, "S/40", 11);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 0.75, "S/80", 64);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_20_108()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 93);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 61.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 76.5);
            Add_distribution_box_items(3);
            Add_coil_item("COIL (2W)", "SA106B", 0.75, "S/80", "116 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_angle_item(6, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 3, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 0.75, "S/80", 83);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_24_112()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 61.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 76);
            Add_distribution_box_items(4);
            Add_plate_item(3, "BOOSTER SUPPORT", "SA36", 2.75, 0.375, 3, 0);
            Add_coil_item("COIL (2W)", "SA106B", 1, "S/80", "139 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 1, "3000#");
            Add_angle_item(3, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 4, "S/40", 13.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 10);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 1, "S/80", 76.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_30_115()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 63.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 77.25);
            Add_distribution_box_items(5);
            Add_plate_item(3, "BOOSTER SUPPORT", "SA36", 2.75, 0.375, 5, 0);
            Add_coil_item("COIL (2W)", "SA106B", 1.25, "S/80", "173 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 1.25, "3000#");
            Add_angle_item(6, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 5, "S/40", 15);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 1.25, "S/80", 76.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_36_118()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 64.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 72.75);
            Add_distribution_box_items(6);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 10.5, 0.25);
            Add_coil_item("COIL (2W)", "SA106B", 1.5, "S/80", "220 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 1.5, "3000#");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 6, "S/40", 16.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 1.5, "S/80", 73);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 11.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();            
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_42_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 66);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 95.75);
            Add_distribution_box_items(6);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 17.25, 0.25);
            Add_coil_item("COIL (2W)", "SA106B", 1.5, "S/80", "294 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 1.5, "3000#");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 104);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 8.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 6, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 1.5, "S/80", 95.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 23);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_48_147()
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
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 8, "S/40", 90.75);
            Add_distribution_box_items(8);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 19.25, 0.25);
            Add_coil_item("COIL (3W)", "SA106B", 1.5, "S/80", "385 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 1.5, "3000#");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 60.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 9);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 8, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 1.5, "S/80", 105);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 12);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_54_150()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 69);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 8, "S/40", 90.75);
            Add_distribution_box_items(8);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 22.125, 0.25);
            Add_coil_item("COIL (3W)", "SA106B", 2, "S/40", "395 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 2, "3000#");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 50.75);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 9);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 8, "S/40", 22.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 12.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 2, "S/80", 100);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 14.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 12);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_60_153()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 70.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 8, "S/40", 90.75);
            Add_distribution_box_items(8);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 25.125, 0.25);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_coil_item("COIL (3W)", "SA106B", 2, "S/40", "491 FT");
            Add_sw_fitting_item(2, "S.W. CPLG", "INTERNAL", "SA105", 2, "3000#");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 103.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 14);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 8, "S/40", 25.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 15);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 2, "S/80", 101);
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


        public List<ListItem> VIC_72_159()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 73.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 10, "S/40", 82.75);
            Add_distribution_box_items(10);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 29.875, 0.25);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_repad_item(2, "SA516-70", 9, 0.375, 3);
            Add_coil_item("COIL (3W) [3\" HDR]", "SA106B", 2, "S/40", "630 FT");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_repad_item(1, "SA516-70", 9, 0.375, 3);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 100.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 15);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 10, "S/40", 28.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 3, "S/40", 105);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 15.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.5, "S/160", 19);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 30.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VIC_84_165()
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
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 10, "S/40", 82.75);
            Add_distribution_box_items(10);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 35.875, 0.25);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_repad_item(2, "SA516-70", 9, 0.375, 3);
            Add_coil_item("COIL (3W) [3\" HDR]", "SA106B", 2, "S/40", "857 FT");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 100);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 17);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA106B", 10, "S/40", 34.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 3, "S/40", 102);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 17.5);
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


        public List<ListItem> VIC_96_171()
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
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 12, "STD", 75.75);
            Add_distribution_box_items(12);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 40.875, 0.25);
            Add_repad_item(1, "SA516-70", 22, 0.5, 12);
            Add_repad_item(2, "SA516-70", 10, 0.375, 4);
            Add_coil_item("COIL (4W) [4\" HDR]", "SA106B", 2, "S/40", "1128 FT");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_repad_item(2, "SA516-70", 10, 0.375, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 94.5);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 19);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 12, "STD", 37.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 4, "S/40", 107);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 17.5);
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


        public List<ListItem> VIC_108_177()
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
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 12, "STD", 75.75);
            Add_distribution_box_items(12);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 46.75, 0.25);
            Add_repad_item(1, "SA516-70", 22, 0.75, 12);
            Add_repad_item(2, "SA516-70", 10, 0.625, 4);
            Add_coil_item("COIL (4W) [4\" HDR]", "SA106B", 2, "S/40", "1424 FT");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_repad_item(1, "SA516-70", 10, 0.625, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 93);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 18);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 12, "STD", 43.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 4, "S/40", 111);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 19.5);
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


        public List<ListItem> VIC_120_183()
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
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 14, "STD", 70.75);
            Add_distribution_box_items(14);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 51.875, 0.25);
            Add_repad_item(1, "SA516-70", 25, 0.625, 14);
            Add_repad_item(2, "SA516-70", 12, 0.625, 5);
            Add_coil_item("COIL (4W) [5\" HDR]", "SA106B", 2, "S/40", "1758 FT");
            Add_angle_item(12, "INTERNAL SUPPORT", "SA36", 3, 0.25, 3, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_repad_item(1, "SA516-70", 9, 0.75, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 90);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 20);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 14, "STD", 46.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 5, "S/40", 103.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 19.5);
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


        public List<ListItem> VIC_144_195()
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
            Add_bw_pipe_item(1, "INTERNAL", "SA53B-ERW", 16, "STD", 63.75);
            Add_distribution_box_items(16);
            Add_angle_item(3, "BOOSTER SUPPORT", "SA36", 2, 0.25, 62.875, 0.25);
            Add_repad_item(1, "SA516-70", 28, 0.875, 16);
            Add_repad_item(2, "SA516-70", 14, 0.75, 6);
            Add_coil_item("COIL (6W) [6\" HDR]", "SA106B", 2, "S/40", "2471 FT");
            Add_angle_item(6, "INTERNAL SUPPORT", "SA36", 3, 0.25, 31, 0);
            Add_plate_item(6, "INTERNAL SUPPORT", "SA36", 2.75, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_repad_item(1, "SA516-70", 12, 0.75, 5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", .75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", .75, "S/80", 84);
            Add_ubend_item(1, 1.25, "S/80");
            Add_flat_bar_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 20);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "BOOSTER DISCHARGE INLET", "SA53B-ERW", 16, "STD", 55.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "COIL IN/OUT", "SA106B", 6, "S/40", 115);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 21.5);
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