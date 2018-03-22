
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class HR : Vessel
    {
        public HR(ProductInfo info) : base(info) { }

        public List<ListItem> HR_24_135()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(8, 113);
            Add_plate_item(1, "BAFFLE", "SA36", 12, 0.375, 24, .5);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_plate_item(2, "BAFFLE", "SA36", 4, 0.375, 19.625, .5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 9.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 35.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 25.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_30_138()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(8, 113);
            Add_plate_item(1, "BAFFLE", "SA36", 16, 0.375, 24, .75);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 25.375, .5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 14);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 16);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.25, "S/80", 18.25);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 43.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 30.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_36_141()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(8, 113);
            Add_vbaffle_item(10, 24);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 28.75, .5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 18);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 16);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.25, "S/80", 18.25);           
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 43.5);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 36.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_42_144()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(10, 113);
            Add_vbaffle_item(8, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 3.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 6, 4);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 34.5, .5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 21);


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 4, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14.5);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 18.25);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 56);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 47);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_48_147()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(10, 113);
            Add_vbaffle_item(10, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 8, 5);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 34.5, .5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 25);


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 5, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 63);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 53);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_54_150()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(10, 113);
            Add_vbaffle_item(10, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 7, 5);
            Add_repad_item(2, "SA516-70", 10, 0.375, 5);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 36.5, .5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 28.5);


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 5, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 17);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 72);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 58);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_60_153()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_vbaffle_item(12, 113);
            Add_vbaffle_item(10, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 8, 6);
            Add_repad_item(2, "SA516-70", 11, 0.375, 6);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 37.875, .5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 31);


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 6, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 21);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 77);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 63.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_72_159()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 8, 0.375);
            Add_vbaffle_item(14, 113);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_vbaffle_item(14, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_repad_item(2, "SA516-70", 11, 0.375, 6);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 5.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 8, 6);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 42.875, 0.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 39);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 6, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 2.5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 90);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 77);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_84_165()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 8, 0.375);
            Add_vbaffle_item(14, 113);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_vbaffle_item(14, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_repad_item(2, "SA516-70", 13, 0.375, 8);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 6, 0);
            Add_vortex_breaker_item(2, 10, 8);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 47.125, 0.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 46.5);
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 107);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 98.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_96_171()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 8, 0.375);
            Add_vbaffle_item(18, 113);
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_vbaffle_item(14, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_repad_item(2, "SA516-70", 13, 0.375, 8);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 8, 0);
            Add_vortex_breaker_item(2, 10, 8);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 50.75, 0.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 55);
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 105);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 35.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 84.25);
            Add_saddle_web_item(2, "SA36", 43.125, 0.5, 84.25);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 21);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 3, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 1.5, "S/80", 20);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 120);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 103.75);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_108_177()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_weldpad_item(4, "SA36", 8, 0.375);
            Add_vbaffle_item(18, 113);
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_vbaffle_item(18, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_repad_item(2, "SA516-70", 13, 0.375, 8);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 8, 0);
            Add_vortex_breaker_item(2, 10, 8);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 50.75, 0.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 62);
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 118);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 43.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 94.75);
            Add_saddle_web_item(2, "SA36", 43.125, 0.5, 94.75);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 21);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 3, "S/40", 20);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 135.75);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 116.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_120_183()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1);
            Add_weldpad_item(4, "SA36", 8, 0.375);
            Add_vbaffle_item(18, 113);
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_vbaffle_item(18, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_repad_item(2, "SA516-70", 13, 0.375, 8);
            Add_plate_item(4, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 8, 0);
            Add_vortex_breaker_item(2, 10, 8);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 56.75, 0.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 71);
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 130);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 51.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 105);
            Add_saddle_web_item(2, "SA36", 51.125, 0.5, 105);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 21.25);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 14, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 4, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 3, "S/40", 20);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 146.625);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 131);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HR_144_195()
        {
            Add_pipe_nameplate_items();
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_weldpad_item(4, "SA36", 8, 0.375);
            Add_vbaffle_item(24, 113);
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_vbaffle_item(18, 24);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_repad_item(4, "SA516-70", 13, 0.375, 8);
            Add_plate_item(16, "VORTEX BREAKER", "SA36", 7.75, 0.1875, 8, 0);
            Add_vortex_breaker_item(4, 10, 8);
            Add_plate_item(2, "BAFFLE", "SA36", 6, 0.375, 56.75, 0.5);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 87);
            Add_repad_item(1, "SA516-70", 36, 0.375, 20);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 156);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 55.875);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 126);
            Add_saddle_web_item(2, "SA36", 55.875, 0.5, 156);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 31.25);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 21.5);
            Add_saddle_rib_item(2, "SA36", 7, 0.5, 18.375);
            Add_angle_item(1, "INTERNAL", "SA36", 2, 0.25, 25.375, 0.5);
            Add_angle_item(1, "INTERNAL", "SA36", 2, 0.25, 63.125, 0.5);
            Add_angle_item(4, "INTERNAL", "SA36", 2, 0.25, 71, 0.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 20, "STD", 10.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 16, "STD", 10.5);
            Add_nozzle_item(2, "PIPE", "PUMP SUCTION", "SA106B", 8, "S/40", 14);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 12);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 5, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "MIN FLOW", "SA106B", 4, "S/40", 20);
            Add_nozzle_item(1, "PIPE", "OIL DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 8.5);
            Add_nozzle_item(2, "PIPE", "MOTOR RECIRC", "SA106B", 0.75, "S/80", 177.75);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 147);

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