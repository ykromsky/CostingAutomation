
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VHPR : Vessel
    {
        public VHPR(ProductInfo info) : base(info) { }


        public List<ListItem> VHPR_20_144()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 20);
            Add_pipe_shell_item(1, "SA53B-ERW", 20, "STD", 129);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 20, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 37.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1, "S/80", 12.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_lift_lug_item(2, 0.75);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 1.5, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_24_144()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 24);
            Add_pipe_shell_item(1, "SA53B-ERW", 24, "STD", 127.5);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 24, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 37.875);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 14);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_lift_lug_item(2, 0.75);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 9.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_30_138()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 30);
            Add_od_rolled_shell_item(1, "SA516-70", 30, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 30, 0.375);
            Add_angle_leg_item(3, 4, 0.375, 39.125);
            Add_plate_item(3, "BASE PLATE", "SA36", 6, 0.375, 6, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.25, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.25, "S/80", 15.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_lift_lug_item(2, 0.75);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.25, "S/80", 11.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_36_141()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 40.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 17.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 12.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.5, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_42_144()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 42);
            Add_od_rolled_shell_item(1, "SA516-70", 42, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 42, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 42);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 20);
            Add_weldpad_item(1, "SA36", 4, 0.375);


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 14);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_48_147()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 43.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 22.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);


            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 15.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_48_195()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 43.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 22.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 48);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 15.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_54_150()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 45);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 25.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 16);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_54_198()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 45);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 2.5, "S/40", 25);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 48);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 15.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_60_153()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 46.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 2.5, "S/40", 27.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 20);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_60_201()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 46.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 25.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 48);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 18.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_72_159()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.5, 49.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 29.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 21.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_72_207()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 118);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.5, 49.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 29.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 49);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 21.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_84_165()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 52.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 33.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 23.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_84_213()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 118);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 52.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 33.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 49);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 23.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_96_171()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 55.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 38);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_repad_item(1, "SA516-70", 9, 0.375, 4);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 25.25);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_96_219()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 118);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 55.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 39.25);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 49);
            Add_repad_item(1, "SA516-70", 10, 0.375, 5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 24.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_108_177()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 58.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 43.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_repad_item(1, "SA516-70", 10, 0.375, 5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 28.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_108_225()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 1);
            Add_angle_leg_item(4, 8, 0.75, 58.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 43.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 48);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_repad_item(1, "SA516-70", 10, 0.625, 5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 28.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_120_183()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1);
            Add_beam_leg_item(4, 8, "31#", 76.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_plate_item(4, "LEG PAD", "SA36", 14, 0.5, 26, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 47.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_repad_item(1, "SA516-70", 10, 0.625, 5);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 31.5);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_120_231()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1.25);
            Add_beam_leg_item(4, 8, "31#", 74.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_plate_item(4, "LEG PAD", "SA36", 14, 0.5, 26, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 49);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 48);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_repad_item(1, "SA516-70", 11, 0.625, 6);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 30.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_144_195()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_beam_leg_item(4, 10, "68#", 80.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 14, 0.5, 14, 0);
            Add_plate_item(4, "LEG PAD", "SA36", 14, 0.5, 26, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 57.5);
            Add_repad_item(1, "SA516-70", 15, 0.375, 10);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_repad_item(1, "SA516-70", 11, 0.625, 6);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 37.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPR_144_243()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_beam_leg_item(4, 10, "68#", 80.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 14, 0.5, 14, 0);
            Add_plate_item(4, "LEG PAD", "SA36", 14, 0.5, 26, 0);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 57.5);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 48);
            Add_repad_item(1, "SA516-70", 17, 0.375, 10);
            Add_weldpad_item(4, "SA36", 10, 0.625);
            Add_weldpad_item(1, "SA36", 4, 0.375);
            Add_repad_item(1, "SA516-70", 11, 0.625, 6);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 10, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 37.75);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(2, "PIPE", "COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "PURGE", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

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
