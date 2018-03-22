
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class HOP : Vessel
    {
        public HOP(ProductInfo info) : base(info) { }

        public List<ListItem> HOP_8_36()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 8);
            Add_pipe_shell_item(1, "SA106B", 8, "S/40", 28);
            Add_bw_fitting_item(2, "B.W. PIPE CAP", "HEAD", "SA234-WPB", 8, "S/40", "");
            Add_small_saddle_items("SA36");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "INLET", "SA106B", 2, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "OUTLET", "SA106B", 0.75, "S/80", 14.75);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 0.75, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }

        public List<ListItem> HOP_10_36()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 10);
            Add_pipe_shell_item(1, "SA106B", 10, "S/40", 26);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 10.75, 0.375);
            Add_small_saddle_items("SA36");

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "INLET", "SA106B", 2, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "OUTLET", "SA106B", 0.75, "S/80", 17);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 0.75, "S/80", 13.5);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 1.5, "S/80", 9);

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
