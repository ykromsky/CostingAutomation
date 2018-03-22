using System.Collections.Generic;

namespace StandardVesselEstimator
{
    public class Package : Product
    {
        public Package(ProductInfo info) : base (info) { }


        protected void Copy_list(List<ListItem> subList)
        {
            foreach (ListItem item in subList)
            {
                if (item.Quantity != "") ListItems.Add(item);
            }
        }


        protected void Add_section_block(string A_B)
        {
            //string materials_total_formula = "=CONCATENATE(\"MATERIALS TOTAL: \", TEXT(SUMPRODUCT(R[1]C[-2]:R[128]C[-2], R[1]C[12]:R[128]C[12])*R3C9,\"$0.00\"))";
            //string labor_total_formula = "=CONCATENATE(\"LABOR TOTAL: \", TEXT(SUMPRODUCT(R[1]C[19]:R[128]C[19], R[1]C[-3]:R[128]C[-3])*R5C9,\"$0.00\"))";
            //string cost_total_formula = "=CONCATENATE(\"COST TOTAL: \", TEXT(SUMPRODUCT(R[1]C[-5]:R[128]C[-5], R[1]C[9]:R[128]C[9])*R3C9 + SUMPRODUCT(R[1]C[-5]:R[128]C[-5], R[1]C[17]:R[128]C[17])*R5C9,\"$0.00\"))";

            Add_item(NA, "SECTION " + A_B, NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA, NA);
        }


        protected void Add_block_title(string title)
        {
            Add_item(title, NA, NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA,
                     NA, NA, NA, NA, NA, NA);
        }





        protected void Add_pump_item(int quantity, string rating)
        {
            double welderLabor = 0.5;
            Add_item(quantity.ToString(), "NH3 PUMP", NA, "TEIKOKU", NA, rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }

        protected void Add_stud_bolt_item(int quantity, double size)
        {
            double welderLabor = 0;
            Add_item(quantity.ToString(), "STUD BOLT", NA, "SA193-B7", size.ToString(), NA, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_hex_nut_item(int quantity, double size)
        {
            double welderLabor = 0;
            Add_item(quantity.ToString(), "HVY HEX NUT", NA, "SA194-2H", size.ToString(), NA, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_gasket_item(int quantity, double size, string rating)
        {
            double welderLabor = 0;
            Add_item(quantity.ToString(), "FULL FACE GASKET", NA, NA, size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_pressure_gauge_item(int quantity, string service, double size, string rating)
        {
            double welderLabor = 0.25;
            Add_item(quantity.ToString(), "PRESSURE GAUGE", service, "E.S.P.", size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_rfwn_flange_item(int quantity, double size, string rating)
        {
            double welderLabor = labor.get_rfwn_hours(size);
            Add_item(quantity.ToString(), "RFWN FLANGE", NA, "SA105", size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_rfso_flange_item(int quantity, double size, string rating)
        {
            double welderLabor = labor.get_rfso_hours(size);
            Add_item(quantity.ToString(), "RFSO FLANGE", NA, "SA105", size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }


        protected void Add_lap_flange_item(int quantity, double size, string rating)
        {
            double welderLabor = labor.get_rfwn_hours(size);
            Add_item(quantity.ToString(), "LAP JOINT STUB END", NA, "SA105", size.ToString(), rating, NA,
                     NA, NA, NA, "1", f_UnitPrice,
                     NA, NA, NA, NA, NA, welderLabor.ToString());
        }
    }
}

