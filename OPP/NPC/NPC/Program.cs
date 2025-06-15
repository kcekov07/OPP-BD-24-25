namespace NPC
{
    enum WeatherType
    {
        Windy, Rainy, Snowy, Normal
    }

    class HorseRider
    {
        public string Name { get; }
        public double StaminaFactor { get; }
        public double InitialSpeed { get; }
        public string HorseType { get; }

        public double CurrentSpeed { get; private set; }
        public double DistancePassed { get; private set; } = 0;
        public double ElapsedTime { get; private set; } = 0;
        public bool Finished { get; private set; } = false;

        private WeatherType Weather;
        private double RaceDistance;

        public HorseRider(string name, double stamina, double speed, string horseType)
        {
            Name = name;
            StaminaFactor = stamina;
            InitialSpeed = speed;
            HorseType = horseType;
            CurrentSpeed = speed;
        }

        public void Go(double distance, WeatherType weather)
        {
            RaceDistance = distance;
            Weather = weather;

            int minute = 0;

            while (DistancePassed < RaceDistance)
            {
                Thread.Sleep(1000); 
                minute++;
                ElapsedTime++;

                if (minute % 5 == 0)
                    CurrentSpeed = Math.Max(5, CurrentSpeed * StaminaFactor);

                double effectiveSpeed = ApplyWeatherBuff(CurrentSpeed);
                DistancePassed += effectiveSpeed / 60.0; 

                if (DistancePassed >= RaceDistance)
                    Finished = true;
            }
        }

        private double ApplyWeatherBuff(double speed)
        {
            if (HorseType == "BlackLightning")
            {
                if (Weather == WeatherType.Windy) return speed * 0.9;
                if (Weather == WeatherType.Rainy) return speed * 1.1;
            }
            if (HorseType == "WhiteFrost" && Weather == WeatherType.Snowy)
                return speed * 1.1;
            if (HorseType == "BrownWind" && Weather == WeatherType.Windy)
                return speed * 1.05;

            return speed;
        }

        public double Progress => DistancePassed / RaceDistance;
        public double AverageSpeed => (DistancePassed / ElapsedTime) * 60;
    }

    class Program
    {
        static List<HorseRider> riders = new List<HorseRider>();
        static List<Thread> threads = new List<Thread>();
        static double raceDistance;
        static WeatherType weather;

        static void Main()
        {
            
            var input = Console.ReadLine().Split();
            raceDistance = double.Parse(input[0]);
            weather = Enum.Parse<WeatherType>(input[1], ignoreCase: true);

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "GO" || line == "Go" || line == "go") break;

                var parts = line.Split();
                var rider = new HorseRider(parts[0],
                                            double.Parse(parts[1]),
                                            double.Parse(parts[2]),
                                            parts[3]);
                riders.Add(rider);
            }

            
            for (int i = 5; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Race Start {i}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("<--Launch-->");
            Thread.Sleep(1000);

            
            foreach (var rider in riders)
            {
                var thread = new Thread(() => rider.Go(raceDistance, weather));
                thread.Start();
                threads.Add(thread);
            }

            
            bool finished = false;
            while (!finished)
            {
                Console.Clear();
                Console.WriteLine($"Elapsed Time: {riders.First().ElapsedTime:F0} min:\n");

                foreach (var rider in riders.OrderByDescending(r => r.DistancePassed))
                {
                    Console.WriteLine($"{rider.Name}|Speed={rider.CurrentSpeed:F1} kmph|Distance={rider.DistancePassed:F2}|Progress={(rider.Progress * 100):F1}%");
                }

                if (riders.Any(r => r.Finished))
                    finished = true;

                Thread.Sleep(1000);
            }

            
            foreach (var thread in threads)
                thread.Join();

            Console.Clear();
            Console.WriteLine("--AWARDING--\n");

            var ranked = riders.OrderByDescending(r => r.DistancePassed).ToList();
            if (ranked.Count > 0)
                Console.WriteLine($"GOLD - {ranked[0].Name} AverageSpeed={ranked[0].AverageSpeed:F0} km/h");
            if (ranked.Count > 1)
                Console.WriteLine($"SILVER - {ranked[1].Name} AverageSpeed={ranked[1].AverageSpeed:F0} km/h");

            if (ranked.Count > 2)
            {
                var rest = ranked.Skip(2).Select(r => r.Name);
                Console.WriteLine("CONGRATULATIONS FOR " + string.Join(", ", rest));
            }
        }
    }
}
