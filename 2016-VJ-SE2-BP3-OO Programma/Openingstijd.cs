namespace _2016_VJ_SE2_BP3_OO_Programma
{
    /// <summary>
    ///     Een tijdsspanne waarin iets open is.
    /// </summary>
    public class Openingstijd
    {
        public Openingstijd(Time open, Time sluit)
        {
            Open = open;
            Sluit = sluit;
        }

        public Time Open { get; set; }
        public Time Sluit { get; set; }

        public bool IsOpenOp(Time tijd) => 
            tijd.Day == Open.Day // Kan alleen comparen opdezelfde dag
            && tijd.Day == Sluit.Day 
            && tijd < Sluit 
            && tijd >= Open;

        public override string ToString() => $"{Open} - {Sluit}";
    }
}