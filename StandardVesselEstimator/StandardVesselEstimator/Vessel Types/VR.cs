
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VR : Vessel
    {
        public VR(ProductInfo info) : base(info) { }

        public List<ListItem> VR_24_112()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 4, 0.375, 77.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 47);
            Add_ubend_item(1, 2, "S/40");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 59.25);
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 63.75);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.25, "S/80", 19.25);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 24.25);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 18.75);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_30_115()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 4, 0.375, 81.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 45.75);
            Add_ubend_item(1, 2, "S/40");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 58);
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 62);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.25, "S/80", 20);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 24);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 20);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_36_118()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 96);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 82.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 46.25);
            Add_ubend_item(1, 2, "S/40");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 59.5);
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 63.75);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 36, 0.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.25, "S/80", 20);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 23);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 21.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_42_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 84);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 73);
            Add_ubend_item(1, 2, "S/40");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 82.5);
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 87);
            Add_sw_fitting_item(1, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 42, 0.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.25, "S/80", 15.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 20.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 23);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_48_147()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 89.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(2, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_repad_item(2, "SA516-70", 11, 0.375, 5);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 4.5, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 7, 5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 82.75);
            Add_ubend_item(1, 2, "S/40");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 10);
            Add_flat_bar_item(4, "UBEND SUPPORT", "SA36", 2, 0.25, 10);
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 88);
            Add_sw_fitting_item(3, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 88);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 48, 0.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 5, "S/40", 18);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 24.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 24.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_54_150()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 91);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_repad_item(2, "SA516-70", 11, 0.375, 5);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 4.5, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 7, 5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 77.75);
            Add_ubend_item(1, 2, "S/40");
            Add_flat_bar_item(6, "UBEND SUPPORT", "SA36", 2, 0.25, 10);
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 82.75);
            Add_sw_fitting_item(3, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 82.75);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 51, 0.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 5, "S/40", 18);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 26);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 26);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_60_153()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 92.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_repad_item(2, "SA516-70", 12, 0.375, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 8, 6);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 77.75);
            Add_ubend_item(1, 2, "S/40");
            Add_flat_bar_item(6, "UBEND SUPPORT", "SA36", 2, 0.25, 10);
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 83);
            Add_sw_fitting_item(3, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 83);
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 57, 0.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 6, "S/40", 18);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 27.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 27.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_72_159()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 103.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_repad_item(2, "SA516-70", 12, 0.375, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 8, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 73);
            Add_ubend_item(1, 2, "S/40");
            Add_flat_bar_item(6, "UBEND SUPPORT", "SA36", 2, 0.25, 10);
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 90.5);
            Add_sw_fitting_item(3, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 78);
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 64, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 6, "S/40", 21);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.5, "S/80", 23);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 30.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 30.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }

        public List<ListItem> VR_84_165()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 106.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_repad_item(2, "SA516-70", 14, 0.375, 8);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 10, 8);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 73);
            Add_ubend_item(1, 2, "S/40");
            Add_flat_bar_item(6, "UBEND SUPPORT", "SA36", 2, 0.25, 14);
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 78);
            Add_sw_fitting_item(3, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 78);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 76, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 18);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 18.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.5, "S/80", 23);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 33.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 33.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_96_171()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 109.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 14, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 17, 0.375, 12);
            Add_repad_item(2, "SA516-70", 14, 0.375, 8);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 10, 8);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 65);
            Add_ubend_item(1, 2, "S/40");
            Add_flat_bar_item(6, "UBEND SUPPORT", "SA36", 2, 0.25, 14);
            Add_sw_pipe_item(2, "INTERNAL", "SA106B", 0.75, "S/80", 89);
            Add_sw_fitting_item(3, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(3, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 73);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 88, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 20.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 21);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 1.5, "S/80", 21);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 36.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 36.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_108_177()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_weldpad_item(4, "SA36", 12, 0.75);
            Add_beam_leg_item(4, 8, "31#", 112.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 26, 0.375, 16);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_repad_item(3, "SA516-70", 12, 0.375, 6);
            Add_plate_item(6, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(3, 8, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_fitting_item(3, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 54.5);
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 15);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 91, 0.25);
            Add_sw_pipe_item(3, "INTERNAL", "SA106B", 0.75, "S/80", 66);
            Add_sw_fitting_item(4, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(4, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 66);
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 99.5, 0.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(3, "PIPE", "PUMP SUCTION", "SA106B", 6, "S/40", 25.25);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 3, "S/80", 18.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 21);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 39.5);
            Add_nozzle_item(3, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 39.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_120_183()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(8, 1.25);
            Add_weldpad_item(8, "SA36", 8, 0.5);
            Add_weldpad_item(4, "SA36", 14, 0.375);
            Add_beam_leg_item(4, 8, "31#", 130.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 26, 0.375, 16);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 14, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_repad_item(3, "SA516-70", 14, 0.375, 8);
            Add_plate_item(6, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(3, 10, 8);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_bw_fitting_item(3, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 56.5);
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 15);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 93.5, 0.25);
            Add_sw_pipe_item(3, "INTERNAL", "SA106B", 0.75, "S/80", 68);
            Add_sw_fitting_item(4, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(4, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 68);
            Add_angle_item(1, "UBEND SUPPORT", "SA36", 2, 0.25, 91, 0.25);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 101.5, 0.25);
            Add_weldpad_item(2, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(3, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 26.25);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 3, "S/80", 16.75);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 15);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 25);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "VESSEL DRAIN", "SA106B", 0.75, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 42.5);
            Add_nozzle_item(3, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 42.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VR_144_195()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(8, 1.25);
            Add_weldpad_item(8, "SA36", 8, 0.5);
            Add_weldpad_item(4, "SA36", 14, 0.375);
            Add_beam_leg_item(4, 10, "68#", 136.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 14, 0.5, 14, 0);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 20, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 36, 0.375, 20);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 16, "STD", "L.R.");
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_repad_item(4, "SA516-70", 14, 0.375, 8);
            Add_plate_item(8, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(4, 10, 8);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 56.5);
            Add_bw_fitting_item(3, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_flat_bar_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 15);
            Add_angle_item(4, "UBEND SUPPORT", "SA36", 2, 0.25, 123.5, 0.25);
            Add_sw_pipe_item(4, "INTERNAL", "SA106B", 0.75, "S/80", 58);
            Add_sw_fitting_item(5, "S.W. CPLG", "INTERNAL", "SA105", 0.75, "3000#");
            Add_ubend_item(5, 1.25, "S/80");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 58);
            Add_angle_item(2, "UBEND SUPPORT", "SA36", 2, 0.25, 141.5, 0.25);
            Add_weldpad_item(2, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 20, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(4, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 22.75);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "MINIMUM FLOW", "SA106B", 4, "S/80", 18.25);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 36);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(4, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 48.5);
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