namespace _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze
{
    /// <summary>
    ///     Betaalwijze waarbij niet betaald hoeft te worden.
    /// </summary>
    public class Vrijkaart : IBetaalwijze
    {
        public double Bedrag { get; private set; }
        public bool Betaald { get; private set; }

        public void VoltooiBetaling(Time aankomstTijd, Time vertrekTijd)
        {
            if (vertrekTijd.Day == aankomstTijd.Day && vertrekTijd < aankomstTijd)
            {
                throw new OngeldigVertrekException("De vertrektijd ligt voor de aankomsttijd.");
            }

            if (aankomstTijd.Day != vertrekTijd.Day)
            {
                throw new OngeldigVertrekException("Vrijkaart is alleen geldig op dezelfde dag als de aankomst.");
            }
            Bedrag = 0;
            Betaald = true;
        }
    }
}