using System;
using System.Collections.Generic;

namespace StandardVesselEstimator
{
    public class Product
    {
        protected List<ListItem> ListItems;
        protected ListItem newItem;

        public ProductInfo productInfo;
        public PartsBook partsBook;
        protected Labor labor;

        protected static string f_ABC = "=RC[-4]";
        protected static string f_PipeUnits = "=(RC[-5] + 6)/12";
        protected static string f_PlateUnits = "=RC[-3]*RC[-2]*RC[-1]*0.284";

        protected static string partsBookPath = "'C:\\RVS PARTS BOOK\\[New Parts Book - Official.xlsx]PARTS BOOK'";
        //protected static string partsBookPath = "'\\\\rvsdc2\\Shares\\Shared\\Materials\\Parts Book\\[New Parts Book - Official.xlsx]PARTS BOOK'";

        protected static string f_UnitPrice = "=IF(ISNUMBER(VLOOKUP(RC[-1]," + partsBookPath + "!R2C3:R5000C9,7,FALSE))," +
                                                "VLOOKUP(RC[-1]," + partsBookPath + "!R2C3:R5000C9,7,FALSE)," +
                                                "VLOOKUP(RC[-1]," + partsBookPath + "!R2C3:R5000C9,6,FALSE))";
        protected static string f_PartPrice = "=IFNA(IF(RC[-3]=0,RC[-1],RC[-1]*RC[-3]), 0)";
        protected static string f_LaborSum = "=SUM(RC[-6]:RC[-1])";
        protected static string f_Circumference = "=RC[-4] * PI()";
        protected static string NA = "";


        public Product(ProductInfo info)
        {
            productInfo = info;
            partsBook = new PartsBook();
            labor = new Labor();
            ListItems = new List<ListItem>();
        }


        protected void Add_item(string quantity, string description, string service, string material, string size, string rating, string length,
                                string a, string b, string c, string units, string priceEach,
                                string plasmaLabor, string rollingLabor, string subarcLabor, string cuttingLabor, string blastLabor, string welderLabor)
        {
            string partNumber = "";
            string priceTotal = f_PartPrice;
            string hours = f_LaborSum;

            int temp;
            if(!int.TryParse(quantity, out temp))
            {
                priceTotal = "";
                hours = "";
            }

            switch (description)
            {
                case "PLATE":
                    partNumber = partsBook.QueryPartsBook(description, material, NA, rating, NA);
                    break;

                case "OD ROLLED PLATE":
                    partNumber = partsBook.QueryPartsBook("PLATE", material, NA, rating, NA);
                    break;

                case "B.W. 90 ELBOW":
                    partNumber = partsBook.QueryPartsBook(description, material, size, rating, length);
                    break;

                case "V BAFFLE":
                    double tempLength = 24;
                    if (double.Parse(length) > 24) tempLength = 113;
                    partNumber = partsBook.QueryPartsBook(description, material, size, rating, tempLength.ToString());
                    break;

                case "COIL (1W)":
                case "COIL (2W)":
                case "COIL (3W)":
                case "COIL (3W) [3\" HDR]":
                case "COIL (4W) [4\" HDR]":
                case "COIL (4W) [5\" HDR]":
                case "COIL (6W) [6\" HDR]":
                    partNumber = partsBook.QueryPartsBook(description, material, size, rating, length);
                    break;

                default:
                    partNumber = partsBook.QueryPartsBook(description, material, size, rating, NA);
                    break;
            }

            newItem = new ListItem()
            {
                Quantity = quantity,
                Description = description,
                Service = service,
                Material = material,
                Size = size,
                Rating = rating,
                Length = length,

                A = a,
                B = b,
                C = c,
                Units = units,
                PartNumber = partNumber,
                PriceEach = priceEach,
                PriceTotal = priceTotal,

                PlasmaLabor = plasmaLabor,
                RollingLabor = rollingLabor,
                SubarcLabor = subarcLabor,
                CuttingLabor = cuttingLabor,
                BlastLabor = blastLabor,
                WelderLabor = welderLabor,
                Hours = hours,
            };

            ListItems.Add(newItem);
        }


        protected void Add_pipe_item(int quantity, string service, string material, double size, string rating, double length, double welderLabor)
        {
            string cuttingLabor = labor.get_pipe_cutting_hours(size).ToString();

            Add_item(quantity.ToString(), "PIPE", service, material, size.ToString(), rating, length.ToString(),
                     NA, NA, NA, f_PipeUnits, f_UnitPrice,
                     NA, NA, NA, cuttingLabor, NA, welderLabor.ToString());
        }


        protected void Add_plate_item(int quantity, string service, string material, double size, double rating, double length, double welderLabor)
        {
            string plasmaLabor = labor.get_plasma_hours(size, rating, length).ToString();

            Add_item(quantity.ToString(), "PLATE", service, material, size.ToString(), rating.ToString(), length.ToString(),
                     f_ABC, f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                     plasmaLabor, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_flat_bar_item(int quantity, string service, string material, double size, double rating, double length)
        {
            double welderLabor = 0.25;

            Add_item(quantity.ToString(), "FLAT BAR", service, material, size.ToString(), rating.ToString(), length.ToString(),
                     f_ABC, f_ABC, f_ABC, f_PlateUnits, f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_angle_item(int quantity, string service, string material, double size, double rating, double length, double welderLabor)
        {
            Add_item(quantity.ToString(), "ANGLE", service, material, size.ToString(), rating.ToString(), length.ToString(),
                     NA, NA, NA, f_PipeUnits, f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_channel_item(int quantity, string service, double size, string rating, double length, double welderLabor)
        {
            Add_item(quantity.ToString(), "CHANNEL", service, "SA36", size.ToString(), rating, length.ToString(),
                     NA, NA, NA, f_PipeUnits, f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_beam_item(int quantity, string service, double size, string rating, double length, double welderLabor)
        {
            Add_item(quantity.ToString(), "W.F. BEAM", service, "A572 GR.50", size.ToString(), rating, length.ToString(),
                     NA, NA, NA, f_PipeUnits, f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_thd_cplg_item(int quantity, string service, string material, double size, string rating, double welderLabor)
        {
            Add_item(quantity.ToString(), "THD CPLG", service, material, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_thd_fitting_item(int quantity, string description, string service, string material, double size, string rating)
        {
            double welderLabor = labor.get_thd_fitting_hours();
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_sw_fitting_item(int quantity, string description, string service, string material, double size, string rating)
        {
            double welderLabor = labor.get_sw_fitting_hours();
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_sw_pipe_item(int quantity, string service, string material, double size, string rating, double length)
        {
            double welderLabor = labor.get_sw_fitting_hours();
            Add_pipe_item(quantity, service, material, size, rating, length, welderLabor);
        }


        protected void Add_bw_fitting_item(int quantity, string description, string service, string material, double size, string rating, string length)
        {
            double welderLabor = labor.get_butt_weld_hours(size);
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, length,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_bw_pipe_item(int quantity, string service, string material, double size, string rating, double length)
        {
            double welderLabor = labor.get_butt_weld_hours(size);
            Add_pipe_item(quantity, service, material, size, rating, length, welderLabor);
        }


        protected void Add_sw_valve_item(int quantity, string description, string service, string material, double size, string rating)
        {
            double welderLabor = labor.get_sw_fitting_hours();
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_thd_valve_item(int quantity, string description, string service, string material, double size, string rating)
        {
            double welderLabor = labor.get_thd_fitting_hours();
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_bw_valve_item(int quantity, string description, string service, string material, double size, string rating)
        {
            double welderLabor = labor.get_butt_weld_hours(size);
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_custom_item(int quantity, string description, string service, string material, double size, string rating, string length, double laborHours)
        {
            Add_item(quantity.ToString(), description, service, material, size.ToString(), rating, length,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, laborHours.ToString());
        }


        protected void Add_custom_item(int quantity, string description, string service, string material, string size, string rating, string length, double laborHours)
        {
            Add_item(quantity.ToString(), description, service, material, size, rating, length,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, laborHours.ToString());
        }


        protected void Add_purge_kit_items()
        {
            Add_item("1", "PURGE KIT", NA, NA, NA, NA, NA,
                     NA, NA, NA, "1", "33.56",
                     NA, NA, NA, NA, NA, "0");
        }


        protected void Add_labor_item(string description, double welderLabor)
        {
            Add_item("1", description, NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_last_item()
        {
            Add_item("1", "MISC.", NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA, "0");
        }


        protected void Add_blank_item()
        {
            Add_item(NA, NA, NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA, NA);
        }
    }
}


