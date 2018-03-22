using System.Linq;
using System.Collections.Generic;

namespace StandardVesselEstimator
{
    public class PartsBook
    {
        protected class Part
        {
            public string Type { get; set; }
            public string Material { get; set; }
            public string Size { get; set; }
            public string Rating { get; set; }
            public string Length { get; set; }
            public string PartNumber { get; set; }
        }

        protected static List<Part> StandardVesselPartsBook = new List<Part>
        {
            new Part {Type = "3-WAY MANIFOLD",      Material = "SHANK",             Size = "2 x 1.25",  Rating = "900MW-1 1/4", Length = "",        PartNumber = "21-8341-0"},
            new Part {Type = "3-WAY MANIFOLD",      Material = "SHANK",             Size = "1.25 x 1",  Rating = "850MW-1",     Length = "",        PartNumber = "21-8330-0"},

            new Part {Type = "ANGLE",               Material = "SA36",              Size = "2",         Rating = "0.25",        Length = "",        PartNumber = "04-0010-0"},
            new Part {Type = "ANGLE",               Material = "SA36",              Size = "3",         Rating = "0.25",        Length = "",        PartNumber = "04-0030-0"},
            new Part {Type = "ANGLE",               Material = "SA36",              Size = "4",         Rating = "0.375",       Length = "",        PartNumber = "04-0040-0"},
            new Part {Type = "ANGLE",               Material = "SA36",              Size = "6",         Rating = "0.375",       Length = "",        PartNumber = "04-0050-0"},
            new Part {Type = "ANGLE",               Material = "SA36",              Size = "6",         Rating = "0.5",         Length = "",        PartNumber = "04-0051-0"},
            new Part {Type = "ANGLE",               Material = "SA36",              Size = "8",         Rating = "0.75",        Length = "",        PartNumber = "04-0061-0"},

            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "3",         Rating = "3/32\"",      Length = "",        PartNumber = "11-2070-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "6",         Rating = "3/32\"",      Length = "",        PartNumber = "11-2100-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "8",         Rating = "3/32\"",      Length = "",        PartNumber = "11-2110-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "10",        Rating = "3/32\"",      Length = "",        PartNumber = "11-2120-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "12",        Rating = "3/32\"",      Length = "",        PartNumber = "11-2130-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "16",        Rating = "3/32\"",      Length = "",        PartNumber = "11-2150-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "20",        Rating = "3/32\"",      Length = "",        PartNumber = "11-2170-0"},
            new Part {Type = "BACKING RING",        Material = "SA414",             Size = "24",        Rating = "3/32\"",      Length = "",        PartNumber = "11-2180-0"},

            new Part {Type = "BACKING STRIP",       Material = "SA36",              Size = "1.5",       Rating = "0.125",       Length = "",        PartNumber = "04-5010-0"},

            new Part {Type = "B.W. 45 ELBOW",       Material = "SA234-WPB",         Size = "2.5",       Rating = "S/40",        Length = "",        PartNumber = "05-2130-0"},
            new Part {Type = "B.W. 45 ELBOW",       Material = "SA234-WPB",         Size = "3",         Rating = "S/40",        Length = "",        PartNumber = "05-2140-0"},
            new Part {Type = "B.W. 45 ELBOW",       Material = "SA234-WPB",         Size = "3",         Rating = "S/80",        Length = "",        PartNumber = "05-2144-0"},
            new Part {Type = "B.W. 45 ELBOW",       Material = "SA234-WPB",         Size = "4",         Rating = "S/40",        Length = "",        PartNumber = "05-2152-0"},
            new Part {Type = "B.W. 45 ELBOW",       Material = "SA234-WPB",         Size = "5",         Rating = "S/40",        Length = "",        PartNumber = "05-2161-0"},
            new Part {Type = "B.W. 45 ELBOW",       Material = "SA234-WPB",         Size = "6",         Rating = "S/40",        Length = "",        PartNumber = "05-2171-0"},

            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "2.5",       Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2131-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "3",         Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2142-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "3",         Rating = "S/80",        Length = "L.R.",    PartNumber = "05-2143-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "4",         Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2151-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "4",         Rating = "S/80",        Length = "L.R.",    PartNumber = "05-2153-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "5",         Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2161-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "6",         Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2171-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "8",         Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2180-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "10",        Rating = "S/40",        Length = "L.R.",    PartNumber = "05-2190-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "12",        Rating = "STD",         Length = "L.R.",    PartNumber = "05-2200-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "14",        Rating = "STD",         Length = "L.R.",    PartNumber = "05-2210-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "16",        Rating = "STD",         Length = "L.R.",    PartNumber = "05-2220-0"},
            new Part {Type = "B.W. 90 ELBOW",       Material = "SA234-WPB",         Size = "20",        Rating = "STD",         Length = "L.R.",    PartNumber = "05-2240-0"},

            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "2.5",       Rating = "148B5820",    Length = "",        PartNumber = "21-6120-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "3",         Rating = "148B5920",    Length = "",        PartNumber = "21-6140-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "4",         Rating = "148B6020",    Length = "",        PartNumber = "21-6160-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "5",         Rating = "148B6120",    Length = "",        PartNumber = "21-6180-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "6",         Rating = "148B6220",    Length = "",        PartNumber = "21-6200-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "8",         Rating = "148B6320",    Length = "",        PartNumber = "21-6220-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "10",        Rating = "148B3767",    Length = "",        PartNumber = "21-6240-0"},
            new Part {Type = "B.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "12",        Rating = "?",    Length = "",        PartNumber = "21-6250-0"},

            new Part {Type = "B.W. CONCENTRIC REDUCER", Material = "SA234-WPB",     Size = "2.5",       Rating = "S/40",        Length = "",        PartNumber = "05-4074-0"},
            new Part {Type = "B.W. CONCENTRIC REDUCER", Material = "SA234-WPB",     Size = "3",         Rating = "S/40",        Length = "",        PartNumber = "05-4082-0"},
            new Part {Type = "B.W. CONCENTRIC REDUCER", Material = "SA234-WPB",     Size = "5",         Rating = "S/40",        Length = "",        PartNumber = "05-4101-0"},
            
            new Part {Type = "B.W. ECCENTRIC REDUCER", Material = "SA234-WPB",      Size = "2",         Rating = "S/80",        Length = "",        PartNumber = "05-4640-0"},
            new Part {Type = "B.W. ECCENTRIC REDUCER", Material = "SA234-WPB",      Size = "4",         Rating = "S/40",        Length = "",        PartNumber = "05-4661-0"},
            new Part {Type = "B.W. ECCENTRIC REDUCER", Material = "SA234-WPB",      Size = "5",         Rating = "S/40",        Length = "",        PartNumber = "05-4671-0"},
            new Part {Type = "B.W. ECCENTRIC REDUCER", Material = "SA234-WPB",      Size = "6",         Rating = "S/40",        Length = "",        PartNumber = "05-4682-0"},
            new Part {Type = "B.W. ECCENTRIC REDUCER", Material = "SA234-WPB",      Size = "8",         Rating = "S/40",        Length = "",        PartNumber = "05-4691-0"},

            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "2.5",       Rating = "148B5830",    Length = "",        PartNumber = "21-6123-0"},
            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "2.5",       Rating = "148B5831",    Length = "",        PartNumber = "21-6124-0"},
            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "3",         Rating = "148B5930",    Length = "",        PartNumber = "21-6142-0"},
            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "4",         Rating = "148B6030",    Length = "",        PartNumber = "21-6162-0"},
            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "5",         Rating = "148B6130",    Length = "",        PartNumber = "21-6182-0"},
            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "6",         Rating = "148B6230",    Length = "",        PartNumber = "21-6202-0"},
            new Part {Type = "B.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "8",         Rating = "148B6330",    Length = "",        PartNumber = "21-6222-0"},

            new Part {Type = "B.W. PIPE CAP",       Material = "SA234-WPB",         Size = "3",         Rating = "S/40",        Length = "",        PartNumber = "05-0140-0"},
            new Part {Type = "B.W. PIPE CAP",       Material = "SA234-WPB",         Size = "4",         Rating = "S/40",        Length = "",        PartNumber = "05-0150-0"},
            new Part {Type = "B.W. PIPE CAP",       Material = "SA234-WPB",         Size = "6",         Rating = "S/40",        Length = "",        PartNumber = "05-0170-0"},
            new Part {Type = "B.W. PIPE CAP",       Material = "SA234-WPB",         Size = "6",         Rating = "S/80",        Length = "",        PartNumber = "05-0171-0"},
            new Part {Type = "B.W. PIPE CAP",       Material = "SA234-WPB",         Size = "8",         Rating = "S/40",        Length = "",        PartNumber = "05-0180-0"},

            new Part {Type = "B.W. REDUCING TEE",   Material = "SA234-WPB",         Size = "4",         Rating = "S/40",        Length = "",        PartNumber = "05-3621-0"},

            new Part {Type = "CHANNEL",             Material = "SA36",              Size = "6",         Rating = "10.5#",       Length = "",        PartNumber = "04-4020-0"},
            new Part {Type = "CHANNEL",             Material = "SA36",              Size = "8",         Rating = "13.75#",      Length = "",        PartNumber = "04-4050-0"},

            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "0.75",      Rating = "S/80",        Length = "56 FT",   PartNumber = "24-1010-0"},
            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "0.75",      Rating = "S/80",        Length = "75 FT",   PartNumber = "24-1011-0"},
            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "1",         Rating = "S/80",        Length = "71 FT",   PartNumber = "24-1030-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "1",         Rating = "S/80",        Length = "139 FT",  PartNumber = "24-1031-0"},
            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "1.25",      Rating = "S/80",        Length = "81 FT",   PartNumber = "24-1050-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "1.25",      Rating = "S/80",        Length = "173 FT",  PartNumber = "24-1051-0"},
            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "1.25",      Rating = "S/80",        Length = "128 FT",  PartNumber = "24-1052-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "220 FT",  PartNumber = "24-1070-0"},
            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "128 FT",  PartNumber = "24-1052-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "220 FT",  PartNumber = "24-1070-0"},
            new Part {Type = "COIL (1W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "160 FT",  PartNumber = "24-1071-0"},
            new Part {Type = "COIL (3W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "385 FT",  PartNumber = "24-1074-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "218 FT",  PartNumber = "24-1082-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "294 FT",  PartNumber = "24-1083-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "2",         Rating = "S/80",        Length = "227 FT",  PartNumber = "24-1100-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "2",         Rating = "S/80",        Length = "289 FT",  PartNumber = "24-1101-0"},
            new Part {Type = "COIL (3W)",           Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "395 FT",  PartNumber = "24-1102-0"},
            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "2",         Rating = "S/80",        Length = "356 FT",  PartNumber = "24-1103-0"},
            new Part {Type = "COIL (3W) [3\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/80",        Length = "516 FT",  PartNumber = "24-1104-0"},
            new Part {Type = "COIL (3W) [3\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "630 FT",  PartNumber = "24-1105-0"},
            new Part {Type = "COIL (3W) [3\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "700 FT",  PartNumber = "24-1106-0"},
            new Part {Type = "COIL (3W) [3\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "857 FT",  PartNumber = "24-1107-0"},
            new Part {Type = "COIL (3W) [3\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "918 FT",  PartNumber = "24-1108-0"},
            new Part {Type = "COIL (4W) [4\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "1128 FT", PartNumber = "24-1109-0"},

            new Part {Type = "COIL (2W)",           Material = "SA106B",            Size = "0.75",      Rating = "S/80",        Length = "116 FT",  PartNumber = "24-1011-1"},
            new Part {Type = "COIL (3W)",           Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "491 FT",  PartNumber = "24-1103-1"},
            new Part {Type = "COIL (4W) [4\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "1159 FT", PartNumber = "24-1114-0"},
            new Part {Type = "COIL (4W) [4\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "1424 FT", PartNumber = "24-1115-0"},
            new Part {Type = "COIL (4W) [5\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "1429 FT", PartNumber = "24-1116-0"},
            new Part {Type = "COIL (4W) [5\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "1758 FT", PartNumber = "24-1117-0"},
            new Part {Type = "COIL (6W) [6\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "2061 FT", PartNumber = "24-1118-0"},
            new Part {Type = "COIL (6W) [6\" HDR]", Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "2471 FT", PartNumber = "24-1119-0"},

            new Part {Type = "COIL W/ TERMINAL BOX", Material = "DANFOSS",          Size = "110 VAC",   Rating = "018F6816",    Length = "",        PartNumber = "21-7010-0"},

            new Part {Type = "DUAL RELIEF VALVE ASSY", Material = "HANSEN",         Size = "0.5 x 0.75", Rating = "H5600RD",    Length = "",        PartNumber = "21-1411-0"},
            new Part {Type = "DUAL RELIEF VALVE ASSY", Material = "HANSEN",         Size = "0.75 x 1",  Rating = "H5632RD",     Length = "",        PartNumber = "21-1523-0"},
            new Part {Type = "DUAL RELIEF VALVE ASSY", Material = "HANSEN",         Size = "1.25 x 1.5", Rating = "H5634RD",    Length = "",        PartNumber = "21-1542-0"},

            new Part {Type = "EZ-SRV CARTRIDGE RELIEF VALVE SET", Material = "HANSEN", Size = "0.5 X 0.75", Rating = "EZB-150#", Length = "",       PartNumber = "21-2010-0"},

            new Part {Type = "FLAT BAR",            Material = "SA36",              Size = "2",         Rating = "0.25",        Length = "",        PartNumber = "04-5030-0"},
            new Part {Type = "FLAT BAR",            Material = "SA36",              Size = "3",         Rating = "0.25",        Length = "",        PartNumber = "04-5030-0"},

            new Part {Type = "FPT QUICK CLOSING VALVE", Material = "DANFOSS",       Size = "0.75",      Rating = "148H3274",    Length = "",        PartNumber = "21-7020-0"},

            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "0.5",       Rating = "300#",        Length = "",        PartNumber = "11-0010-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "0.75",      Rating = "300#",        Length = "",        PartNumber = "11-0021-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "1.5",       Rating = "300#",        Length = "",        PartNumber = "11-0051-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "2",         Rating = "300#",        Length = "",        PartNumber = "11-0061-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "2.5",       Rating = "300#",        Length = "",        PartNumber = "11-0071-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "3",         Rating = "300#",        Length = "",        PartNumber = "11-0081-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "4",         Rating = "300#",        Length = "",        PartNumber = "11-0091-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "5",         Rating = "300#",        Length = "",        PartNumber = "11-0101-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "6",         Rating = "300#",        Length = "",        PartNumber = "11-0111-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "8",         Rating = "300#",        Length = "",        PartNumber = "11-0121-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "10",        Rating = "300#",        Length = "",        PartNumber = "11-0131-0"},
            new Part {Type = "FULL FACE GASKET",    Material = "",                  Size = "12",        Rating = "300#",        Length = "",        PartNumber = "11-0141-0"},

            new Part {Type = "H.L.L. FLOAT SWITCH", Material = "HANSEN",            Size = "",          Rating = "HLL",         Length = "",        PartNumber = "21-2100-0"},

            new Part {Type = "HVY HEX NUT",         Material = "SA194-2H",          Size = "0.5",       Rating = "",            Length = "",        PartNumber = "07-3010-0"},
            new Part {Type = "HVY HEX NUT",         Material = "SA194-2H",          Size = "0.625",     Rating = "",            Length = "",        PartNumber = "07-3020-0"},
            new Part {Type = "HVY HEX NUT",         Material = "SA194-2H",          Size = "0.75",      Rating = "",            Length = "",        PartNumber = "07-3030-0"},
            new Part {Type = "HVY HEX NUT",         Material = "SA194-2H",          Size = "0.875",     Rating = "",            Length = "",        PartNumber = "07-3040-0"},
            new Part {Type = "HVY HEX NUT",         Material = "SA194-2H",          Size = "1",         Rating = "",            Length = "",        PartNumber = "07-3250-0"},
            new Part {Type = "HVY HEX NUT",         Material = "SA194-2H",          Size = "1.125",     Rating = "",            Length = "",        PartNumber = "07-3260-0"},

            new Part {Type = "LAP JOINT STUB END",  Material = "SA105",             Size = "4",         Rating = "300#",        Length = "",        PartNumber = "06-6380-0"},

            new Part {Type = "LEVEL INDICATOR",     Material = "HANSEN",            Size = "",          Rating = "H1100-RN",    Length = "",        PartNumber = "21-2220-0"},

            new Part {Type = "LIQUID LEVEL SENSOR", Material = "DANFOSS",           Size = "AKS-4100U", Rating = "084H4521",    Length = "",        PartNumber = "23-5050-0"},
            new Part {Type = "LIQUID LEVEL SENSOR", Material = "DANFOSS",           Size = "AKS-4100U", Rating = "084H4533",    Length = "",        PartNumber = "23-5030-0"},

            new Part {Type = "LONG COUPLING",       Material = "SA105",             Size = "0.25",      Rating = "3000#",       Length = "",        PartNumber = "05-1110-0"},

            new Part {Type = "NAMEPLATE",           Material = "",                  Size = "",          Rating = "",            Length = "",        PartNumber = "11-3710-0"},

            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS60-30",    Length = "",        PartNumber = "20-0031-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS60-45",    Length = "",        PartNumber = "20-0040-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS120-30",   Length = "",        PartNumber = "20-0050-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS120-45",   Length = "",        PartNumber = "20-0060-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS190-30",   Length = "",        PartNumber = "20-0070-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS190-45",   Length = "",        PartNumber = "20-0080-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS270-30",   Length = "",        PartNumber = "20-0090-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS270-45",   Length = "",        PartNumber = "20-0100-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS375-45",   Length = "",        PartNumber = "20-0120-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS480-45",   Length = "",        PartNumber = "20-0140-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS160-70",   Length = "",        PartNumber = "20-0065-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS375-30",   Length = "",        PartNumber = "20-0110-0"},
            new Part {Type = "NH3 PUMP",            Material = "TEIKOKU",           Size = "",          Rating = "RVS480-30",   Length = "",        PartNumber = "20-0130-0"},

            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70 NORM",     Size = "10.75",     Rating = "0.375",       Length = "",        PartNumber = "02-0010-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "12.75",     Rating = "0.375",       Length = "",        PartNumber = "02-0020-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "16",        Rating = "0.375",       Length = "",        PartNumber = "02-0040-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "20",        Rating = "0.375",       Length = "",        PartNumber = "02-0060-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "24",        Rating = "0.375",       Length = "",        PartNumber = "02-0070-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "30",        Rating = "0.375",       Length = "",        PartNumber = "02-0090-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "36",        Rating = "0.375",       Length = "",        PartNumber = "02-0110-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "42",        Rating = "0.375",       Length = "",        PartNumber = "02-0120-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "48",        Rating = "0.375",       Length = "",        PartNumber = "02-0130-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "54",        Rating = "0.5",         Length = "",        PartNumber = "02-0141-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "60",        Rating = "0.5",         Length = "",        PartNumber = "02-0161-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "72",        Rating = "0.625",       Length = "",        PartNumber = "02-0182-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "84",        Rating = "0.625",       Length = "",        PartNumber = "02-0200-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "96",        Rating = "0.75",        Length = "",        PartNumber = "02-0221-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "108",       Rating = "0.75",        Length = "",        PartNumber = "02-0240-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70",          Size = "120",       Rating = "1",           Length = "",        PartNumber = "02-0251-0"},
            new Part {Type = "OD ELLIP HEAD",       Material = "SA516-70 NORM",     Size = "144",       Rating = "1.125",       Length = "",        PartNumber = "02-0260-0"},

            new Part {Type = "PAINT",               Material = "MACROPOXY 646",     Size = "HARDENER",  Rating = "",            Length = "",        PartNumber = "08-0010-0"},
            new Part {Type = "PAINT",               Material = "MACROPOXY 646",     Size = "RVS BLUE",  Rating = "",            Length = "",        PartNumber = "08-0011-0"},

            new Part {Type = "PIPE",                Material = "SA106B",            Size = "0.5",       Rating = "S/80",        Length = "",        PartNumber = "03-0030-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "0.75",      Rating = "S/80",        Length = "",        PartNumber = "03-0040-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "1",         Rating = "S/80",        Length = "",        PartNumber = "03-0050-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "1.25",      Rating = "S/80",        Length = "",        PartNumber = "03-0060-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "1.5",       Rating = "S/80",        Length = "",        PartNumber = "03-0070-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "1.5",       Rating = "S/160",       Length = "",        PartNumber = "03-0071-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "2",         Rating = "S/80",        Length = "",        PartNumber = "03-0080-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "2.5",       Rating = "S/40",        Length = "",        PartNumber = "03-0090-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "2.5",       Rating = "S/80",        Length = "",        PartNumber = "03-0091-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "3",         Rating = "S/40",        Length = "",        PartNumber = "03-0100-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "3",         Rating = "S/80",        Length = "",        PartNumber = "03-0101-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "4",         Rating = "S/40",        Length = "",        PartNumber = "03-0120-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "4",         Rating = "S/80",        Length = "",        PartNumber = "03-0121-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "5",         Rating = "S/40",        Length = "",        PartNumber = "03-0130-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "5",         Rating = "S/80",        Length = "",        PartNumber = "03-0131-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "6",         Rating = "S/40",        Length = "",        PartNumber = "03-0140-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "6",         Rating = "S/80",        Length = "",        PartNumber = "03-0141-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "8",         Rating = "S/40",        Length = "",        PartNumber = "03-0150-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "8",         Rating = "S/80",        Length = "",        PartNumber = "03-0151-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "10",        Rating = "S/40",        Length = "",        PartNumber = "03-0160-0"},
            new Part {Type = "PIPE",                Material = "SA106B",            Size = "10",        Rating = "S/80",        Length = "",        PartNumber = "03-0161-0"},
            new Part {Type = "PIPE",                Material = "SA53B-ERW",         Size = "12",        Rating = "STD",         Length = "",        PartNumber = "03-2070-0"},
            new Part {Type = "PIPE",                Material = "SA53B-ERW",         Size = "14",        Rating = "STD",         Length = "",        PartNumber = "03-2080-0"},
            new Part {Type = "PIPE",                Material = "SA53B-ERW",         Size = "16",        Rating = "STD",         Length = "",        PartNumber = "03-2090-0"},
            new Part {Type = "PIPE",                Material = "SA53B-ERW",         Size = "20",        Rating = "STD",         Length = "",        PartNumber = "03-2110-0"},
            new Part {Type = "PIPE",                Material = "SA53B-ERW",         Size = "24",        Rating = "STD",         Length = "",        PartNumber = "03-2120-0"},
            new Part {Type = "PIPE",                Material = "SA312-TP304",       Size = "2",         Rating = "S/40S",       Length = "",        PartNumber = "03-4070-0"},

            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "0.375",       Length = "",        PartNumber = "01-0020-0"},
            new Part {Type = "PLATE",               Material = "SA516-70",          Size = "",          Rating = "0.375",       Length = "",        PartNumber = "01-0020-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "0.5",         Length = "",        PartNumber = "01-0031-0"},
            new Part {Type = "PLATE",               Material = "SA516-70",          Size = "",          Rating = "0.5",         Length = "",        PartNumber = "01-0031-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "0.625",       Length = "",        PartNumber = "01-0040-0"},
            new Part {Type = "PLATE",               Material = "SA516-70",          Size = "",          Rating = "0.625",       Length = "",        PartNumber = "01-0040-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "0.75",        Length = "",        PartNumber = "01-0052-0"},
            new Part {Type = "PLATE",               Material = "SA516-70",          Size = "",          Rating = "0.75",        Length = "",        PartNumber = "01-0052-0"},
            new Part {Type = "PLATE",               Material = "SA516-70",          Size = "",          Rating = "0.875",       Length = "",        PartNumber = "01-0061-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "1",           Length = "",        PartNumber = "01-0070-0"},
            new Part {Type = "PLATE",               Material = "SA516-70",          Size = "",          Rating = "1",           Length = "",        PartNumber = "01-0070-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "1.25",        Length = "",        PartNumber = "01-0080-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "0.1875",      Length = "",        PartNumber = "01-2020-0"},
            new Part {Type = "PLATE",               Material = "SA36",              Size = "",          Rating = "0.25",        Length = "",        PartNumber = "01-2030-0"},
            new Part {Type = "PLATE",               Material = "SA240-304",         Size = "",          Rating = "0.375",       Length = "",        PartNumber = "01-3034-0"},

            new Part {Type = "PORT SOLENOID VALVE", Material = "DANFOSS",           Size = "1",         Rating = "148X0180",    Length = "",        PartNumber = "21-6720-0"},
            new Part {Type = "PORT SOLENOID VALVE", Material = "DANFOSS",           Size = "1.5",       Rating = "148X0226",    Length = "",        PartNumber = "21-6740-0"},

            new Part {Type = "PRESSURE GAUGE",      Material = "E.S.P.",            Size = "2.5",       Rating = "311D-254CK",  Length = "",        PartNumber = "27-0012-0"},
            new Part {Type = "PRESSURE GAUGE",      Material = "E.S.P.",            Size = "4",         Rating = "401LFW-404CH", Length = "",       PartNumber = "27-0020-0"},
            new Part {Type = "PRESSURE GAUGE",      Material = "E.S.P.",            Size = "2.5",       Rating = "401LFW-254CH", Length = "",       PartNumber = "27-0010-0"},

            new Part {Type = "PROBE COLUMN CAP",    Material = "HANSEN",            Size = "3.5",       Rating = "77-0129",     Length = "",        PartNumber = "21-2250-0"},

            new Part {Type = "Q.R. CARTRIDGE RELIEF VALVE SET", Material = "SHANK", Size = "0.5 X 0.75", Rating = "800QRW",     Length = "",        PartNumber = "21-8111-1"},

            new Part {Type = "RELIEF REGULATOR",    Material = "HANSEN",            Size = "0.5",       Rating = "HA2BK",       Length = "",        PartNumber = "21-0900-0"},

            new Part {Type = "RFSO FLANGE",         Material = "SA105",             Size = "0.5",       Rating = "300#",        Length = "",        PartNumber = "06-0011-0"},
            new Part {Type = "RFSO FLANGE",         Material = "SA105",             Size = "0.75",      Rating = "300#",        Length = "",        PartNumber = "06-0021-0"},
            new Part {Type = "RFSO FLANGE",         Material = "SA105",             Size = "2",         Rating = "300#",        Length = "",        PartNumber = "06-0061-0"},
            new Part {Type = "RFSO FLANGE",         Material = "SA105",             Size = "3",         Rating = "300#",        Length = "",        PartNumber = "06-0081-0"},
            new Part {Type = "RFSO FLANGE",         Material = "SA105",             Size = "4",         Rating = "300#",        Length = "",        PartNumber = "06-0091-0"},

            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "1.5",       Rating = "300#",        Length = "",        PartNumber = "06-1041-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "2",         Rating = "300#",        Length = "",        PartNumber = "06-1054-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "2.5",       Rating = "300#",        Length = "",        PartNumber = "06-1060-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "3",         Rating = "300#",        Length = "",        PartNumber = "06-1071-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "4",         Rating = "300#",        Length = "",        PartNumber = "06-1082-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "5",         Rating = "300#",        Length = "",        PartNumber = "06-1091-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "6",         Rating = "300#",        Length = "",        PartNumber = "06-1102-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "8",         Rating = "300#",        Length = "",        PartNumber = "06-1113-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "10",        Rating = "300#",        Length = "",        PartNumber = "06-1121-0"},
            new Part {Type = "RFWN FLANGE",         Material = "SA105",             Size = "12",        Rating = "300#",        Length = "",        PartNumber = "06-1132-0"},

            new Part {Type = "S.W. 45 ELBOW",       Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-2020-0"},
            new Part {Type = "S.W. 45 ELBOW",       Material = "SA105",             Size = "1",         Rating = "3000#",       Length = "",        PartNumber = "05-2030-0"},
            new Part {Type = "S.W. 45 ELBOW",       Material = "SA105",             Size = "1.25",      Rating = "3000#",       Length = "",        PartNumber = "05-2040-0"},
            new Part {Type = "S.W. 45 ELBOW",       Material = "SA105",             Size = "1.5",       Rating = "3000#",       Length = "",        PartNumber = "05-2043-0"},
            new Part {Type = "S.W. 45 ELBOW",       Material = "SA105",             Size = "2",         Rating = "3000#",       Length = "",        PartNumber = "05-2060-0"},

            new Part {Type = "S.W. 90 ELBOW",       Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-2021-0"},
            new Part {Type = "S.W. 90 ELBOW",       Material = "SA105",             Size = "1",         Rating = "3000#",       Length = "",        PartNumber = "05-2031-0"},
            new Part {Type = "S.W. 90 ELBOW",       Material = "SA105",             Size = "1.25",      Rating = "3000#",       Length = "",        PartNumber = "05-2041-0"},
            new Part {Type = "S.W. 90 ELBOW",       Material = "SA105",             Size = "1.5",       Rating = "3000#",       Length = "",        PartNumber = "05-2050-0"},
            new Part {Type = "S.W. 90 ELBOW",       Material = "SA105",             Size = "2",         Rating = "3000#",       Length = "",        PartNumber = "05-2061-0"},

            new Part {Type = "S.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "0.5",       Rating = "148B5263",    Length = "",        PartNumber = "21-6013-0"},
            new Part {Type = "S.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "0.75",      Rating = "148B5362",    Length = "",        PartNumber = "21-6034-0"},
            new Part {Type = "S.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "0.75",      Rating = "148B5363",    Length = "",        PartNumber = "21-6032-0"},
            new Part {Type = "S.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "1.5",       Rating = "148B5662",    Length = "",        PartNumber = "21-6092-0"},
            new Part {Type = "S.W. ANGLE VALVE",    Material = "DANFOSS",           Size = "2",         Rating = "148B5722",    Length = "",        PartNumber = "21-6110-0"},

            new Part {Type = "S.W. CPLG",           Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-1040-0"},
            new Part {Type = "S.W. CPLG",           Material = "SA105",             Size = "1",         Rating = "3000#",       Length = "",        PartNumber = "05-1051-0"},
            new Part {Type = "S.W. CPLG",           Material = "SA105",             Size = "1.25",      Rating = "3000#",       Length = "",        PartNumber = "05-1060-0"},
            new Part {Type = "S.W. CPLG",           Material = "SA105",             Size = "1.5",       Rating = "3000#",       Length = "",        PartNumber = "05-1062-0"},
            new Part {Type = "S.W. CPLG",           Material = "SA105",             Size = "2",         Rating = "3000#",       Length = "",        PartNumber = "05-1070-0"},

            new Part {Type = "S.W. DISK CHECK VALVE", Material = "HANSEN",          Size = "2",         Rating = "HCK4-8LR",    Length = "",        PartNumber = "21-1030-0"},
            new Part {Type = "S.W. DISK CHECK VALVE", Material = "HANSEN",          Size = "2.5",       Rating = "HCK4-9",      Length = "",        PartNumber = "21-1040-0"},
            new Part {Type = "S.W. DISK CHECK VALVE", Material = "HANSEN",          Size = "3",         Rating = "HCK4-0LR",    Length = "",        PartNumber = "21-1050-0"},
            new Part {Type = "S.W. DISK CHECK VALVE", Material = "HANSEN",          Size = "4",         Rating = "HCK4-1LR",    Length = "",        PartNumber = "21-1060-0"},
            new Part {Type = "S.W. DISK CHECK VALVE", Material = "R/S",             Size = "5",         Rating = "CK4A-20",     Length = "",        PartNumber = "21-3510-0"},

            new Part {Type = "S.W. EXP. ANGLE VALVE", Material = "DANFOSS",         Size = "1",         Rating = "148B5404",    Length = "",        PartNumber = "21-6520-0"},

            new Part {Type = "S.W. EXP. GLOBE VALVE", Material = "DANFOSS",         Size = "1",         Rating = "148B5414",    Length = "",        PartNumber = "21-6521-0"},
            new Part {Type = "S.W. EXP. GLOBE VALVE", Material = "DANFOSS",         Size = "1.5",       Rating = "148B5615",    Length = "",        PartNumber = "21-6542-0"},

            new Part {Type = "S.W. GLOBE STRAINER", Material = "DANFOSS",           Size = "1",         Rating = "148X0125",    Length = "",        PartNumber = "21-6820-0"},
            new Part {Type = "S.W. GLOBE STRAINER", Material = "DANFOSS",           Size = "1.5",       Rating = "148X0133",    Length = "",        PartNumber = "21-6840-0"},

            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "0.75",      Rating = "148B5372",    Length = "",        PartNumber = "21-6042-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "0.75",      Rating = "148B5373",    Length = "",        PartNumber = "21-6040-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1",         Rating = "148B5462",    Length = "",        PartNumber = "21-6052-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1",         Rating = "148B5472",    Length = "",        PartNumber = "21-6055-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1",         Rating = "148B5473",    Length = "",        PartNumber = "21-6056-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1.25",      Rating = "148B5572",    Length = "",        PartNumber = "21-6075-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1.25",      Rating = "148B5573",    Length = "",        PartNumber = "21-6076-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1.5",       Rating = "148B5672",    Length = "",        PartNumber = "21-6095-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "1.5",       Rating = "148B5673",    Length = "",        PartNumber = "21-6096-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "2",         Rating = "148B5732",    Length = "",        PartNumber = "21-6112-0"},
            new Part {Type = "S.W. GLOBE VALVE",    Material = "DANFOSS",           Size = "2",         Rating = "148B5733",    Length = "",        PartNumber = "21-6113-0"},

            new Part {Type = "S.W. FLANGED UNION",  Material = "HENRY",             Size = "1.5",       Rating = "S2SW-2x1 1/2", Length = "",       PartNumber = "11-3450-0"},

            new Part {Type = "S.W. REDUCING CPLG",  Material = "SA105",             Size = "1.5",       Rating = "3000#",       Length = "",        PartNumber = "05-1463-0"},

            new Part {Type = "S.W. REDUCING INSERT", Material = "SA105",            Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-7022-0"},
            new Part {Type = "S.W. REDUCING INSERT", Material = "SA105",            Size = "1.5",       Rating = "3000#",       Length = "",        PartNumber = "05-7051-0"},

            new Part {Type = "S.W. TEE",            Material = "SA105",             Size = "1.5",       Rating = "3000#",       Length = "",        PartNumber = "05-3070-0"},
            new Part {Type = "S.W. TEE",            Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-3040-0"},

            new Part {Type = "SINGLE RELIEF VALVE ASSY", Material = "HANSEN",       Size = "1.25 x 1.5", Rating = "H5604",      Length = "",        PartNumber = "21-1440-0"},
            new Part {Type = "SINGLE RELIEF VALVE ASSY", Material = "HANSEN",       Size = "1 x 1.25",  Rating = "H5613",       Length = "",        PartNumber = "21-1430-0"},

            new Part {Type = "STD NAMEPLATE BRKT",  Material = "SA36",              Size = "2",         Rating = "3/16\"",      Length = "",        PartNumber = "11-3010-0"},
            new Part {Type = "STD NAMEPLATE BRKT",  Material = "SA36",              Size = "6",         Rating = "3/16\"",      Length = "",        PartNumber = "11-3020-0"},

            new Part {Type = "STD SADDLE",          Material = "SA36",              Size = "8",         Rating = "0.375",       Length = "",        PartNumber = "11-3130-0"},
            new Part {Type = "STD SADDLE",          Material = "SA36",              Size = "10",        Rating = "0.375",       Length = "",        PartNumber = "11-3150-0"},

            new Part {Type = "STUD BOLT",           Material = "SA193-B7",          Size = "0.625",     Rating = "",            Length = "",        PartNumber = "07-0021-0"},
            new Part {Type = "STUD BOLT",           Material = "SA193-B7",          Size = "0.75",      Rating = "",            Length = "",        PartNumber = "07-0030-0"},
            new Part {Type = "STUD BOLT",           Material = "SA193-B7",          Size = "0.5",       Rating = "",            Length = "",        PartNumber = "07-0010-0"},
            new Part {Type = "STUD BOLT",           Material = "SA193-B7",          Size = "0.875",     Rating = "",            Length = "",        PartNumber = "07-0542-1"},
            new Part {Type = "STUD BOLT",           Material = "SA193-B7",          Size = "1",         Rating = "",            Length = "",        PartNumber = "07-0552-0"},
            new Part {Type = "STUD BOLT",           Material = "SA193-B7",          Size = "1.125",     Rating = "",            Length = "",        PartNumber = "07-0561-0"},

            new Part {Type = "THD 90 ELBOW",        Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-2022-0"},
            new Part {Type = "THD 90 ELBOW",        Material = "SA105",             Size = "1.25",      Rating = "3000#",       Length = "",        PartNumber = "05-2042-0"},

            new Part {Type = "THD CPLG",            Material = "SA105",             Size = "0.5",       Rating = "3000#",       Length = "",        PartNumber = "05-1031-0"},
            new Part {Type = "THD CPLG",            Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-1041-0"},
            new Part {Type = "THD CPLG",            Material = "SA105",             Size = "1",         Rating = "3000#",       Length = "",        PartNumber = "05-1053-0"},
            new Part {Type = "THD CPLG",            Material = "SA105",             Size = "1.25",      Rating = "3000#",       Length = "",        PartNumber = "05-1061-0"},
            new Part {Type = "THD CPLG",            Material = "SA105",             Size = "2",         Rating = "3000#",       Length = "",        PartNumber = "05-1071-0"},

            new Part {Type = "THD GLOBE VALVE",     Material = "DANFOSS",           Size = "0.5",       Rating = "148B275",     Length = "",        PartNumber = "21-6030-0"},

            new Part {Type = "THD NIPPLE",          Material = "SA106B",            Size = "0.5",       Rating = "S/80",        Length = "",        PartNumber = "05-5032-0"},
            new Part {Type = "THD NIPPLE",          Material = "SA106B",            Size = "0.75",      Rating = "S/80",        Length = "",        PartNumber = "05-5040-1"},
            new Part {Type = "THD NIPPLE",          Material = "SA106B",            Size = "1",         Rating = "S/80",        Length = "",        PartNumber = "05-5050-0"},
            new Part {Type = "THD NIPPLE",          Material = "SA106B",            Size = "1.25",      Rating = "S/80",        Length = "",        PartNumber = "05-5061-0"},

            new Part {Type = "THD PIPE CAP",        Material = "SA105",             Size = "0.75",      Rating = "3000#",       Length = "",        PartNumber = "05-0021-0"},
            new Part {Type = "THD PIPE CAP",        Material = "SA105",             Size = "0.5",       Rating = "3000#",       Length = "",        PartNumber = "05-0011-0"},

            new Part {Type = "THD STREET ELBOW",    Material = "SA105",             Size = "0.5",       Rating = "3000#",       Length = "",        PartNumber = "05-2014-0"},

            new Part {Type = "VAC COIL",            Material = "DANFOSS",           Size = "110",       Rating = "018F6816",    Length = "",        PartNumber = "21-7010-0"},

            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "6",         Rating = "0.3125",      Length = "113",     PartNumber = "11-2610-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "8",         Rating = "0.3125",      Length = "24",      PartNumber = "11-2620-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "8",         Rating = "0.3125",      Length = "113",     PartNumber = "11-2621-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "10",        Rating = "0.3125",      Length = "24",      PartNumber = "11-2630-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "10",        Rating = "0.3125",      Length = "113",     PartNumber = "11-2631-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "12",        Rating = "0.3125",      Length = "24",      PartNumber = "11-2640-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "12",        Rating = "0.3125",      Length = "113",     PartNumber = "11-2641-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "14",        Rating = "0.3125",      Length = "24",      PartNumber = "11-2650-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "14",        Rating = "0.3125",      Length = "113",     PartNumber = "11-2651-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "18",        Rating = "0.3125",      Length = "24",      PartNumber = "11-2660-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "18",        Rating = "0.3125",      Length = "113",     PartNumber = "11-2661-0"},
            new Part {Type = "V BAFFLE",            Material = "SA36",              Size = "24",        Rating = "0.3125",      Length = "113",     PartNumber = "11-2670-0"},

            new Part {Type = "U-BEND PIPE",         Material = "SA106B",            Size = "1.25",      Rating = "S/80",        Length = "",        PartNumber = "11-3350-0"},
            new Part {Type = "U-BEND PIPE",         Material = "SA106B",            Size = "2",         Rating = "S/40",        Length = "",        PartNumber = "11-3370-0"},

            new Part {Type = "W.F. BEAM",           Material = "A572 GR.50",        Size = "8",         Rating = "31#",         Length = "",        PartNumber = "04-3021-0"},
            new Part {Type = "W.F. BEAM",           Material = "A572 GR.50",        Size = "8",         Rating = "48#",         Length = "",        PartNumber = "04-3022-0"},
            new Part {Type = "W.F. BEAM",           Material = "A572 GR.50",        Size = "10",        Rating = "68#",         Length = "",        PartNumber = "04-4060-0"},
            new Part {Type = "W.F. BEAM",           Material = "A572 GR.50",        Size = "6",         Rating = "15#",         Length = "",        PartNumber = "04-3010-0"},

            new Part {Type = "PURGE KIT",           Material = "",                  Size = "",          Rating = "",            Length = "",        PartNumber = "66-6666-6"}
        };


        public string QueryPartsBook(string type, string material, string size, string rating, string length)
        {
            string partNumber;

            IEnumerable<Part> partQuery1 = from part in StandardVesselPartsBook
                               where part.Type == type
                               select part;

            IEnumerable<Part> partQuery2 = from part in partQuery1
                                           where part.Material == material
                                           select part;

            IEnumerable<Part> partQuery3 = from part in partQuery2
                                           where part.Size == size
                                           select part;

            IEnumerable<Part> partQuery4 = from part in partQuery3
                                           where part.Rating == rating
                                           select part;

            IEnumerable<Part> partQuery5 = from part in partQuery4
                                           where part.Length == length
                                           select part;

            if (partQuery5.FirstOrDefault() != null)
                partNumber = partQuery5.FirstOrDefault().PartNumber;
            else
                partNumber = "";

            return partNumber;
        }
    }
}
