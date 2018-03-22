
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VCPR : Vessel
    {
        public VCPR(ProductInfo info) : base(info) { }

        public List<ListItem> VCPR_20_144()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 129);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 37.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 12.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 0.75, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_24_144()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 127.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 37.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 13.875);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_30_138()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 39.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 15.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 0.75, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_36_141()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 40.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 17.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 0.75, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_42_144()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 40.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 20);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 0.75, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_48_147()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 43.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 2.5, "S/40", 21.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 14.375);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_54_150()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 43.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 24.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 15);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_60_153()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 46.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 26.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_72_159()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 46.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 32.25);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 21);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 1.5, "S/80", 9.5);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_84_165()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 52.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 36.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 23.75);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 2, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VCPR_96_171()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 52.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 40.75);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID TRANSFER INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 25.25);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 8);
            Add_nozzle_item(1, "PIPE", "GAS INLET/OUTLET", "SA106B", 2, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "LEVEL COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 9);

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