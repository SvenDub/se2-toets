using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze;

namespace _2016_VJ_SE2_BP3_OO_Programma
{
    public class Garage
    {
        public readonly List<IBetaalwijze> Betalingen = new List<IBetaalwijze>();
        public readonly List<Parkeerder> Bezoekers = new List<Parkeerder>();
        public readonly List<Openingstijd> Openingstijden = new List<Openingstijd>(7);

        public int PlaatsenBezet => Bezoekers.Count(parkeerder => parkeerder.VertrekTijd == null);
        public int PlaatsenTotaal { get; private set; }
        public double UurPrijs { get; private set; }
        public int ZoneCode { get; private set; }

        /// <summary>
        ///     Laad de configuratie van het opgegeven bestand in.
        /// </summary>
        /// <param name="filename">Bestand met de configuratie</param>
        public void LaadConfiguratie(string filename)
        {
            string[] config = File.ReadAllLines(filename);

            if (config.Length < 10) throw new InvalidDataException();

            ZoneCode = int.Parse(config[0]);
            PlaatsenTotaal = int.Parse(config[1]);
            UurPrijs = double.Parse(config[2]);

            for (int i = 3; i < config.Length; i++)
            {
                // Skip lege regels om problemen met new line aan het einde van file te voorkomen
                if (config[i].Length == 0) continue;

                string[] tijden = config[i].Split(';');
                Time open = new Time(tijden[0]);
                Time sluit = new Time(tijden[1]);
                Openingstijden.Add(new Openingstijd(open, sluit));
            }
        }

        /// <summary>
        ///     Controleert of de garage geopend is.
        /// </summary>
        /// <param name="tijd">De te controleren tijd.</param>
        /// <returns>True als de garage geopend is.</returns>
        public bool IsGeopend(Time tijd) => Openingstijden.Any(openingstijd => openingstijd.IsOpenOp(tijd));

        /// <summary>
        ///     Voegt een nieuwe parkeerder toe.
        /// </summary>
        /// <param name="kenteken">Kenteken van de parkeerder.</param>
        /// <param name="tijd">Aankomst tijd.</param>
        /// <returns>True als het toevoegen gelukt is.</returns>
        public bool NieuweParkeerder(string kenteken, Time tijd)
        {
            // Parkeerder mag niet nu al geparkeerd staan
            if (Bezoekers.Any(parkeerder => parkeerder.Kenteken == kenteken && parkeerder.VertrekTijd == null) || PlaatsenBezet >= PlaatsenTotaal ||
                !IsGeopend(tijd))
            {
                return false;
            }
            else
            {
                Bezoekers.Add(new Parkeerder(tijd, kenteken));
                return true;
            }
        }

        /// <summary>
        ///     Laat een parkeerder vertrekken.
        /// </summary>
        /// <param name="kenteken">Kenteken van de parkeerder.</param>
        /// <param name="tijd">Vertrektijd.</param>
        /// <param name="betaalwijze">Betaalwijze</param>
        /// <returns>De vertrokken parkeerder</returns>
        /// <exception cref="OngeldigVertrekException">Als de parkeerder niet mag vertrekken.</exception>
        public Parkeerder ParkeerderVertrekt(string kenteken, Time tijd, IBetaalwijze betaalwijze)
        {
            // Parkeerder moet nu geparkeerd staan
            if (Bezoekers.Any(parkeerder => parkeerder.Kenteken == kenteken && parkeerder.VertrekTijd == null))
            {
                Parkeerder parkeerder = Bezoekers.First(p => p.Kenteken == kenteken && p.VertrekTijd == null);
                parkeerder.Betaal(betaalwijze, tijd);
                return parkeerder;
            }
            else
            {
                throw new OngeldigVertrekException("De opgegeven parkeerder bestaat niet.");
            }
        }

        /// <summary>
        ///     De totale inkomsten van alle vertrokken parkeerders.
        /// </summary>
        /// <returns>De totale inkomsten van alle vertrokken parkeerders.</returns>
        public double Inkomsten() => Bezoekers.Sum(parkeerder => parkeerder.Betaling);

        public override string ToString()
            =>
                $"Betalingen: {Betalingen.Count}, Bezoekers: {Bezoekers.Count}, Openingstijden: {Openingstijden.Count}, PlaatsenBezet: {PlaatsenBezet}, PlaatsenTotaal: {PlaatsenTotaal}, UurPrijs: {UurPrijs}, ZoneCode: {ZoneCode}";
    }
}