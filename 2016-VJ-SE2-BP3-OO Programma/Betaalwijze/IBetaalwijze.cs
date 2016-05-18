namespace _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze
{
    /// <summary>
    ///     Interface voor een betaalwijze.
    /// </summary>
    public interface IBetaalwijze
    {
        /// <summary>
        ///     Het te betalen bedrag.
        /// </summary>
        double Bedrag { get; }
        /// <summary>
        ///     Of de betaling uitgevoerd is.
        /// </summary>
        bool Betaald { get; }

        /// <summary>
        ///     Voer de betaling uit.
        /// </summary>
        /// <param name="aankomstTijd">Aankomsttijd</param>
        /// <param name="vertrekTijd">Vertrektijd</param>
        void VoltooiBetaling(Time aankomstTijd, Time vertrekTijd);
    }
}