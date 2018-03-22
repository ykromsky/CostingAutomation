
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VPR : Vessel
    {
        public VPR(ProductInfo info) : base(info) { }

        public List<ListItem> VPR_10_48()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 10);
            Add_pipe_shell_item(1, "SA106B", 10, "S/40", 38);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 10.75, 0.375);
            Add_angle_leg_item(3, 2, 0.25, 28.75);
            Add_plate_item(3, "BASE PLATE", "SA36", 3, 0.25, 3, 0);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "THD CPLG", "PILOT CHAMBER BALANCE CONN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VPR_12_48()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 12);
            Add_pipe_shell_item(1, "SA53B-ERW", 12, "STD", 37);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 12.75, 0.375);
            Add_angle_leg_item(3, 3, 0.25, 29.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "THD CPLG", "PILOT CHAMBER BALANCE CONN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VPR_16_60()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 16);
            Add_pipe_shell_item(1, "SA53B-ERW", 16, "STD", 45);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 16, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 30.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(2, "THD CPLG", "PILOT CHAMBER BALANCE CONN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }

        public List<ListItem> VPR_20_60()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 45);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 31.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(2, "THD CPLG", "PILOT CHAMBER BALANCE CONN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VPR_24_72()
        {
            Add_nameplate_item("SA36", 6);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 55.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 37.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "VENT", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(2, "THD CPLG", "PILOT CHAMBER BALANCE CONN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.5, "3000#");
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