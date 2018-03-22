using System;
using System.Collections.Generic;

namespace StandardVesselEstimator
{
    public class Labor
    {
        private Dictionary<double, double> GirthHours150Single;
        private Dictionary<double, double> GirthHours250Single;
        private Dictionary<double, double> GirthHours300Single;
        private Dictionary<double, double> GirthHours150Double;
        private Dictionary<double, double> GirthHours250Double;
        private Dictionary<double, double> GirthHours300Double;
        private Dictionary<double, double> LongHours150Single;
        private Dictionary<double, double> LongHours250Single;
        private Dictionary<double, double> LongHours300Single;
        private Dictionary<double, double> LongHours150Double;
        private Dictionary<double, double> LongHours250Double;
        private Dictionary<double, double> LongHours300Double;
        private Dictionary<double, double> SmallHeadHours;
        private Dictionary<double, double> PipeNozzleHours;
        private Dictionary<double, double> CplgNozzleHours;
        private Dictionary<double, double> RepadHours;
        private Dictionary<double, double> WeldpadHours;
        private Dictionary<double, double> EndPlateHours;
        private Dictionary<double, double> VortexBreakerHours;
        private Dictionary<double, double> DistributionBoxHours;
        private Dictionary<double, double> ThermosyphonPlateHours;
        private Dictionary<double, double> ThermosyphonPipeHours;
        private Dictionary<double, double> SaddleWebHours;
        private Dictionary<double, double> SaddleBaseHours;
        private Dictionary<double, double> SaddleRibHours;
        private Dictionary<double, double> SaddleBandHours;
        private Dictionary<double, double> LegHours;
        private Dictionary<double, double> CoilHours;
        private Dictionary<double, double> AngleClipHours;
        private Dictionary<double, double> ButtWeldHours;
        private Dictionary<double, double> RFWNWeldHours;
        private Dictionary<double, double> RFSOWeldHours;

        private Dictionary<double, double> PlasmaFeedRates;
        private Dictionary<double, double> RollingHours;
        private Dictionary<double, double> PipeCuttingHours;
        private Dictionary<double, double> BlastShellHours;
        private Dictionary<double, double> BlastHeadHours;

        private double PipeShellHours;
        private double SWfittingHours;
        private double THDfittingHours;


        public Labor()
        {
            Girth_seam_hours_tables();
            Long_seam_hours_tables();
            Pipe_nozzle_hours_table();
            Cplg_nozzle_hours_table();
            Repad_hours_table();
            Weldpad_hours_table();
            End_plate_hours_table();
            Vortex_breaker_hours_table();
            Distribution_box_hours_table();
            Thermosyphon_plate_hours_table();
            Thermosyphon_pipe_hours_table();
            Saddle_web_table();
            Saddle_base_table();
            Saddle_rib_table();
            Saddle_band_table();
            Leg_hours_table();
            Coil_hours_table();
            Angle_clip_hours_table();
            Butt_weld_hours_table();
            RFWN_weld_hours_table();
            RFSO_weld_hours_table();

            Plasma_feed_rates_table();
            Rolling_hours_table();
            Pipe_cutting_hours_table();
            Blast_shell_hours_table();
            Blast_head_hours_table();

            PipeShellHours = 1;
            SWfittingHours = 0.25;
            THDfittingHours = 0.25;
        }


        private void Girth_seam_hours_tables()
        {
            SmallHeadHours = new Dictionary<double, double>();
            SmallHeadHours.Add(6, 1.5);
            SmallHeadHours.Add(8, 1.5);
            SmallHeadHours.Add(10, 2);
            SmallHeadHours.Add(12, 2);
            SmallHeadHours.Add(14, 2.5);
            SmallHeadHours.Add(16, 3);
            SmallHeadHours.Add(18, 3);
            SmallHeadHours.Add(20, 3);
            SmallHeadHours.Add(24, 4);

            GirthHours150Single = new Dictionary<double, double>();
            GirthHours150Single.Add(30, 3.07);
            GirthHours150Single.Add(36, 3.93);
            GirthHours150Single.Add(42, 4.82);
            GirthHours150Single.Add(48, 5.39);
            GirthHours150Single.Add(54, 5.92);
            GirthHours150Single.Add(60, 7.60);
            GirthHours150Single.Add(66, 9.71);
            GirthHours150Single.Add(72, 11.88);
            GirthHours150Single.Add(78, 14.08);
            GirthHours150Single.Add(84, 16.32);
            GirthHours150Single.Add(96, 18.37);
            GirthHours150Single.Add(108, 26.37);
            GirthHours150Single.Add(120, 30.23);
            GirthHours150Single.Add(144, 44.19);

            GirthHours250Single = new Dictionary<double, double>();
            GirthHours250Single.Add(30, 3.07);
            GirthHours250Single.Add(36, 3.93);
            GirthHours250Single.Add(42, 6.20);
            GirthHours250Single.Add(48, 7.17);
            GirthHours250Single.Add(54, 8.14);
            GirthHours250Single.Add(60, 9.12);
            GirthHours250Single.Add(66, 11.66);
            GirthHours250Single.Add(72, 14.25);
            GirthHours250Single.Add(78, 17.70);
            GirthHours250Single.Add(84, 20.40);
            GirthHours250Single.Add(96, 22.97);
            GirthHours250Single.Add(108, 33.18);
            GirthHours250Single.Add(120, 38.00);
            GirthHours250Single.Add(144, 55.24);

            GirthHours300Single = new Dictionary<double, double>();
            GirthHours300Single.Add(30, 3.07);
            GirthHours300Single.Add(36, 3.93);
            GirthHours300Single.Add(42, 6.20);
            GirthHours300Single.Add(48, 7.89);
            GirthHours300Single.Add(54, 9.25);
            GirthHours300Single.Add(60, 10.64);
            GirthHours300Single.Add(66, 12.43);
            GirthHours300Single.Add(72, 14.25);
            GirthHours300Single.Add(78, 19.31);
            GirthHours300Single.Add(84, 24.48);
            GirthHours300Single.Add(96, 27.14);
            GirthHours300Single.Add(108, 36.16);
            GirthHours300Single.Add(120, 47.50);
            GirthHours300Single.Add(144, 66.28);

            GirthHours150Double = new Dictionary<double, double>();
            GirthHours150Double.Add(30, 2.71);
            GirthHours150Double.Add(36, 3.53);
            GirthHours150Double.Add(42, 4.37);
            GirthHours150Double.Add(48, 5.02);
            GirthHours150Double.Add(54, 5.45);
            GirthHours150Double.Add(60, 7.04);
            GirthHours150Double.Add(66, 9.16);
            GirthHours150Double.Add(72, 11.11);
            GirthHours150Double.Add(78, 13.35);
            GirthHours150Double.Add(84, 15.38);
            GirthHours150Double.Add(96, 17.42);
            GirthHours150Double.Add(108, 25.13);
            GirthHours150Double.Add(120, 28.92);
            GirthHours150Double.Add(144, 42.54);

            GirthHours250Double = new Dictionary<double, double>();
            GirthHours250Double.Add(30, 2.71);
            GirthHours250Double.Add(36, 3.53);
            GirthHours250Double.Add(42, 5.62);
            GirthHours250Double.Add(48, 6.55);
            GirthHours250Double.Add(54, 7.27);
            GirthHours250Double.Add(60, 8.45);
            GirthHours250Double.Add(66, 10.85);
            GirthHours250Double.Add(72, 13.33);
            GirthHours250Double.Add(78, 16.62);
            GirthHours250Double.Add(84, 19.22);
            GirthHours250Double.Add(96, 21.90);
            GirthHours250Double.Add(108, 31.61);
            GirthHours250Double.Add(120, 36.35);
            GirthHours250Double.Add(144, 53.32);

            GirthHours300Double = new Dictionary<double, double>();
            GirthHours300Double.Add(30, 2.71);
            GirthHours300Double.Add(36, 3.53);
            GirthHours300Double.Add(42, 5.62);
            GirthHours300Double.Add(48, 6.99);
            GirthHours300Double.Add(54, 8.63);
            GirthHours300Double.Add(60, 9.85);
            GirthHours300Double.Add(66, 12.54);
            GirthHours300Double.Add(72, 15.55);
            GirthHours300Double.Add(78, 19.89);
            GirthHours300Double.Add(84, 23.07);
            GirthHours300Double.Add(96, 26.39);
            GirthHours300Double.Add(108, 38.36);
            GirthHours300Double.Add(120, 44.06);
            GirthHours300Double.Add(144, 64.09);
        }


        private void Long_seam_hours_tables()
        {
            LongHours150Single = new Dictionary<double, double>();
            LongHours150Single.Add(30, 3.87);
            LongHours150Single.Add(36, 4.14);
            LongHours150Single.Add(42, 4.35);
            LongHours150Single.Add(48, 4.24);
            LongHours150Single.Add(54, 4.15);
            LongHours150Single.Add(60, 4.80);
            LongHours150Single.Add(66, 5.57);
            LongHours150Single.Add(72, 6.25);
            LongHours150Single.Add(78, 6.84);
            LongHours150Single.Add(84, 7.36);
            LongHours150Single.Add(96, 7.25);
            LongHours150Single.Add(108, 9.25);
            LongHours150Single.Add(120, 9.54);
            LongHours150Single.Add(144, 11.62);

            LongHours250Single = new Dictionary<double, double>();
            LongHours250Single.Add(30, 3.87);
            LongHours250Single.Add(36, 4.14);
            LongHours250Single.Add(42, 5.59);
            LongHours250Single.Add(48, 5.66);
            LongHours250Single.Add(54, 5.71);
            LongHours250Single.Add(60, 5.76);
            LongHours250Single.Add(66, 6.69);
            LongHours250Single.Add(72, 7.50);
            LongHours250Single.Add(78, 8.60);
            LongHours250Single.Add(84, 9.20);
            LongHours250Single.Add(96, 9.06);
            LongHours250Single.Add(108, 11.64);
            LongHours250Single.Add(120, 12.00);
            LongHours250Single.Add(144, 14.53);

            LongHours300Single = new Dictionary<double, double>();
            LongHours300Single.Add(30, 3.87);
            LongHours300Single.Add(36, 4.14);
            LongHours300Single.Add(42, 5.59);
            LongHours300Single.Add(48, 6.22);
            LongHours300Single.Add(54, 6.49);
            LongHours300Single.Add(60, 6.72);
            LongHours300Single.Add(66, 7.14);
            LongHours300Single.Add(72, 7.50);
            LongHours300Single.Add(78, 9.38);
            LongHours300Single.Add(84, 10.71);
            LongHours300Single.Add(96, 11.04);
            LongHours300Single.Add(108, 12.68);
            LongHours300Single.Add(120, 14.99);
            LongHours300Single.Add(144, 17.44);

            LongHours150Double = new Dictionary<double, double>();
            LongHours150Double.Add(30, 3.43);
            LongHours150Double.Add(36, 3.71);
            LongHours150Double.Add(42, 3.94);
            LongHours150Double.Add(48, 3.96);
            LongHours150Double.Add(54, 3.82);
            LongHours150Double.Add(60, 4.44);
            LongHours150Double.Add(66, 5.26);
            LongHours150Double.Add(72, 5.84);
            LongHours150Double.Add(78, 6.48);
            LongHours150Double.Add(84, 6.93);
            LongHours150Double.Add(96, 6.87);
            LongHours150Double.Add(108, 8.81);
            LongHours150Double.Add(120, 9.13);
            LongHours150Double.Add(144, 11.19);

            LongHours250Double = new Dictionary<double, double>();
            LongHours250Double.Add(30, 3.43);
            LongHours250Double.Add(36, 3.71);
            LongHours250Double.Add(42, 5.07);
            LongHours250Double.Add(48, 5.17);
            LongHours250Double.Add(54, 5.10);
            LongHours250Double.Add(60, 5.33);
            LongHours250Double.Add(66, 6.23);
            LongHours250Double.Add(72, 7.01);
            LongHours250Double.Add(78, 8.07);
            LongHours250Double.Add(84, 8.67);
            LongHours250Double.Add(96, 8.64);
            LongHours250Double.Add(108, 11.09);
            LongHours250Double.Add(120, 11.47);
            LongHours250Double.Add(144, 14.02);

            LongHours300Double = new Dictionary<double, double>();
            LongHours300Double.Add(30, 3.43);
            LongHours300Double.Add(36, 3.71);
            LongHours300Double.Add(42, 5.07);
            LongHours300Double.Add(48, 5.52);
            LongHours300Double.Add(54, 6.05);
            LongHours300Double.Add(60, 6.22);
            LongHours300Double.Add(66, 7.20);
            LongHours300Double.Add(72, 8.18);
            LongHours300Double.Add(78, 9.66);
            LongHours300Double.Add(84, 10.40);
            LongHours300Double.Add(96, 10.41);
            LongHours300Double.Add(108, 13.46);
            LongHours300Double.Add(120, 13.91);
            LongHours300Double.Add(144, 16.86);
        }


        private void Pipe_nozzle_hours_table()
        {
            PipeNozzleHours = new Dictionary<double, double>();

            PipeNozzleHours.Add(0.5, 0.5);
            PipeNozzleHours.Add(0.75, 0.5);
            PipeNozzleHours.Add(1, 0.5);
            PipeNozzleHours.Add(1.25, 0.75);
            PipeNozzleHours.Add(1.5, 0.75);
            PipeNozzleHours.Add(2, 0.75);
            PipeNozzleHours.Add(2.5, 1);
            PipeNozzleHours.Add(3, 1);
            PipeNozzleHours.Add(4, 1.25);
            PipeNozzleHours.Add(5, 1.5);
            PipeNozzleHours.Add(6, 1.75);
            PipeNozzleHours.Add(8, 2.25);
            PipeNozzleHours.Add(10, 2.75);
            PipeNozzleHours.Add(12, 3.25);
            PipeNozzleHours.Add(14, 3.75);
            PipeNozzleHours.Add(16, 4.25);
            PipeNozzleHours.Add(18, 4.75);
            PipeNozzleHours.Add(20, 5.25);
            PipeNozzleHours.Add(24, 6.25);
            PipeNozzleHours.Add(30, 7.75);
            PipeNozzleHours.Add(36, 9.25);
        }


        private void Cplg_nozzle_hours_table()
        {
            CplgNozzleHours = new Dictionary<double, double>();

            CplgNozzleHours.Add(0.5, 0.5);
            CplgNozzleHours.Add(0.75, 0.5);
            CplgNozzleHours.Add(1, 0.5);
            CplgNozzleHours.Add(1.25, 0.5);
            CplgNozzleHours.Add(1.5, 0.5);
            CplgNozzleHours.Add(2, 0.5);
        }


        private void Repad_hours_table()
        {
            RepadHours = new Dictionary<double, double>();

            RepadHours.Add(2, 0.5);
            RepadHours.Add(2.5, 0.5);
            RepadHours.Add(3, 0.75);
            RepadHours.Add(4, 0.75);
            RepadHours.Add(5, 1);
            RepadHours.Add(6, 1.25);
            RepadHours.Add(8, 1.5);
            RepadHours.Add(10, 1.75);
            RepadHours.Add(12, 2.25);
            RepadHours.Add(14, 2.5);
            RepadHours.Add(16, 2.75);
            RepadHours.Add(18, 3);
            RepadHours.Add(20, 3.25);
            RepadHours.Add(24, 3.5);
            RepadHours.Add(30, 4.75);
            RepadHours.Add(36, 5.75);
        }


        private void Weldpad_hours_table()
        {
            WeldpadHours = new Dictionary<double, double>();

            WeldpadHours.Add(4, 0.5);
            WeldpadHours.Add(6, 0.75);
            WeldpadHours.Add(8, 1);
            WeldpadHours.Add(10, 1.25);
            WeldpadHours.Add(12, 1.5);
            WeldpadHours.Add(14, 1.75);
        }


        private void End_plate_hours_table()
        {
            EndPlateHours = new Dictionary<double, double>();

            EndPlateHours.Add(2.75, 0.5);
            EndPlateHours.Add(4, 0.5);
            EndPlateHours.Add(3.75, 0.5);
            EndPlateHours.Add(4.75, 0.5);
            EndPlateHours.Add(5.75, 0.75);
            EndPlateHours.Add(7.75, 0.75);
            EndPlateHours.Add(9.75, 1);
        }


        private void Vortex_breaker_hours_table()
        {
            VortexBreakerHours = new Dictionary<double, double>();

            VortexBreakerHours.Add(2, 0.5);
            VortexBreakerHours.Add(2.5, 0.5);
            VortexBreakerHours.Add(3, 0.5);
            VortexBreakerHours.Add(4, 0.5);
            VortexBreakerHours.Add(5, 0.75);
            VortexBreakerHours.Add(6, 0.75);
            VortexBreakerHours.Add(8, 1);
            VortexBreakerHours.Add(10, 1);
        }


        private void Distribution_box_hours_table()
        {
            DistributionBoxHours = new Dictionary<double, double>();

            DistributionBoxHours.Add(3, 3);
            DistributionBoxHours.Add(4, 3.5);
            DistributionBoxHours.Add(5, 4);
            DistributionBoxHours.Add(6, 4.5);
            DistributionBoxHours.Add(8, 5);
            DistributionBoxHours.Add(10, 6);
            DistributionBoxHours.Add(12, 7);
            DistributionBoxHours.Add(14, 7);
            DistributionBoxHours.Add(16, 8);
        }


        private void Thermosyphon_plate_hours_table()
        {
            ThermosyphonPlateHours = new Dictionary<double, double>();

            ThermosyphonPlateHours.Add(36, 2);
            ThermosyphonPlateHours.Add(48, 3);
            ThermosyphonPlateHours.Add(54, 3.5);
            ThermosyphonPlateHours.Add(60, 4);
            ThermosyphonPlateHours.Add(72, 5);
            ThermosyphonPlateHours.Add(84, 6);
            ThermosyphonPlateHours.Add(96, 6.5);
            ThermosyphonPlateHours.Add(108, 7);
            ThermosyphonPlateHours.Add(120, 7.5);
            ThermosyphonPlateHours.Add(144, 8);
        }


        private void Thermosyphon_pipe_hours_table()
        {
            ThermosyphonPipeHours = new Dictionary<double, double>();

            ThermosyphonPipeHours.Add(8, 0.5);
            ThermosyphonPipeHours.Add(10, 0.5);
            ThermosyphonPipeHours.Add(12, 0.75);
            ThermosyphonPipeHours.Add(14, 0.75);
            ThermosyphonPipeHours.Add(16, 1);
        }


        private void Saddle_web_table()
        {
            SaddleWebHours = new Dictionary<double, double>();

            SaddleWebHours.Add(6, 0.5);
            SaddleWebHours.Add(8, 0.5);
            SaddleWebHours.Add(10, 0.5);
            SaddleWebHours.Add(12, 0.5);
            SaddleWebHours.Add(14, 0.5);
            SaddleWebHours.Add(16, 0.5);
            SaddleWebHours.Add(18, 0.5);
            SaddleWebHours.Add(20, 0.5);
            SaddleWebHours.Add(24, 0.5);
            SaddleWebHours.Add(30, 0.5);
            SaddleWebHours.Add(36, 0.5);
            SaddleWebHours.Add(42, 0.5);
            SaddleWebHours.Add(48, 0.5);
            SaddleWebHours.Add(54, 0.75);
            SaddleWebHours.Add(60, 0.75);
            SaddleWebHours.Add(66, 0.75);
            SaddleWebHours.Add(72, 0.75);
            SaddleWebHours.Add(78, 1);
            SaddleWebHours.Add(84, 1);
            SaddleWebHours.Add(96, 1);
            SaddleWebHours.Add(108, 1);
            SaddleWebHours.Add(120, 1);
            SaddleWebHours.Add(144, 1);
        }


        private void Saddle_base_table()
        {
            SaddleBaseHours = new Dictionary<double, double>();

            SaddleBaseHours.Add(6, 0);
            SaddleBaseHours.Add(8, 0);
            SaddleBaseHours.Add(10, 0);
            SaddleBaseHours.Add(12, 0.25);
            SaddleBaseHours.Add(14, 0.25);
            SaddleBaseHours.Add(16, 0.25);
            SaddleBaseHours.Add(18, 0.25);
            SaddleBaseHours.Add(20, 0.25);
            SaddleBaseHours.Add(24, 0.25);
            SaddleBaseHours.Add(30, 0.5);
            SaddleBaseHours.Add(36, 0.5);
            SaddleBaseHours.Add(42, 0.5);
            SaddleBaseHours.Add(48, 0.5);
            SaddleBaseHours.Add(54, 0.5);
            SaddleBaseHours.Add(60, 0.5);
            SaddleBaseHours.Add(66, 0.75);
            SaddleBaseHours.Add(72, 0.75);
            SaddleBaseHours.Add(78, 0.75);
            SaddleBaseHours.Add(84, 1);
            SaddleBaseHours.Add(96, 1);
            SaddleBaseHours.Add(108, 1);
            SaddleBaseHours.Add(120, 1);
            SaddleBaseHours.Add(144, 1);
        }


        private void Saddle_rib_table()
        {
            SaddleRibHours = new Dictionary<double, double>();

            SaddleRibHours.Add(6, 0);
            SaddleRibHours.Add(8, 0);
            SaddleRibHours.Add(10, 0);
            SaddleRibHours.Add(12, 0.25);
            SaddleRibHours.Add(14, 0.25);
            SaddleRibHours.Add(16, 0.25);
            SaddleRibHours.Add(18, 0.25);
            SaddleRibHours.Add(20, 0.25);
            SaddleRibHours.Add(24, 0.25);
            SaddleRibHours.Add(30, 0.25);
            SaddleRibHours.Add(36, 0.25);
            SaddleRibHours.Add(42, 0.25);
            SaddleRibHours.Add(48, 0.25);
            SaddleRibHours.Add(54, 0.25);
            SaddleRibHours.Add(60, 0.25);
            SaddleRibHours.Add(66, 0.25);
            SaddleRibHours.Add(72, 0.25);
            SaddleRibHours.Add(78, 0.25);
            SaddleRibHours.Add(84, 0.25);
            SaddleRibHours.Add(96, 0.25);
            SaddleRibHours.Add(108, 0.25);
            SaddleRibHours.Add(120, 0.25);
            SaddleRibHours.Add(144, 0.25);
        }


        private void Saddle_band_table()
        {
            SaddleBandHours = new Dictionary<double, double>();

            SaddleBandHours.Add(6, 0);
            SaddleBandHours.Add(8, 0);
            SaddleBandHours.Add(10, 0);
            SaddleBandHours.Add(12, 0);
            SaddleBandHours.Add(14, 0);
            SaddleBandHours.Add(16, 0);
            SaddleBandHours.Add(18, 0.75);
            SaddleBandHours.Add(20, 0.75);
            SaddleBandHours.Add(24, 0.75);
            SaddleBandHours.Add(30, 1);
            SaddleBandHours.Add(36, 1);
            SaddleBandHours.Add(42, 1.5);
            SaddleBandHours.Add(48, 1.5);
            SaddleBandHours.Add(54, 1.75);
            SaddleBandHours.Add(60, 1.75);
            SaddleBandHours.Add(66, 2);
            SaddleBandHours.Add(72, 2);
            SaddleBandHours.Add(78, 2.25);
            SaddleBandHours.Add(84, 2.5);
            SaddleBandHours.Add(96, 2.75);
            SaddleBandHours.Add(108, 3);
            SaddleBandHours.Add(120, 3);
            SaddleBandHours.Add(144, 3);
        }


        private void Leg_hours_table()
        {
            LegHours = new Dictionary<double, double>();

            LegHours.Add(6, 2);
            LegHours.Add(8, 2);
            LegHours.Add(10, 2);
            LegHours.Add(12, 2);
            LegHours.Add(14, 2);
            LegHours.Add(16, 2);
            LegHours.Add(18, 2);
            LegHours.Add(20, 2);
            LegHours.Add(24, 2);
            LegHours.Add(30, 2);
            LegHours.Add(36, 3);
            LegHours.Add(42, 3);
            LegHours.Add(48, 4);
            LegHours.Add(54, 4);
            LegHours.Add(60, 6);
            LegHours.Add(66, 6);
            LegHours.Add(72, 6);
            LegHours.Add(78, 6);
            LegHours.Add(84, 7);
            LegHours.Add(96, 7.5);
            LegHours.Add(108, 8.5);
            LegHours.Add(120, 9);
            LegHours.Add(144, 10);
        }


        private void Coil_hours_table()
        {
            CoilHours = new Dictionary<double, double>();

            CoilHours.Add(12, 2);
            CoilHours.Add(14, 2);
            CoilHours.Add(16, 2);
            CoilHours.Add(18, 2);
            CoilHours.Add(20, 2);
            CoilHours.Add(24, 2);
            CoilHours.Add(30, 2.5);
            CoilHours.Add(36, 3);
            CoilHours.Add(42, 3.5);
            CoilHours.Add(48, 4);
            CoilHours.Add(54, 4.5);
            CoilHours.Add(60, 5);
            CoilHours.Add(66, 5.5);
            CoilHours.Add(72, 6);
            CoilHours.Add(78, 6.5);
            CoilHours.Add(84, 7);
            CoilHours.Add(96, 8);
            CoilHours.Add(108, 9);
            CoilHours.Add(120, 10);
            CoilHours.Add(144, 12);
        }


        private void Angle_clip_hours_table()
        {
            AngleClipHours = new Dictionary<double, double>();

            AngleClipHours.Add(8, 1);
            AngleClipHours.Add(10, 1);
            AngleClipHours.Add(12, 1);
            AngleClipHours.Add(14, 1);
            AngleClipHours.Add(16, 1);
            AngleClipHours.Add(18, 1);
            AngleClipHours.Add(20, 1);
            AngleClipHours.Add(24, 1);
            AngleClipHours.Add(30, 1.5);
            AngleClipHours.Add(36, 1.5);
            AngleClipHours.Add(42, 1.5);
            AngleClipHours.Add(48, 2);
            AngleClipHours.Add(54, 2);
            AngleClipHours.Add(60, 3);
            AngleClipHours.Add(66, 3);
            AngleClipHours.Add(72, 3);
            AngleClipHours.Add(78, 4);
            AngleClipHours.Add(84, 4);
            AngleClipHours.Add(96, 4);
            AngleClipHours.Add(108, 5);
            AngleClipHours.Add(120, 5);
            AngleClipHours.Add(144, 5);
        }


        private void Butt_weld_hours_table()
        {
            ButtWeldHours = new Dictionary<double, double>();

            ButtWeldHours.Add(0.5,  0.25);
            ButtWeldHours.Add(0.75, 0.25);
            ButtWeldHours.Add(1,    0.25);
            ButtWeldHours.Add(1.25, 0.25);
            ButtWeldHours.Add(1.5,  0.25);
            ButtWeldHours.Add(2,    0.5);
            ButtWeldHours.Add(2.5,  0.5);
            ButtWeldHours.Add(3,    0.5);
            ButtWeldHours.Add(4,    0.75);
            ButtWeldHours.Add(5,    0.75);
            ButtWeldHours.Add(6,    1);
            ButtWeldHours.Add(8,    1);
            ButtWeldHours.Add(10,   1.25);
            ButtWeldHours.Add(12,   1.25);
            ButtWeldHours.Add(14,   1.5);
            ButtWeldHours.Add(16,   1.75);
            ButtWeldHours.Add(18,   2);
            ButtWeldHours.Add(20,   2.5);
            ButtWeldHours.Add(24,   3);
        }


        private void RFWN_weld_hours_table()
        {
            RFWNWeldHours = new Dictionary<double, double>();

            RFWNWeldHours.Add(0.5, 0.25);
            RFWNWeldHours.Add(0.75, 0.25);
            RFWNWeldHours.Add(1, 0.25);
            RFWNWeldHours.Add(1.25, 0.25);
            RFWNWeldHours.Add(1.5, 0.25);
            RFWNWeldHours.Add(2, 0.5);
            RFWNWeldHours.Add(2.5, 0.5);
            RFWNWeldHours.Add(3, 0.5);
            RFWNWeldHours.Add(4, 0.75);
            RFWNWeldHours.Add(5, 0.75);
            RFWNWeldHours.Add(6, 1);
            RFWNWeldHours.Add(8, 1);
            RFWNWeldHours.Add(10, 1.25);
            RFWNWeldHours.Add(12, 1.25);
            RFWNWeldHours.Add(14, 1.5);
            RFWNWeldHours.Add(16, 1.75);
            RFWNWeldHours.Add(18, 2);
            RFWNWeldHours.Add(20, 2.5);
            RFWNWeldHours.Add(24, 3);
        }


        private void RFSO_weld_hours_table()
        {
            RFSOWeldHours = new Dictionary<double, double>();

            RFSOWeldHours.Add(0.5, 0.25);
            RFSOWeldHours.Add(0.75, 0.25);
            RFSOWeldHours.Add(1, 0.25);
            RFSOWeldHours.Add(1.25, 0.25);
            RFSOWeldHours.Add(1.5, 0.25);
            RFSOWeldHours.Add(2, 0.5);
            RFSOWeldHours.Add(2.5, 0.5);
            RFSOWeldHours.Add(3, 0.5);
            RFSOWeldHours.Add(4, 0.75);
            RFSOWeldHours.Add(5, 0.75);
            RFSOWeldHours.Add(6, 1);
            RFSOWeldHours.Add(8, 1);
            RFSOWeldHours.Add(10, 1.25);
            RFSOWeldHours.Add(12, 1.25);
            RFSOWeldHours.Add(14, 1.5);
            RFSOWeldHours.Add(16, 1.75);
            RFSOWeldHours.Add(18, 2);
            RFSOWeldHours.Add(20, 2.5);
            RFSOWeldHours.Add(24, 3);
        }


        private void Pipe_cutting_hours_table()
        {
            PipeCuttingHours = new Dictionary<double, double>();

            PipeCuttingHours.Add(0.5, 0.05);
            PipeCuttingHours.Add(0.75, 0.05);
            PipeCuttingHours.Add(1, 0.05);
            PipeCuttingHours.Add(1.25, 0.05);
            PipeCuttingHours.Add(1.5, 0.05);
            PipeCuttingHours.Add(2, 0.083);
            PipeCuttingHours.Add(2.5, 0.083);
            PipeCuttingHours.Add(3, 0.083);
            PipeCuttingHours.Add(4, 0.117);
            PipeCuttingHours.Add(5, 0.117);
            PipeCuttingHours.Add(6, 0.117);
            PipeCuttingHours.Add(8, 0.15);
            PipeCuttingHours.Add(10, 0.15);
            PipeCuttingHours.Add(12, 0.15);
            PipeCuttingHours.Add(14, 0.167);
            PipeCuttingHours.Add(16, 0.167);
            PipeCuttingHours.Add(18, 0.167);
            PipeCuttingHours.Add(20, 0.25);
            PipeCuttingHours.Add(24, 0.25);
        }


        private void Plasma_feed_rates_table()
        {
            PlasmaFeedRates = new Dictionary<double, double>();

            PlasmaFeedRates.Add(0.1875, 77);
            PlasmaFeedRates.Add(0.25, 77);
            PlasmaFeedRates.Add(0.375, 77);
            PlasmaFeedRates.Add(0.5, 77);
            PlasmaFeedRates.Add(0.625, 77);
            PlasmaFeedRates.Add(0.75, 77);
            PlasmaFeedRates.Add(0.875, 57);
            PlasmaFeedRates.Add(1, 57);
            PlasmaFeedRates.Add(1.125, 50);
            PlasmaFeedRates.Add(1.25, 43);
            //PlasmaFeedRates.Add(1.5, 1);
            //PlasmaFeedRates.Add(1.75, 1);
            //PlasmaFeedRates.Add(2, 1);
            //PlasmaFeedRates.Add(2.25, 1);
            //PlasmaFeedRates.Add(2.5, 1);
            //PlasmaFeedRates.Add(2.75, 1);
            //PlasmaFeedRates.Add(3, 1);
        }


        private void Rolling_hours_table()
        {
            RollingHours = new Dictionary<double, double>();

            RollingHours.Add(30, 3);
            RollingHours.Add(36, 3.5);
            RollingHours.Add(42, 3.75);
            RollingHours.Add(48, 4);
            RollingHours.Add(54, 4.25);
            RollingHours.Add(60, 4.5);
            RollingHours.Add(66, 5);
            RollingHours.Add(72, 6);
            RollingHours.Add(78, 6.25);
            RollingHours.Add(84, 6.5);
            RollingHours.Add(96, 7);
            RollingHours.Add(108, 7.5);
        }


        private void Blast_shell_hours_table()
        {
            BlastShellHours = new Dictionary<double, double>();

            BlastShellHours.Add(8.625, .1);
            BlastShellHours.Add(10.75, .1);
            BlastShellHours.Add(12, .1);
            BlastShellHours.Add(14, .5);
            BlastShellHours.Add(16, .5);
            BlastShellHours.Add(18, .5);
            BlastShellHours.Add(20, .5);
            BlastShellHours.Add(24, .5);
            BlastShellHours.Add(30, .75);
            BlastShellHours.Add(36, .75);
            BlastShellHours.Add(42, .75);
            BlastShellHours.Add(48, .75);
            BlastShellHours.Add(54, 1);
            BlastShellHours.Add(60, 1);
            BlastShellHours.Add(66, 1);
            BlastShellHours.Add(72, 1.5);
            BlastShellHours.Add(78, 1.5);
            BlastShellHours.Add(84, 1.5);
            BlastShellHours.Add(96, 1.5);
            BlastShellHours.Add(108, 3);
            BlastShellHours.Add(120, 3);
            BlastShellHours.Add(144, 3);
        }


        private void Blast_head_hours_table()
        {
            BlastHeadHours = new Dictionary<double, double>();

            BlastHeadHours.Add(8.625, .05);
            BlastHeadHours.Add(10.75, .05);
            BlastHeadHours.Add(12.75, .05);
            BlastHeadHours.Add(14, .1);
            BlastHeadHours.Add(16, .1);
            BlastHeadHours.Add(18, .1);
            BlastHeadHours.Add(20, .1);
            BlastHeadHours.Add(24, .1);
            BlastHeadHours.Add(30, .15);
            BlastHeadHours.Add(36, .15);
            BlastHeadHours.Add(42, .15);
            BlastHeadHours.Add(48, .15);
            BlastHeadHours.Add(54, .25);
            BlastHeadHours.Add(60, .25);
            BlastHeadHours.Add(66, .25);
            BlastHeadHours.Add(72, .5);
            BlastHeadHours.Add(78, .5);
            BlastHeadHours.Add(84, .5);
            BlastHeadHours.Add(96, .5);
            BlastHeadHours.Add(108, .75);
            BlastHeadHours.Add(120, .75);
            BlastHeadHours.Add(144, .75);
        }


        public double get_girth_seam_hours(string pressure, double size, double shellLength)
        {
            int singleShellLength = 119;
            int maxPipeShellSize = 24;

            if (size <= maxPipeShellSize) { return SmallHeadHours[size]; }

            switch (pressure)
            {
                case "150#":
                    if (shellLength <= singleShellLength)
                        return GirthHours150Single[size];
                    else
                        return GirthHours150Double[size];

                case "250#":
                    if (shellLength <= singleShellLength)
                        return GirthHours250Single[size];
                    else
                        return GirthHours250Double[size];

                case "300#":
                    if (shellLength <= singleShellLength)
                        return GirthHours300Single[size];
                    else
                        return GirthHours300Double[size];

                default:
                        return 0;
                }
        }


        public double get_long_seam_hours(string pressure, double size, double shellLength)
        {
            int singleShellLength = 119;
            int maxPipeShellSize = 24;

            if (size <= maxPipeShellSize) { return 0; }

            switch (pressure)
            {
                case "150#":
                    if (shellLength <= singleShellLength)
                        return LongHours150Single[size];
                    else
                        return LongHours150Double[size];

                case "250#":
                    if (shellLength <= singleShellLength)
                        return LongHours250Single[size];
                    else
                        return LongHours250Double[size];

                case "300#":
                    if (shellLength <= singleShellLength)
                        return LongHours300Single[size];
                    else
                        return LongHours300Double[size];

                default:
                    return 0;
            }
        }


        public double get_pipe_nozzle_hours(double size) { return PipeNozzleHours[size]; }


        public double get_cplg_nozzle_hours(double size) { return CplgNozzleHours[size]; }


        public double get_repad_hours(double nozzleSize) { return RepadHours[nozzleSize]; }


        public double get_weldpad_hours(double size) { return WeldpadHours[size]; }


        public double get_end_plate_hours(double size) { return EndPlateHours[size]; }


        public double get_vortex_breaker_hours(double nozzleSize) { return VortexBreakerHours[nozzleSize]; }


        public double get_distribution_box_hours(double boxSize) { return DistributionBoxHours[boxSize]; }


        public double get_thermosyphon_plate_hours(double vesselSize) { return ThermosyphonPlateHours[vesselSize]; }


        public double get_thermosyphon_pipe_hours(double size) { return ThermosyphonPipeHours[size]; }


        public double get_saddle_web_hours(double vesselSize) { return SaddleWebHours[vesselSize]; }


        public double get_saddle_base_hours(double vesselSize) { return SaddleBaseHours[vesselSize]; }


        public double get_saddle_rib_hours(double vesselSize) { return SaddleRibHours[vesselSize]; }


        public double get_saddle_band_hours(double vesselSize) { return SaddleBandHours[vesselSize]; }


        public double get_leg_hours(double vesselSize) { return LegHours[vesselSize]; }


        public double get_coil_hours(double vesselSize) { return CoilHours[vesselSize]; }


        public double get_angle_clip_hours(double vesselSize) { return AngleClipHours[vesselSize]; }


        public double get_butt_weld_hours(double size) { return ButtWeldHours[size]; }


        public double get_rfwn_hours(double size) { return RFWNWeldHours[size]; }


        public double get_rfso_hours(double size) { return RFSOWeldHours[size]; }


        public double get_pipe_cutting_hours(double pipeSize) { return PipeCuttingHours[pipeSize]; }


        public double get_plasma_hours(double size, double rating, double length) { return 2 * (size + length) / PlasmaFeedRates[rating] / 60; }


        public double get_rolling_hours(double vesselSize) { return RollingHours[vesselSize]; }


        public double get_shell_blast_hours(double vesselSize) { return BlastShellHours[vesselSize]; }


        public double get_head_blast_hours(double vesselSize) { return BlastHeadHours[vesselSize]; }


        public double get_pipe_shell_hours() { return PipeShellHours; }


        public double get_sw_fitting_hours() { return SWfittingHours; }


        public double get_thd_fitting_hours() { return THDfittingHours; }


        public double get_girth_subarc_hours(double girthOD, double rating)
        {
            double bevelAngle = 60; //degrees
            double CSA = rating * rating * Math.Tan(bevelAngle / 2 * Math.PI / 180); // [in^2] cross section area of simple V groove
            double length = girthOD * Math.PI; // [in]
            double volume = CSA * length; // [in^3]
            double steelDensity = 0.284; // [lbs/in^3]
            double weldWeight = volume * steelDensity; // [lbs]
            double girthSubarcDepositionRate = 15; // [lbs/hr]
            double setupTime = 0.35; // [hr]
            
            return setupTime + weldWeight/girthSubarcDepositionRate;
        }


        public double get_long_seam_subarc_hours(double rating, double length)
        {
            double bevelAngle = 60; //degrees
            double CSA = rating * rating * Math.Tan(bevelAngle / 2 * Math.PI / 180); // [in^2] cross section area of simple V groove
            double volume = CSA * length; // [in^3]
            double steelDensity = 0.284; // [lbs/in^3]
            double weldWeight = volume * steelDensity; // [lbs]
            double longSeamSubarcDepositionRate = 10; // [lbs/hr]
            double setupTime = 0.35; // [hr]

            return setupTime + weldWeight / longSeamSubarcDepositionRate;
        }
    }
}
