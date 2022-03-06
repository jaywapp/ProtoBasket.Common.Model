using System;

namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IMatch
    {
        /// <summary>
        /// Id
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Year
        /// </summary>
        int Year { get; set; }
        /// <summary>
        /// Proto Number
        /// </summary>
        int ProtoNo { get; set; }
        /// <summary>
        /// Match Number
        /// </summary>
        int MatchNo { get; set; }
        /// <summary>
        /// Match Start Time
        /// </summary>
        DateTime StartTime { get; set; }
        /// <summary>
        /// Contest
        /// ex) League, Tournament
        /// </summary>
        string Contest { get; set; }
        /// <summary>
        /// Category
        /// ex) Soccer, Baseball
        /// </summary>
        eMatchCategory Category { get; set; }
        /// <summary>
        /// Home Team Name
        /// </summary>
        string HomeTeam { get; set; }
        /// <summary>
        /// Away Team Name
        /// </summary>
        string AwayTeam { get; set; }
        /// <summary>
        /// Match Score
        /// </summary>
        Score Score { get; set; }
        /// <summary>
        /// Match Allocation
        /// </summary>
        Allocation Allocation { get; set; }
    }
}
