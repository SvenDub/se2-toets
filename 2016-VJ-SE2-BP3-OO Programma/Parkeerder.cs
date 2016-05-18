using _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze;

namespace _2016_VJ_SE2_BP3_OO_Programma
{
    /// <summary>
    ///     Iemand die parkeert.
    /// </summary>
    public class Parkeerder
    {
        public Parkeerder(Time aankomstTijd, string kenteken)
        {
            AankomstTijd = aankomstTijd;
            Kenteken = kenteken;
        }

        public Time AankomstTijd { get; }
        public Time VertrekTijd { get; private set; }
        public double Betaling { get; private set; }
        public string Kenteken { get; }

        /// <summary>
        ///     Voert de betaling uit.
        /// </summary>
        /// <param name="betaalwijze">Betaalwijze.</param>
        /// <param name="vertrekTijd">Vertrektijd.</param>
        public void Betaal(IBetaalwijze betaalwijze, Time vertrekTijd)
        {
            betaalwijze.VoltooiBetaling(AankomstTijd, vertrekTijd);

            if (betaalwijze.Betaald)
            {
                VertrekTijd = vertrekTijd;
                Betaling = betaalwijze.Bedrag;
            }
        }

        public override string ToString() => $"{Kenteken} - {AankomstTijd}";
    }
}