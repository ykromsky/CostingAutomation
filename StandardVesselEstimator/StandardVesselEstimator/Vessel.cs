using System;
using System.Collections.Generic;

namespace StandardVesselEstimator
{
    public class Vessel : Product
    {
        public Vessel(ProductInfo info) : base (info)
        {
            //productInfo = info;
            //partsBook = new PartsBook();
            //labor = new Labor();
            //ListItems = new List<ListItem>();
        }


        protected void Add_backer_item(int quantity, int size)
        {
            string length = NA;

            //backers
            if (productInfo.VesselSize <= 24)
                Add_item(quantity.ToString(), "BACKING RING", NA, "SA414", size.ToString(), "3/32\"", length,
                         NA, NA, NA, "1", f_UnitPrice,
                         NA, NA, NA, NA, NA, "0");
            else
                length = Math.Ceiling((size * Math.PI)).ToString();
                Add_item(quantity.ToString(), "BACKING STRIP", NA, "SA36", "1.5", "0.125", length,
                         NA, NA, NA, "1", f_UnitPrice,
                         NA, NA, NA, NA, NA, "0");
        }


        protected void Add_head_items(int quantity, string description, string material, double size, double rating)
        {
            string welderLabor = labor.get_girth_seam_hours(productInfo.Pressure, productInfo.VesselSize, productInfo.VesselShellLength).ToString();
            string blastLabor = labor.get_head_blast_hours(size).ToString();
            string subarcLabor = labor.get_girth_subarc_hours(size, rating).ToString();

            Add_item(quantity.ToString(), description, "HEAD", material, size.ToString(), rating.ToString(), NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, subarcLabor, NA, blastLabor, welderLabor);
        }


        protected void Add_od_rolled_shell_item(int quantity, string material, int size, double rating, double length)
        {
            string welderLabor = labor.get_long_seam_hours(productInfo.Pressure, productInfo.VesselSize, productInfo.VesselShellLength).ToString();
            string blastLabor = (labor.get_shell_blast_hours(size) * length/119).ToString();
            string subarcLaborLong = labor.get_long_seam_subarc_hours(rating, length).ToString();
            string subarcLaborGirth = labor.get_girth_subarc_hours(size, rating).ToString();

            double subcontract120 = 1350;
            double subcontract144 = 1540;
            double subcontract = 0;

            //shells
            if (productInfo.VesselSize > 108)  //rolled outside
            {
                Add_item(quantity.ToString(), "OD ROLLED PLATE", "SHELL", material, size.ToString(), rating.ToString(), length.ToString(),
                         f_Circumference, f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                         NA, NA, subarcLaborLong, NA, blastLabor, welderLabor);

                if (productInfo.VesselSize == 120) subcontract = subcontract120;
                if (productInfo.VesselSize == 144) subcontract = subcontract144;
                Add_item(quantity.ToString(), "SUBCONTRACT ROLL", "*PRICE PER JULY '17", NA, size.ToString(), rating.ToString(), length.ToString(),
                         NA, NA, NA, "1", subcontract.ToString(),
                         NA, NA, NA, NA, NA, "0");
            }
            else  //rolled inhouse
            {
                string rollingLabor = labor.get_rolling_hours(productInfo.VesselSize).ToString();
                string plasmaLabor = labor.get_plasma_hours(size * Math.PI, rating, length).ToString();
                Add_item(quantity.ToString(), "OD ROLLED PLATE", "SHELL", material, size.ToString(), rating.ToString(), length.ToString(),
                         f_Circumference, f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                         plasmaLabor, rollingLabor, subarcLaborLong, NA, blastLabor, welderLabor);
            }

            if(quantity > 1) Add_item((quantity - 1).ToString(), "SHL-SHL SEAM", NA, NA, NA, NA, NA,
                                      NA, NA, NA, NA, NA,
                                      NA, NA, subarcLaborGirth, NA, NA, NA);
        }


        protected void Add_pipe_shell_item(int quantity, string material, int size, string rating, double length)
        {
            double welderLabor = labor.get_pipe_shell_hours();

            Add_pipe_item(1, "SHELL", material, size, rating, length, welderLabor);
        }


        protected void Add_saddle_web_item(int quantity, string material, double size, double rating, double length)
        {
            double welderLabor = labor.get_saddle_web_hours(productInfo.VesselSize);
            Add_plate_item(quantity, "SADDLE WEB", material, size, rating, length, welderLabor);
        }


        protected void Add_saddle_base_item(int quantity, string material, double size, double rating, double length)
        {
            double welderLabor = labor.get_saddle_base_hours(productInfo.VesselSize);
            Add_plate_item(quantity, "SADDLE BASE", material, size, rating, length, welderLabor);
        }


        protected void Add_saddle_rib_item(int quantity, string material, double size, double rating, double length)
        {
            double welderLabor = labor.get_saddle_rib_hours(productInfo.VesselSize);
            Add_plate_item(quantity, "SADDLE RIB", material, size, rating, length, welderLabor);
        }


        protected void Add_saddle_band_item(int quantity, string material, double size, double rating, double length)
        {
            double welderLabor = labor.get_saddle_band_hours(productInfo.VesselSize);
            Add_plate_item(quantity, "SADDLE BAND", material, size, rating, length, welderLabor);
        }


        protected void Add_small_saddle_items(string material)
        {
            double welderLabor = 0.5;

            if (productInfo.VesselSize == 8)
            {
                Add_item("2", "STD SADDLE", "SUPPORT", material, "8", "0.375", NA,
                         NA, NA, NA, "1", f_UnitPrice,
                         NA, NA, NA, NA, NA, welderLabor.ToString());
            }

            if (productInfo.VesselSize == 10)
            {
                Add_item("2", "STD SADDLE", "SUPPORT", material, "10", "0.375", NA,
                         NA, NA, NA, "1", f_UnitPrice,
                         NA, NA, NA, NA, NA, welderLabor.ToString());
            }
        }


        protected void Add_angle_leg_item(int quantity, double size, double rating, double length)
        {
            double welderLabor = labor.get_leg_hours(productInfo.VesselSize) /quantity;
            Add_angle_item(quantity, "ANGLE LEG", "SA36", size, rating, length, welderLabor);
        }


        protected void Add_beam_leg_item(int quantity, double size, string rating, double length)
        {
            double welderLabor = labor.get_leg_hours(productInfo.VesselSize) / quantity;
            Add_item(quantity.ToString(), "W.F. BEAM", "LEG", "A572 GR.50", size.ToString(), rating, length.ToString(),
                     NA, NA, NA, f_PipeUnits, f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_angle_clip_item(int quantity, string material, double size, double rating, double length)
        {
            double welderLabor = labor.get_angle_clip_hours(productInfo.VesselSize) / quantity;
            Add_angle_item(quantity, "ANGLE CLIP", material, size, rating, length, welderLabor);
        }


        protected void Add_nameplate_item(string material, double length)
        {
            double welderLabor = 0.5;

            Add_item("1", "STD NAMEPLATE BRKT", NA, material, "6", "3/16\"", length.ToString(), 
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());

            Add_item("1", "NAMEPLATE", NA, NA, NA, NA, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, "0");
        }


        protected void Add_pipe_nameplate_items()
        {
            double welderLabor = 0.25;
            Add_plate_item(1, "NAMEPLATE BRACKET", "SA240-304", 6, 0.375, 6, welderLabor);

            Add_pipe_item(1, "NAMEPLATE STANDOFF", "SA312-TP304", 2, "S/40S", 9, welderLabor);

            Add_item("1", "NAMEPLATE", NA, NA, NA, NA, NA, 
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, "0");
        }


        protected void Add_lift_lug_item(int quantity, double rating)
        {
            Add_plate_item(quantity, "STD LIFT LUG", "SA36", 6.375, rating, 6, 0.25);
        }


        protected void Add_repad_item(int quantity, string material, double size, double rating, double nozzleSize)
        {
            double welderLabor = labor.get_repad_hours(nozzleSize);

            Add_plate_item(quantity, "REPAD", material, size, rating, size, welderLabor);
        }
        

        protected void Add_weldpad_item(int quantity, string material, double size, double rating)
        {
            double welderLabor = labor.get_weldpad_hours(size);

            Add_plate_item(quantity, "WELD PAD", material, size, rating, size, welderLabor);
        }


        protected void Add_end_plate(int quantity, string material, double size, double rating)
        {
            double welderLabor = labor.get_end_plate_hours(size);

            Add_plate_item(quantity, "END PLATE", material, size, rating, size, welderLabor);
        }


        protected void Add_flathead_item(int quantity, string material, double size, double rating)
        {
            double welderLabor = 1;
            Add_plate_item(quantity, "FLAT HEAD", material, size, rating, size, welderLabor);
        }


        protected void Add_vortex_breaker_item(int quantity, double size, double nozzleSize)
        {
            double welderLabor = labor.get_vortex_breaker_hours(nozzleSize); 

            Add_plate_item(quantity * 2, "VORTEX BREAKER", "SA36", size, 0.1875, size, welderLabor);
        }


        protected void Add_thermosyphon_plate(int quantity, string material, double size, double rating)
        {
            double welderLabor = labor.get_thermosyphon_plate_hours(productInfo.VesselSize);
            Add_plate_item(quantity, "THERMOSYPHON PLATE", material, size, rating, size, welderLabor);
        }


        protected void Add_thermosyphon_pipe(int quantity, string material, double size, string rating, double length)
        {
            double welderLabor = labor.get_thermosyphon_plate_hours(productInfo.VesselSize);
            Add_pipe_item(quantity, "THERMOSYPHON PIPE", material, size, rating, size, welderLabor);
        }


        protected void Add_ubend_item(int quantity, double size, string rating)
        {
            double welderLabor = labor.get_sw_fitting_hours() + 0.25;
            Add_item(quantity.ToString(), "U-BEND PIPE", "INTERNAL", "SA106B", size.ToString(), rating, NA, 
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_coil_item(string description, string material, double size, string rating, string length)
        {
            double welderLabor = labor.get_coil_hours(productInfo.VesselSize);
            Add_item("1", description, NA, material, size.ToString(), rating, length, 
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_vbaffle_item(double size, double length)
        {
            double welderLabor = Math.Ceiling((0.01685 * length + 1.595) * 8) / 8;  //hours based on length (rounded up to nearest 1/8")

            Add_item("1", "V BAFFLE", NA, "SA36", size.ToString(), 0.3125.ToString(), length.ToString(),
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_distribution_box_items(double boxSize)
        {
            double hours = labor.get_distribution_box_hours(boxSize);
            string service = "DISTRIBUTION BOX";

            Add_labor_item("DISTRIBUTION BOX LABOR", hours);

            switch(boxSize)
            {
                case 3:
                    Add_plate_item(1, service, "SA36", 5.75, 0.375, 5.75, 0);
                    Add_pipe_item(1, service, "SA106B", 6, "S/40", 7, 0);
                    Add_plate_item(1, service, "SA36", 5.75, 0.375, 5.75, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "34.25", 
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 4:
                    Add_plate_item(1, service, "SA36", 7.75, 0.375, 7.75, 0);
                    Add_pipe_item(1, service, "SA106B", 8, "S/40", 9, 0);
                    Add_plate_item(1, service, "SA36", 12.75, 0.375, 12.75, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "40", 
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 5:
                    Add_plate_item(1, service, "SA36", 11.75, 0.375, 11.75, 0);
                    Add_pipe_item(1, service, "SA53B-ERW", 12, "STD", 6, 0);
                    Add_plate_item(1, service, "SA36", 16.75, 0.375, 16.75, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "53", 
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 6:
                    Add_plate_item(1, service, "SA36", 13, 0.375, 13, 0);
                    Add_pipe_item(1, service, "SA53B-ERW", 14, "STD", 8, 0);
                    Add_plate_item(1, service, "SA36", 18, 0.375, 18, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "57", 
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 8:
                    Add_plate_item(1, service, "SA36", 19, 0.375, 19, 0);
                    Add_pipe_item(1, service, "SA53B-ERW", 20, "STD", 9, 0);
                    Add_plate_item(1, service, "SA36", 28, 0.375, 28, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "88.75", 
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 10:
                    Add_plate_item(1, service, "SA36", 23, 0.375, 23, 0);
                    Add_pipe_item(1, service, "SA53B-ERW", 24, "STD", 12, 0);
                    Add_plate_item(1, service, "SA36", 32, 0.375, 32, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "101", 
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 12:
                    Add_plate_item(1, service, "SA36", 29, 0.375, 29, 0);
                    Add_item("1", "OD ROLLED PLATE", service, "SA36", "30", "0.375", "14", f_Circumference,
                             f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    Add_plate_item(1, service, "SA36", 38, 0.375, 38, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "119.75",
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 14:
                    Add_plate_item(1, service, "SA36", 29, 0.375, 29, 0);
                    Add_item("1", "OD ROLLED PLATE", service, "SA36", "30", "0.375", "14", f_Circumference,
                             f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    Add_plate_item(1, service, "SA36", 38, 0.375, 38, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "119.75",
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                case 16:
                    Add_plate_item(1, service, "SA36", 35, 0.375, 35, 0);
                    Add_item("1", "OD ROLLED PLATE", service, "SA36", "36", "0.375", "16", f_Circumference,
                             f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    Add_plate_item(1, service, "SA36", 44, 0.375, 44, 0);
                    Add_item("1", "BACKING STRIP", service, "SA36", "1.5", "0.125", "279.5",
                             NA, NA, NA, "1", f_UnitPrice,
                             NA, NA, NA, NA, NA, "0");
                    break;

                default:
                    break;
            }
        }


        protected void Add_nozzle_item(int quantity, string type, string service, string material, double size, string rating, double length = 0)
        {
            double welderLabor = 0;

            switch (type)
            {
                case "PIPE":
                    welderLabor = labor.get_pipe_nozzle_hours(size);
                    Add_pipe_item(quantity, service, material, size, rating, length, welderLabor);
                    break;

                case "THD CPLG":
                    welderLabor = labor.get_cplg_nozzle_hours(size);
                    Add_thd_cplg_item(quantity, service, material, size, rating, welderLabor);
                    break;

                default:
                    Add_item(quantity.ToString(), "UNKNOWN TYPE OF NOZZLE", service, material, size.ToString(), rating, length.ToString(),
                             NA, NA, NA, NA, NA,
                             NA, NA, NA, NA, NA, NA);
                    break;
            }
        }


        protected void Add_paint_items()
        {
            double SFperGallon1 = 58.4;  //[ft^2]
            double SFperGallon2 = 58.4;  //[ft^2]

            //    surface area = (cylinder area                              + 2*disk area                                  ) / inches^2
            double surfaceArea = (productInfo.VesselSize * Math.PI * productInfo.VesselOAL + 2 * Math.PI * Math.Pow(productInfo.VesselSize / 2,2)) / 144;  //[ft^2]

            int gallonsPaint1 = (int)Math.Ceiling(surfaceArea / SFperGallon1);  //[gal]
            int gallonsPaint2 = (int)Math.Ceiling(surfaceArea / SFperGallon2);  //[gal]


            Add_item(gallonsPaint1.ToString(), "PAINT", NA, "MACROPOXY 646", "RVS BLUE", NA, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, "1");
            Add_item(gallonsPaint2.ToString(), "PAINT", NA, "MACROPOXY 646", "HARDENER", NA, NA, 
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, "0");
        }





        protected void Add_radiography_item(string longSeam, string girthSeam)
        {
            int quantity = 0;
            int rtLength = 13;
            double rtShotCost = 50;

            switch (longSeam)
            {
                case "SPOT":
                    quantity += 1;
                    break;

                case "FULL":
                    quantity += (int)Math.Ceiling(productInfo.VesselShellLength / rtLength);
                    break;

                default:
                    break;
            }

            switch (girthSeam)
            {
                case "SPOT":
                    quantity += 2;
                    break;

                case "FULL":
                    quantity += (int)Math.Ceiling(productInfo.VesselSize * Math.PI / rtLength) * 2;
                    break;

                default:
                    break;
            }


            Add_item(quantity.ToString(), "RT SHOT", "LONG: " + longSeam, "GIRTH: " + girthSeam, NA, NA, NA,
                     NA, NA, NA, "1", rtShotCost.ToString(),
                     NA, NA, NA, NA, NA, "0");
        }
    }
}
