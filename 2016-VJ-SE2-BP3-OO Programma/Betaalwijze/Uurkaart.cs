using System;

namespace _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze
{
    /// <summary>
    ///     Betaalwijze waarbij per kwartier wordt afgerekend.
    /// </summary>
    public class Uurkaart : IBetaalwijze
    {
        private readonly Garage _garage;

        public Uurkaart(Garage garage)
        {
            _garage = garage;
        }

        public double Bedrag { get; private set; }
        public bool Betaald { get; private set; }

        public void VoltooiBetaling(Time aankomstTijd, Time vertrekTijd)
        {
            if (vertrekTijd.Day == aankomstTijd.Day && vertrekTijd < aankomstTijd)
            {
                throw new OngeldigVertrekException("De vertrektijd ligt voor de aankomsttijd.");
            }

            if (aankomstTijd.Day == vertrekTijd.Day)
            {
                int totalMinutes = (vertrekTijd - aankomstTijd).TotalMinutes + 1;
                Bedrag = Math.Max(Math.Ceiling(totalMinutes/15d)/4, 1/4d)*_garage.UurPrijs;
            }
            else
            {
                // Voeg boete toe als er niet op dezelfde dag wordt uitgereden
                int totalMinutes = vertrekTijd.TotalMinutes - aankomstTijd.TotalMinutes + 1 +
                                   ((int)vertrekTijd.Day - (int)aankomstTijd.Day)*24*60;
                Bedrag = Math.Max(Math.Ceiling(totalMinutes/15d)/4, 1/4d)*_garage.UurPrijs + _garage.UurPrijs*25;
            }
            Betaald = true;
        }
    }
}