
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class HSD : Vessel
    {
        public HSD(ProductInfo info) : base(info) { }

        public List<ListItem> HSD_12_48()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 37);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 2.5, "S/40", 18.375);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HSD_16_60()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 47);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 3, "S/40", 20);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 12.5);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HSD_20_72()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 57);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 22);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HSD_24_72()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 55.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 4, "S/40", 24);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 0.75, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HSD_30_96()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 77);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 5, "S/40", 27);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HSD_36_96()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 74);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_angle_clip_item(4, "SA36", 6, 0.375, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 6, "S/40", 30);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.25, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HSD_42_120()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 95);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_clip_item(4, "SA36", 6, 0.375, 7);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 8, "S/40", "L.R.");
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUCTION INLET", "SA106B", 8, "S/40", 33);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 8, "S/40", 13);
            Add_nozzle_item(1, "PIPE", "SUCTION OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID MAKE-UP", "SA106B", 1.5, "S/80", 10.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }
    }
}