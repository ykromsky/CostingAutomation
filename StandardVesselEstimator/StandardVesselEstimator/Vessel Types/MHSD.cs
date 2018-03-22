
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class MHSD : Vessel
    {
        public MHSD(ProductInfo info) : base(info) { }

        public List<ListItem> MHSD_20_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 81);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(8, 75);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 6, 0.375, 15, 0.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 13.75);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 25);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_24_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 79.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(8, 73.5);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 6, 0.375, 16.875, 0.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 14.75);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 27);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_30_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 77);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(8, 71);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 8, 0.375, 19.25, 0.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 16.875);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 35);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_36_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 74);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(8, 68);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 8, 0.375, 21.375, 0.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 19.875);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 41);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_42_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 71);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(10, 65);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 8, 0.375, 23.375, 0.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 20.875);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 44);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_48_120()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 92);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(10, 86);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 8, 0.375, 25.125, 0.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 22);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 8, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 53.25);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_54_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 113);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(10, 107);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 10, 0.375, 26.25, 1);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 25);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 8, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 59.25);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MHSD_60_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 110);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_vbaffle_item(10, 104);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 12, 0.375, 27.875, 1.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 28);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 10, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 65.125);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }
    }
}