using System.Collections.Generic;

namespace _2016_VJ_SE2_BP3_OO_Programma
{
    /// <summary>
    ///     Sorteert parkeerders op kenteken.
    /// </summary>
    public class ParkeerderSorteerder : IComparer<Parkeerder>
    {
        /// <summary>
        ///     Sorteert parkeerders op kenteken.
        /// </summary>
        /// <param name="x">Eerste parkeerder</param>
        /// <param name="y">Tweede parkeerder</param>
        /// <returns>
        ///     -1 als de eerste parkeerder een hogere positie krijgt, 0 als de parkeerders gelijke positie krijgen, 1 als de
        ///     tweede parkeerder een hogere positie krijgt.
        /// </returns>
        public int Compare(Parkeerder x, Parkeerder y) => x.Kenteken.CompareTo(y.Kenteken);
    }
}