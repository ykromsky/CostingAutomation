
namespace StandardVesselEstimator
{
    public class ListItem
    {
        public string Quantity { get; set; }
        public string Description { get; set; }
        public string Service { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Rating { get; set; }
        public string Length { get; set; }

        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string Units { get; set; }
        public string PartNumber { get; set; }
        public string PriceEach { get; set; }
        public string PriceTotal { get; set; }

        public string PlasmaLabor { get; set; }
        public string RollingLabor { get; set; }
        public string SubarcLabor { get; set; }
        public string CuttingLabor { get; set; }
        public string BlastLabor { get; set; }
        public string WelderLabor { get; set; }
        public string Hours { get; set; }


        public ListItem()
        {
            Quantity = "";
            Description = "";
            Service = "";
            Material = "";
            Size = "";
            Rating = "";
            Length = "";
            A = "";
            B = "";
            C = "";
            Units = "";
            PartNumber = "";
            PriceEach = "";
            PriceTotal = "";

            PlasmaLabor = "";
            RollingLabor = "";
            SubarcLabor = "";
            CuttingLabor = "";
            BlastLabor = "";
            WelderLabor = "";
            Hours = "";
        }
    }
}
