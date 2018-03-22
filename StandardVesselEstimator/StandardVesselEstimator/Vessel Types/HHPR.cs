
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    public class HHPR: Vessel
    {
        public HHPR(ProductInfo info):base(info) { }

        public List<ListItem> HHPR_20_96()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 81);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_saddle_rib_item(4, "SA36", 4, 0.375, 17);
            Add_saddle_base_item(2, "SA36", 4, 0.375, 17.5);
            Add_saddle_web_item(2, "SA36", 16.5, 0.375, 17.5);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 8.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 29.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 0.75, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_20_144()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 129);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_saddle_rib_item(4, "SA36", 4, 0.375, 17);
            Add_saddle_base_item(2, "SA36", 4, 0.375, 17.5);
            Add_saddle_web_item(2, "SA36", 16.5, 0.375, 17.5);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 8.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 29.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_24_144()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 127.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_saddle_rib_item(4, "SA36", 4, 0.375, 18.5);
            Add_saddle_base_item(2, "SA36", 4, 0.375, 21);
            Add_saddle_web_item(2, "SA36", 21, 0.375, 17.625);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 34);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 8.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_24_192()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 175.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_saddle_rib_item(4, "SA36", 4, 0.375, 18);
            Add_saddle_base_item(2, "SA36", 4, 0.375, 21);
            Add_saddle_web_item(2, "SA36", 17.625, 0.375, 21);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 34);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 8.5);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_30_138()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_saddle_rib_item(4, "SA36", 4, 0.375, 19.5);
            Add_saddle_base_item(2, "SA36", 4, 0.375, 26.25);
            Add_saddle_web_item(2, "SA36", 19.125, 0.375, 26.25);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 40);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_36_141()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_web_item(2, "SA36", 31.5, 0.375, 20.625);
            Add_saddle_rib_item(4, "SA36", 4, 0.375, 21);
            Add_saddle_base_item(2, "SA36", 4, 0.375, 31.5);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);
            
            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 46);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_42_144()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_rib_item(4, "SA36", 6, 0.375, 22.625);
            Add_saddle_base_item(2, "SA36", 6, 0.375, 36.75);
            Add_saddle_web_item(2, "SA36", 22.25, 0.375, 36.75);
            Add_flathead_item(1, "SA516-70", 5.5, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 52.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_48_147()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_rib_item(4, "SA36", 6, 0.375, 23.875);
            Add_saddle_base_item(2, "SA36", 6, 0.375, 41.75);
            Add_saddle_web_item(2, "SA36", 23.5, 0.375, 41.75);
            Add_flathead_item(1, "SA516-70", 5.5, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 58.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_48_266()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(3, 48);
            Add_od_rolled_shell_item(2, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_rib_item(4, "SA36", 6, 0.375, 23.875);
            Add_saddle_base_item(2, "SA36", 6, 0.375, 41.75);
            Add_saddle_web_item(2, "SA36", 23.5, 0.375, 41.75);
            Add_flathead_item(1, "SA516-70", 5.5, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 59);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_54_150()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_rib_item(4, "SA36", 6, 0.5, 25.5);
            Add_saddle_base_item(2, "SA36", 6, 0.5, 47);
            Add_saddle_web_item(2, "SA36", 25, 0.5, 47);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 65);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_54_269()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(2, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_rib_item(4, "SA36", 6, 0.5, 25.5);
            Add_saddle_base_item(2, "SA36", 6, 0.5, 47);
            Add_saddle_web_item(2, "SA36", 25, 0.5, 47);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 65);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_60_153()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 68);
            Add_saddle_rib_item(4, "SA36", 6, 0.5, 26.875);
            Add_saddle_base_item(2, "SA36", 6, 0.5, 53.25);
            Add_saddle_web_item(2, "SA36", 26.375, 0.5, 53.25);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 69.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_60_272()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(2, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 8, 0.5, 68);
            Add_saddle_rib_item(4, "SA36", 6, 0.5, 26.875);
            Add_saddle_base_item(2, "SA36", 6, 0.5, 53.25);
            Add_saddle_web_item(2, "SA36", 26.375, 0.5, 53.25);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 71.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_72_159()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 80);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 29.75);
            Add_saddle_base_item(2, "SA36", 8, 0.5, 63.5);
            Add_saddle_web_item(2, "SA36", 29.25, 0.5, 63.5);
            Add_flathead_item(1, "SA516-70", 5.75, 0.625);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 83.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_72_276()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(3, 72);
            Add_od_rolled_shell_item(2, "SA516-70", 72, 0.625, 118);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 80);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 29.75);
            Add_saddle_base_item(2, "SA36", 8, 0.5, 63.5);
            Add_saddle_web_item(2, "SA36", 29.25, 0.5, 63.5);
            Add_flathead_item(1, "SA516-70", 7.375, 0.625);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 84.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_84_165()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 93);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 32.875);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 74);
            Add_saddle_web_item(2, "SA36", 32.25, 0.5, 74);
            Add_flathead_item(1, "SA516-70", 7.75, 0.625);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 96.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_84_282()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(2, "SA516-70", 84, 0.625, 118);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 93);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 32.875);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 74);
            Add_saddle_web_item(2, "SA36", 32.25, 0.5, 74);
            Add_flathead_item(1, "SA516-70", 9.75, 0.625);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 10, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 97.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_96_171()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 105);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 35.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 84.25);
            Add_saddle_web_item(2, "SA36", 35.125, 0.5, 84.25);
            Add_flathead_item(1, "SA516-70", 7.75, 0.625);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 8, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 108.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_96_288()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(2, "SA516-70", 96, 0.625, 118);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 105);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 35.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 84.25);
            Add_saddle_web_item(2, "SA36", 35.125, 0.5, 84.25);
            Add_flathead_item(1, "SA516-70", 9.75, 0.625);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 10, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 109.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_108_177()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 118);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 38.875);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 94.75);
            Add_saddle_web_item(2, "SA36", 38.25, 0.5, 94.75);
            Add_flathead_item(1, "SA516-70", 9.75, 0.625);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 10, "S/40", 9.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 121.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_108_296()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(2, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 1);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 118);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 38.875);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 94.75);
            Add_saddle_web_item(2, "SA36", 38.25, 0.5, 94.75);
            Add_flathead_item(1, "SA516-70", 11.75, 0.625);
            Add_repad_item(1, "SA516-70", 20, 0.375, 12);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 11.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 122.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_120_183()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 130);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 41.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 105);
            Add_saddle_web_item(2, "SA36", 41.125, 0.5, 105);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 13.375);
            Add_flathead_item(1, "SA516-70", 9.75, 0.625);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 133.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_120_302()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(2, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1.25);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 130);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 41.75);
            Add_saddle_base_item(2, "SA36", 8, 0.625, 105);
            Add_saddle_web_item(2, "SA36", 41.125, 0.5, 105);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 13.375);
            Add_flathead_item(1, "SA516-70", 11.75, 0.625);
            Add_repad_item(1, "SA516-70", 21, 0.375, 12);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 11.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 134.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 2, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_144_195()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 156);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 47.875);
            Add_saddle_base_item(2, "SA36", 8, 1, 126);
            Add_saddle_web_item(2, "SA36", 46.875, 0.5, 126);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 13.5);
            Add_flathead_item(1, "SA516-70", 11.75, 0.625);
            Add_repad_item(1, "SA516-70", 23, 0.375, 12);
            Add_repad_item(1, "SA516-70", 17, 0.625, 10);
            Add_weldpad_item(4, "SA36", 10, 0.625);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 11.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 158.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 2, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> HHPR_144_314()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(2, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_saddle_band_item(2, "SA36", 10, 0.5, 156);
            Add_saddle_rib_item(4, "SA36", 8, 0.5, 47.875);
            Add_saddle_base_item(2, "SA36", 8, 1, 126);
            Add_saddle_web_item(2, "SA36", 46.875, 0.5, 126);
            Add_saddle_rib_item(4, "SA36", 7, 0.5, 13.5);
            Add_flathead_item(1, "SA516-70", 11.75, 0.625);
            Add_repad_item(2, "SA516-70", 23, 0.375, 12);
            Add_flat_bar_item(1, "LIQUID OUTLET SUPPORT", "SA36", 2, 0.25, 7);
            Add_weldpad_item(4, "SA36", 10, 0.625);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "SUMP", "SA53B-ERW", 12, "STD", 11.5);
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA53B-ERW", 12, "STD", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 158.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");

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
