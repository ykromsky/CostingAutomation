
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class MPC_HSD : Vessel
    {
        public MPC_HSD(ProductInfo info) : base(info) { }

        public List<ListItem> MPC_HSD_20_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 81);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(8, 75);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 6, 0.375, 15, 0.5);
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 11.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 25.5);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 25.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_24_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 79.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(8, 73.5);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 6, 0.375, 16.875, 0.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            
            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 17.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 25.5);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 25.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_30_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 77);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(5, "SA36", 6, 0.375);
            Add_vbaffle_item(8, 71);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 10, 0.375, 25, 0.75);
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 15);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 38);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 38);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_36_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 74);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_backer_item(1, 10);
            Add_vbaffle_item(8, 68);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 10, 0.375, 28.25, 0.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            
            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 15);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 41.5);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 41.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_42_96()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 71);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(5, "SA36", 6, 0.375);
            Add_vbaffle_item(10, 65);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 10, 0.375, 31, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 41.5);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 41.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_48_120()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 92);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(5, "SA36", 6, 0.375);
            Add_vbaffle_item(10, 86);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 12, 0.375, 37, 0.375);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 15.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 59);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 59);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_54_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 113);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(5, "SA36", 6, 0.375);
            Add_vbaffle_item(10, 107);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 10, 0.375, 26.25, 1);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 19);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 62);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 62);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> MPC_HSD_60_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 110);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(5, "SA36", 6, 0.375);
            Add_vbaffle_item(14, 104);
            Add_plate_item(1, "SPLASH PLATE", "SA36", 12, 0.375, 27.875, 1.25);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. REDUCING CPLG", "", "SA105", 1.5, "3000#");
            Add_sw_fitting_item(2, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_port_nozzles();
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 17);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 62);
            Add_nozzle_item(1, "PIPE", "OIL POT RELIEF", "SA106B", 0.75, "S/80", 62);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public void Add_port_nozzles()
        {
            switch (productInfo.SecondarySize)
            {
                case "4\" PORTS":
                    Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/40", 12.5);
                    Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 8, "S/40", "");
                    Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 13.75);
                    Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
                    Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 24);
                    break;

                case "6\" PORTS":
                    Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 10, "S/40", 12.5);
                    Add_head_items(1, "OD ELLIP HEAD", "SA516-70 NORM", 10.75, 0.375);
                    Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 17);
                    Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
                    Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 25);
                    break;

                case "8\" PORTS":
                    Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 12.5);
                    Add_repad_item(1, "SA516-70", 17, 0.375, 12);
                    Add_head_items(1, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
                    Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 23.875);
                    Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
                    Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 8, "S/40", 25.5);
                    break;

                case "10\" PORTS":
                    Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 16, "STD", 12.5);
                    Add_repad_item(1, "SA516-70", 21, 0.375, 16);
                    Add_head_items(1, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
                    Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 32);
                    Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 10, "S/40", "L.R.");
                    Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 10, "S/40", 25.5);
                    break;

                case "12\" PORTS":
                    Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 20, "STD", 12.5);
                    Add_repad_item(1, "SA516-70", 28, 0.375, 20);
                    Add_head_items(1, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
                    Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 23.875);
                    Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 12, "STD", "L.R.");
                    Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA53B-ERW", 12, "STD", 25.5);
                    break;

                default:
                    break;
            }
        }
    }
}