
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class HTSR : Vessel
    {
        public HTSR(ProductInfo info) : base(info) { }

        public List<ListItem> HTSR_8_48()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 8);
            Add_pipe_shell_item(1, "SA106B", 8, "S/40", 40);
            Add_bw_fitting_item(2, "B.W. PIPE CAP", "HEAD", "SA234-WPB", 8, "S/40", "");
            Add_angle_clip_item(4, "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_10_48()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 10);
            Add_pipe_shell_item(1, "SA106B", 10, "S/40", 38);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 10.75, 0.375);
            Add_angle_clip_item(4, "SA36", 2, 0.25, 6);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_12_48()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 37);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_12_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 61);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_16_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 59);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_20_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 57);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_24_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 55.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_30_84()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 65);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_36_96()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 74);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_angle_clip_item(4, "SA36", 6, 0.375, 7);
            Add_lift_lug_item(2, 0.75);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_42_120()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 95);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_angle_clip_item(4, "SA36", 6, 0.375, 7);
            Add_lift_lug_item(2, 0.75);
            Add_repad_item(3, "SA516-70", 13, 0.375, 8);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HTSR_48_147()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_angle_clip_item(4, "SA36", 6, 0.375, 7);
            Add_lift_lug_item(2, 0.75);
            Add_repad_item(2, "SA516-70", 17, 0.375, 10);
            Add_repad_item(1, "SA516-70", 15, 0.375, 10);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }
    }
}