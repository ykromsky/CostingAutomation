
using System.Collections.Generic;


namespace StandardVesselEstimator
{
    class LiqFeed : Product
    {
        public LiqFeed(ProductInfo info) : base(info) { }
        private double input;
        private double output;
        private double expansion;

        public List<ListItem> lfList()
        {
            input = productInfo.lfInputSize;
            output = productInfo.lfOutputSize;
            expansion = productInfo.lfExpansionSize;

            Add_blank_item();

            Add_control_items();
            Add_fitting_items();
            Add_reducer_items();
            Add_pipe_items();
            Add_misc_items();

            Add_blank_item();
            Add_last_item();

            return ListItems;
        }


        protected void Add_control_items()
        {
            Add_iso_valve(input); //1
            Add_strainer_item(input); //2
            Add_solenoid_item(input); //3
            Add_expansion_item(expansion); //4
            Add_iso_valve(output); //5
            Add_hand_expansion_item(input); //6
        }


        protected void Add_iso_valve(double size)
        {
            switch (size)
            {
                case 0.75:
                    if (productInfo.lfIsHW) { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, H.W.", "DANFOSS", 0.75, "148B5372"); }
                    else { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, S.C.", "DANFOSS", 0.75, "148B5373"); }
                    break;

                case 1:
                    if (productInfo.lfIsHW) { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, H.W.", "DANFOSS", 1, "148B5472"); }
                    else { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, S.C.", "DANFOSS", 1, "148B5473"); }
                    break;

                case 1.25:
                    if (productInfo.lfIsHW) { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, H.W.", "DANFOSS", 1.25, "148B5572"); }
                    else { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, S.C.", "DANFOSS", 1.25, "148B5573"); }
                    break;

                case 1.5:
                    if (productInfo.lfIsHW) { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, H.W.", "DANFOSS", 1.5, "148B5672"); }
                    else { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "EXT. NECK, S.C.", "DANFOSS", 1.5, "148B5673"); }
                    break;

                case 2:
                    if (productInfo.lfIsHW) { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "H.W.", "DANFOSS", 2, "148B5732"); }
                    else { Add_sw_valve_item(1, "S.W. GLOBE VALVE", "S.C.", "DANFOSS", 2, "148B5733"); }
                    break;

                case 2.5:
                    if (productInfo.lfIsHW) { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "H.W.", "DANFOSS", 2.5, "148B5830"); }
                    else { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "S.C.", "DANFOSS", 2.5, "148B5831"); }
                    break;

                case 3:
                    if (productInfo.lfIsHW) { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "H.W.", "DANFOSS", 3, "148B5930"); }
                    else { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "S.C.", "DANFOSS", 3, "148B5931"); }
                    break;

                case 4:
                    if (productInfo.lfIsHW) { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "H.W.", "DANFOSS", 4, "148B6030"); }
                    else { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "S.C.", "DANFOSS", 4, "148B6031"); }
                    break;

                case 5:
                    if (productInfo.lfIsHW) { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "H.W.", "DANFOSS", 5, "148B6130"); }
                    else { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "S.C.", "DANFOSS", 5, "148B6131"); }
                    break;

                case 6:
                    if (productInfo.lfIsHW) { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "H.W.", "DANFOSS", 6, "148B6230"); }
                    else { Add_bw_valve_item(1, "B.W. GLOBE VALVE", "S.C.", "DANFOSS", 6, "148B6231"); }
                    break;

                default:
                    break;
            }
        }


        protected void Add_strainer_item(double size)
        {
            switch (size)
            {
                case 0.75:
                    Add_sw_valve_item(1, "S.W. STRAINER", "GLOBE BODY, FIA-20", "DANFOSS", 0.75, "148X0122");
                    break;

                case 1:
                    Add_sw_valve_item(1, "S.W. STRAINER", "GLOBE BODY, FIA-25", "DANFOSS", 1, "148X0125");
                    break;

                case 1.25:
                    Add_sw_valve_item(1, "S.W. STRAINER", "GLOBE BODY, FIA-32", "DANFOSS", 1.25, "148X0129");
                    break;

                case 1.5:
                    Add_sw_valve_item(1, "S.W. STRAINER", "GLOBE BODY, FIA-40", "DANFOSS", 1.5, "148X0133");
                    break;

                case 2:
                    Add_sw_valve_item(1, "S.W. STRAINER", "GLOBE BODY, FIA-50", "DANFOSS", 2, "148X0138");
                    break;

                case 2.5:
                    Add_bw_valve_item(1, "B.W. STRAINER", "GLOBE BODY, FIA-65", "DANFOSS", 2.5, "148X0258");
                    break;

                case 3:
                    Add_bw_valve_item(1, "B.W. STRAINER", "GLOBE BODY, FIA-80", "DANFOSS", 3, "148X0272");
                    break;

                default:
                    break;
            }
        }


        protected void Add_solenoid_item(double size)
        {
            switch (size)
            {
                case 0.75:
                    Add_sw_valve_item(1, "S.W. SOLENOID VALVE", "ICS25-20", "DANFOSS", 0.75, "148X0195");
                    break;

                case 1:
                    Add_sw_valve_item(1, "S.W. SOLENOID VALVE", "ICS25-25", "DANFOSS", 1, "148X0180");
                    break;

                case 1.25:
                    Add_sw_valve_item(1, "S.W. SOLENOID VALVE", "ICS32", "DANFOSS", 1.25, "148X0214");
                    break;

                case 1.5:
                    Add_sw_valve_item(1, "S.W. SOLENOID VALVE", "ICS40", "DANFOSS", 1.5, "148X0226");
                    break;

                case 2:
                    Add_sw_valve_item(1, "S.W. SOLENOID VALVE", "ICS50", "DANFOSS", 2, "148X0235");
                    break;

                case 2.5:
                    Add_bw_valve_item(1, "S.W. SOLENOID VALVE", "ICS65", "DANFOSS", 2.5, "148X0242");
                    break;

                case 3:
                    Add_bw_valve_item(1, "S.W. SOLENOID VALVE", "ICS80", "DANFOSS", 3, "148X0248");
                    break;

                default:
                    break;
            }
        }


        protected void Add_expansion_item(double size)
        {
            switch (size)
            {
                case 0.75:
                    if (productInfo.lfIsHX) { Add_sw_valve_item(1, "S.W. HX GLOBE VALVE", "S.C., REG-SB-20", "DANFOSS", 0.75, "148B5315"); }
                    else { Add_bw_valve_item(1, "B.W. MOTORIZED REG. VALVE", "ICM20-B", "DANFOSS", 0.75, "148X0143"); }
                    break;

                case 1:
                    if (productInfo.lfIsHX) { Add_sw_valve_item(1, "S.W. HX GLOBE VALVE", "S.C., REG-SA-25", "DANFOSS", 1, "148B5414"); }
                    else { Add_bw_valve_item(1, "B.W. MOTORIZED REG. VALVE", "ICM25-A", "DANFOSS", 1, "148X0152"); }
                    break;

                case 1.25:
                    if (productInfo.lfIsHX) { Add_sw_valve_item(1, "S.W. HX GLOBE VALVE", "S.C., REG-SA-32", "DANFOSS", 1.25, "148B5514"); }
                    else { Add_bw_valve_item(1, "B.W. MOTORIZED REG. VALVE", "ICM32-A", "DANFOSS", 1.25, "148X0155"); }
                    break;

                case 1.5:
                    if (productInfo.lfIsHX) { Add_sw_valve_item(1, "S.W. HX GLOBE VALVE", "S.C., REG-SA-40", "DANFOSS", 1.5, "148B5614"); }
                    else { Add_bw_valve_item(1, "B.W. MOTORIZED REG. VALVE", "ICM40-A", "DANFOSS", 1.5, "148X0759"); }
                    break;

                case 2:
                    if (productInfo.lfIsHX) { Add_sw_valve_item(1, "S.W. HX GLOBE VALVE", "S.C., REG-SB-50", "DANFOSS", 2, "148B5725"); }
                    else { Add_bw_valve_item(1, "B.W. MOTORIZED REG. VALVE", "ICM50-A", "DANFOSS", 2, "148X0166"); }
                    break;

                case 2.5:
                    if (productInfo.lfIsHX) { Add_bw_valve_item(1, "B.W. HX GLOBE VALVE", "S.C., REG-SB-65", "DANFOSS", 2.5, "148B5809"); }
                    else { Add_bw_valve_item(1, "B.W. MOTORIZED REG. VALVE", "ICM65-A", "DANFOSS", 2.5, "148X0169"); }
                    break;

                default:
                    break;
            }
        }


        protected void Add_hand_expansion_item(double size)
        {
            switch (size)
            {
                case 0.75:
                    Add_sw_valve_item(1, "S.W. HX ANGLE VALVE", "S.C., REG-SB-20", "DANFOSS", 0.75, "148B5305");
                    break;

                case 1:
                    Add_sw_valve_item(1, "S.W. HX ANGLE VALVE", "S.C., REG-SA-25", "DANFOSS", 1, "148B5404");
                    break;

                case 1.25:
                    Add_sw_valve_item(1, "S.W. HX ANGLE VALVE", "S.C., REG-SA-32", "DANFOSS", 1.25, "148B5504");
                    break;

                case 1.5:
                    Add_sw_valve_item(1, "S.W. HX ANGLE VALVE", "S.C., REG-SA-40", "DANFOSS", 1.5, "148B5604");
                    break;

                case 2:
                    Add_sw_valve_item(1, "S.W. HX ANGLE VALVE", "S.C., REG-SB-50", "DANFOSS", 2, "148B5727");
                    break;

                case 2.5:
                    Add_bw_valve_item(1, "B.W. HX ANGLE VALVE", "S.C., REG-SB-65", "DANFOSS", 2.5, "148B5806");
                    break;

                case 3:
                    Add_bw_valve_item(1, "B.W. HX ANGLE VALVE", "BAR HANDLE, REG-SB-65", "HANSEN", 3, "VW301H");
                    break;

                default:
                    break;
            }
        }


        protected void Add_fitting_items()
        {
            switch (output) //7
            {
                case 1:
                case 1.5:
                case 2:
                    Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", output, "3000#");
                    break;

                case 2.5:
                case 3:
                case 4:
                case 5:
                case 6:
                    Add_bw_fitting_item(1, "B.W. TEE", "", "SA234-WPB", output, "S/40", "");
                    break;

                default:
                    break;
            }

            switch (input) //8, 9
            {
                case 1:
                case 1.5:
                case 2:
                    Add_sw_fitting_item(1, "S.W. TEE", "", "SA105", input, "3000#");
                    Add_sw_fitting_item(1, "S.W. 90 ELBOW", "", "SA105", input, "3000#");
                    break;

                case 2.5:
                case 3:
                case 4:
                case 5:
                case 6:
                    Add_bw_fitting_item(1, "B.W. TEE", "", "SA234-WPB", input, "S/40", "");
                    Add_bw_fitting_item(1, "B.W. 90 ELBOW", "", "SA234-WPB", input, "S/40", "L.R.");
                    break;

                default:
                    break;
            }
        }


        protected void Add_reducer_items()
        {
            if (output > input) //10
            {
                if(output <= 2)
                {
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "", "SA105", output, "#300");
                }
                else
                {
                    Add_bw_fitting_item(1, "B.W. CONC. REDUCER", "", "SA234-WPB", output, "S/40", input.ToString());
                }

            }

            if (output > expansion) //11
            {
                if (output <= 2)
                {
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "", "SA105", output, "#300");
                }
                else
                {
                    Add_bw_fitting_item(1, "B.W. CONC. REDUCER", "", "SA234-WPB", output, "S/40", expansion.ToString());
                }
            }

            if (input > expansion) //12
            {
                if (input <= 2)
                {
                    Add_sw_fitting_item(1, "S.W. REDUCING INSERT", "", "SA105", input, "#300");
                }
                else
                {
                    Add_bw_fitting_item(1, "B.W. CONC. REDUCER", "", "SA234-WPB", input, "S/40", expansion.ToString());
                }
            }
        }


        protected void Add_pipe_items()
        {
            Add_pipe(1, output, 7.5); //13
            Add_pipe(1, output, 4); //14
            Add_pipe(1, input, 7.5); //15
            Add_pipe(4, input, 4); //16
            Add_pipe(1, input, 21); //17
            Add_pipe(1, input, 18); //18
            Add_pipe(1, input, 81); //19
        }


        protected void Add_misc_items()
        {
            Add_custom_item(1, "COIL W/ TERMINAL BOX", "", "DANFOSS", "110 VAC", "018F6816", "", 0);
            Add_purge_kit_items();
        }


        protected void Add_pipe(int quantity, double size, double length)
        {
            switch (size)
            {
                case 0.75:
                case 1:
                case 1.25:
                case 1.5:
                case 2:
                    Add_sw_pipe_item(quantity, "", "SA106B", size, "S/80", length);
                    break;

                case 2.5:
                case 3:
                case 4:
                case 5:
                case 6:
                    Add_bw_pipe_item(quantity, "", "SA106B", size, "S/40", length);
                    break;

                default:
                    break;
            }
        }
    }
}
