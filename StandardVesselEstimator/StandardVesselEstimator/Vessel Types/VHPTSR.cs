
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class VHPTSR : Vessel
    {
        public VHPTSR(ProductInfo info) : base(info) { }

        public List<ListItem> VHPTSR_36_141()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 36);
            Add_od_rolled_shell_item(1, "SA516-70", 36, 0.375, 119);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 36, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 40.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_thermosyphon_plate(1, "SA36", 35, 0.375);
            Add_thermosyphon_pipe(1, "SA106B", 8, "S/40", 18);
            Add_end_plate(1, "SA36", 2.75, 0.375);
            Add_end_plate(1, "SA36", 4, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 1.5, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 1.5, "S/80", 17.75);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 2.5, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 3, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 2.5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 1.5, "S/80", 11.75);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "RELIEF", "SA106B", 0.75, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", 0.75, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 18.625);
            Add_nozzle_item(1, "PIPE", "DRAIN", "SA106B", 0.75, "S/80", 8.5);
            Add_nozzle_item(3, "PIPE", "HYDRO TEST VENT", "SA106B", 1.5, "S/80", 7.5);

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_48_195()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 48);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 48, 0.375, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 48, 0.375);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 40.5);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_thermosyphon_plate(1, "SA36", 47, 0.375);
            Add_thermosyphon_pipe(1, "SA106B", 8, "S/40", 18);
            Add_end_plate(2, "SA36", 3.75, 0.375);
            Add_sw_fitting_item(1, "S.W. 45 ELBOW", "INTERNAL", "SA105", 2, "3000#");
            Add_sw_pipe_item(1, "INTERNAL", "SA106B", 2, "S/80", 22.125);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 4, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2, "S/80", 15.5);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", 0.75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_54_198()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 54);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 54, 0.5, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 54, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 45);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_thermosyphon_plate(1, "SA36", 52.75, 0.5);
            Add_thermosyphon_pipe(1, "SA106B", 8, "S/40", 18);
            Add_end_plate(2, "SA36", 3.75, 0.375);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 2.5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 2.5, "S/40", 25.125);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 4, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 2.5, "S/40", 15.75);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", 0.75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 0.75, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("NONE", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_60_201()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 60);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 60, 0.5, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 60, 0.5);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 45);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_thermosyphon_plate(1, "SA36", 58.75, 0.5);
            Add_thermosyphon_pipe(1, "SA106B", 8, "S/40", 18);
            Add_end_plate(2, "SA36", 3.75, 0.375);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 3, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 3, "S/40", 26.625);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 4, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 4, "S/40", 19.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 3, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 3, "S/40", 18.5);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", 0.75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "NONE");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_72_207()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 72);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 72, 0.625, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 72, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(3, 6, 0.375, 45);
            Add_plate_item(3, "BASE PLATE", "SA36", 10, 0.5, 10, 0);
            Add_thermosyphon_plate(1, "SA36", 70.5, 0.5);
            Add_thermosyphon_pipe(1, "SA53B-ERW", 12, "STD", 18);
            Add_end_plate(2, "SA36", 4.75, 0.375);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 30.875);
            Add_repad_item(1, "SA516-70", 9, 0.375, 4);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 5, "S/40", 21.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 5, "S/40", 21.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 4, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 21.75);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", 0.75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_84_213()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 84);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 118);
            Add_od_rolled_shell_item(1, "SA516-70", 84, 0.625, 49);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 84, 0.625);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 52.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_thermosyphon_plate(1, "SA36", 82.25, 0.625);
            Add_thermosyphon_pipe(1, "SA53B-ERW", 12, "STD", 18);
            Add_end_plate(2, "SA36", 5.75, 0.375);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 4, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 4, "S/40", 35);
            Add_repad_item(1, "SA516-70", 9, 0.375, 5);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 25.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 6, "S/40", 25.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 4, "S/40", 21.75);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", 1, "S/80", 10);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_96_219()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 96);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 118);
            Add_od_rolled_shell_item(1, "SA516-70", 96, 0.625, 49);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 96, 0.75);
            Add_lift_lug_item(2, 0.75);
            Add_angle_leg_item(4, 8, 0.75, 55.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_thermosyphon_plate(1, "SA36", 94.5, 0.625);
            Add_thermosyphon_pipe(1, "SA53B-ERW", 16, "STD", 18);
            Add_end_plate(2, "SA36", 5.75, 0.375);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 40.625);
            Add_repad_item(2, "SA516-70", 10, 0.375, 5);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 6, "S/40", 22.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 6, "S/40", 22.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 5, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 26.375);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", .75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_108_225()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 108);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 108, 0.75, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 108, 0.75);
            Add_lift_lug_item(4, 1);
            Add_beam_leg_item(4, 8, "31#", 58.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_weldpad_item(4, "SA36", 12, 0.5);
            Add_thermosyphon_plate(1, "SA36", 106.25, 0.625);
            Add_thermosyphon_pipe(1, "SA53B-ERW", 16, "STD", 18);
            Add_end_plate(2, "SA36", 7.75, 0.375);
            Add_repad_item(2, "SA516-70", 13, 0.375, 8);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 5, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 5, "S/40", 44.875);
            Add_repad_item(1, "SA516-70", 12, 0.625, 6);
            Add_repad_item(1, "SA516-70", 11, 0.375, 6);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 26.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 8, "S/40", 26.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 5, "S/40", 28.5);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", .75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("FULL", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_120_231()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 120);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 120, 1, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70", 120, 1);
            Add_lift_lug_item(4, 1.25);
            Add_beam_leg_item(4, 8, "31#", 61.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 12, 0.5, 12, 0);
            Add_weldpad_item(4, "SA36", 12, 0.5);
            Add_thermosyphon_plate(1, "SA36", 117.75, 0.625);
            Add_thermosyphon_pipe(1, "SA53B-ERW", 16, "STD", 18);
            Add_end_plate(2, "SA36", 7.75, 0.375);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 50.5);
            Add_weldpad_item(4, "SA36", 8, 0.5);
            Add_repad_item(1, "SA516-70", 12, 0.625, 6);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 8, "S/40", 26.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 8, "S/40", 26.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 6, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 30.75);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", .75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

            Add_blank_item();
            Add_radiography_item("SPOT", "SPOT");
            Add_paint_items();
            Add_purge_kit_items();
            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        public List<ListItem> VHPTSR_144_243()
        {
            Add_nameplate_item("SA36", 2);
            Add_backer_item(2, 144);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 119);
            Add_od_rolled_shell_item(1, "SA516-70", 144, 1, 48);
            Add_head_items(2, "OD ELLIP HEAD", "SA516-70 NORM", 144, 1.125);
            Add_lift_lug_item(4, 1.25);
            Add_beam_leg_item(4, 10, "68#", 67.5);
            Add_plate_item(4, "BASE PLATE", "SA36", 14, 0.5, 14, 0);
            Add_weldpad_item(4, "SA36", 14, 0.5);
            Add_thermosyphon_plate(1, "SA36", 141.75, 0.625);
            Add_thermosyphon_pipe(1, "SA53B-ERW", 16, "STD", 18);
            Add_end_plate(2, "SA36", 9.75, 0.375);
            Add_repad_item(2, "SA516-70", 15, 0.375, 10);
            Add_repad_item(1, "SA516-70", 13, 0.375, 8);
            Add_bw_fitting_item(1, "B.W. 45 ELBOW", "INTERNAL", "SA234-WPB", 6, "S/40", "");
            Add_bw_pipe_item(1, "INTERNAL", "SA106B", 6, "S/40", 53.25);
            Add_weldpad_item(4, "SA36", 10, 0.625);
            Add_repad_item(1, "SA516-70", 16, 0.75, 8);
            Add_weldpad_item(1, "SA36", 4, 0.375);

            Add_blank_item();
            Add_nozzle_item(1, "PIPE", "LIQUID INLET", "SA106B", 10, "S/40", 30.5);
            Add_nozzle_item(1, "PIPE", "TSR", "SA106B", 10, "S/40", 30.5);
            Add_nozzle_item(1, "PIPE", "TSS", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "EQUALIZER", "SA106B", 8, "S/40", 9);
            Add_nozzle_item(1, "PIPE", "LIQUID OUTLET", "SA106B", 6, "S/40", 37.75);
            Add_nozzle_item(2, "PIPE", "HP COLUMN CONN", "SA106B", 1.25, "S/80", 9);
            Add_nozzle_item(2, "PIPE", "T/S COLUMN CONN", "SA106B", 1, "S/80", 9);
            Add_nozzle_item(1, "PIPE", "T/S DRAIN", "SA106B", 0.75, "S/80", 23.125);
            Add_nozzle_item(1, "PIPE", "PURGE", "SA106B", .75, "S/80", 10);
            Add_nozzle_item(1, "THD CPLG", "RELIEF", "SA105", 1.25, "3000#");
            Add_nozzle_item(1, "THD CPLG", "DRAIN", "SA105", 0.75, "3000#");
            Add_nozzle_item(3, "THD CPLG", "HYDRO TEST VENT", "SA105", 0.75, "3000#");

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
