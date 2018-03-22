
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class HA : Vessel
    {
        public HA(ProductInfo info) : base(info) { }


        public List<ListItem> HA_24_135()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 17.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_vbaffle_item(6, 113);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 17);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 14.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_30_138()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 20.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 6, "S/40", "");
            Add_backer_item(1, 6);
            Add_vbaffle_item(6, 113);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 17.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_36_141()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 24.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 8, "S/40", "");
            Add_backer_item(1, 8);
            Add_vbaffle_item(8, 113);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 20.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_42_144()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 27.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 8, "S/40", "");
            Add_backer_item(1, 8);
            Add_vbaffle_item(8, 113);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 23.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_48_147()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 30.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 8, "S/40", "");
            Add_backer_item(1, 8);
            Add_vbaffle_item(10, 113);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 26.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_54_150()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 33.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_bw_fitting_item(1, "B.W. PIPE CAP", "SUMP", "SA234-WPB", 8, "S/40", "");
            Add_backer_item(1, 8);
            Add_vbaffle_item(10, 113);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/40", 17.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 11);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 29.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_60_153()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 46.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_vbaffle_item(10, 113);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 29.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_72_159()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_weldpad_item(4, "SA36", 6, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 52.75);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_vbaffle_item(14, 113);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 10, "S/40", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 35.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_84_165()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 93);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 59.25);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_vbaffle_item(14, 113);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 12, "STD", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 41.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_96_171()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 105);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 62.25);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_vbaffle_item(18, 113);
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_angle_item(1, "INTERNAL SUPPORT", "SA36", 2, 0.25, 42.5, 0.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 14, "STD", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 9);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 47.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_108_177()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 118);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 71.25);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_vbaffle_item(18, 113);
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_angle_item(1, "INTERNAL SUPPORT", "SA36", 2, 0.25, 48.5, 0.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 12, "STD", 9);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 53.5);

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_120_183()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 131);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 77.25);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_vbaffle_item(18, 113);
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_repad_item(1, "SA516-70", 24, 0.375, 14);
            Add_angle_item(1, "INTERNAL SUPPORT", "SA36", 2, 0.25, 54.5, 0.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 16, "STD", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 14, "STD", 9);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 59.5);

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HA_144_195()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 156);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 0.75, "S/80", 94.5);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_backer_item(1, 12);
            Add_repad_item(1, "SA516-70", 36, 0.375, 20);
            Add_repad_item(1, "SA516-70", 28, 0.375, 16);
            Add_vbaffle_item(18, 113);
            Add_weldpad_item(4, "SA36", 10, 0.625);
            Add_angle_item(1, "INTERNAL SUPPORT", "SA36", 2, 0.25, 73, 0.5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA53B-ERW", 20, "STD", 10);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA53B-ERW", 16, "STD", 9);
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 25.5);
            Add_nozzle_item(2, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 12);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "3-WAY VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "OIL POT VENT", "SA106B", 0.75, "S/80", 65.5);

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
