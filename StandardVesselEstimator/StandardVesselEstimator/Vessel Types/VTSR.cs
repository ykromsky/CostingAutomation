
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VTSR : Vessel
    {
        public VTSR(ProductInfo info) : base(info) { }

        public List<ListItem> VTSR_8_48()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 8);
            Add_pipe_shell_item(1, "SA106B", 8, "S/40", 40);
            Add_bw_fitting_item(2, "B.W. PIPE CAP", "HEAD", "SA234-WPB", 8, "S/40", "");
            Add_angle_clip_item(4, "SA36", 2, 0.25, 6);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9.5);
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


        public List<ListItem> VTSR_10_48()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 10);
            Add_pipe_shell_item(1, "SA106B", 10, "S/40", 38);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 10.75, 0.375);
            Add_angle_clip_item(4, "SA36", 2, 0.25, 6);
            Add_sw_fitting_item(1, "S.W. 90 ELBOW", "INTERNAL", "SA105", 2, "3000#");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 2, "S/80", 10.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.5, "S/80", 9.5);
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


        public List<ListItem> VTSR_12_48()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 37);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 2.5, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9.5);
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


        public List<ListItem> VTSR_12_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 61);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 3, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VTSR_16_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 61);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 4, "S/40", 10.5);
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


        public List<ListItem> VTSR_20_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 57);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_clip_item(4, "SA36", 3, 0.25, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 4, "S/40", 10.5);
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


        public List<ListItem> VTSR_24_72()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 55.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 5, "S/40", 10.5);
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


        public List<ListItem> VTSR_30_84()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 65);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_clip_item(4, "SA36", 4, 0.375, 6);
            Add_bw_fitting_item(1, "B.W. 90 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "L.R.");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S RETURN", "SA106B", 6, "S/40", 10.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "T/S SUPPLY", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

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