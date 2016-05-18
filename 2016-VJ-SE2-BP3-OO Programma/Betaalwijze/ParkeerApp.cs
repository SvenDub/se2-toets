namespace _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze
{
    /// <summary>
    ///     Betaalwijze waarbij per minuut wordt afgerekend.
    /// </summary>
    public class ParkeerApp : IBetaalwijze
    {
        private readonly Garage _garage;

        public ParkeerApp(Garage garage)
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
                int totalMinutes = (vertrekTijd - aankomstTijd).TotalMinutes;
                Bedrag = totalMinutes/60d*_garage.UurPrijs;
            }
            else
            {
                // Voeg boete toe als er niet op dezelfde dag wordt uitgereden
                int totalMinutes = vertrekTijd.TotalMinutes - aankomstTijd.TotalMinutes +
                                   ((int) vertrekTijd.Day - (int) aankomstTijd.Day)*24*60;
                Bedrag = totalMinutes/60d*_garage.UurPrijs + _garage.UurPrijs*25;
            }
            Betaald = true;
        }
    }
}