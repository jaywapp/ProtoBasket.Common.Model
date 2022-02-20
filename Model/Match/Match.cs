using System;

namespace ProtoBasket.Common.Model
{
    public class Match
    {
        #region Properties
        /// <summary>
        /// Match Number
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// Match Start Time
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Contest
        /// ex) League, Tournament
        /// </summary>
        public string Contest { get; set; }
        /// <summary>
        /// Category
        /// ex) Soccer, Baseball
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Home Team Name
        /// </summary>
        public string HomeTeam { get; set; }
        /// <summary>
        /// Away Team Name
        /// </summary>
        public string AwayTeam { get; set; }
        /// <summary>
        /// Match Score
        /// </summary>
        public Score Score { get; set; }
        /// <summary>
        /// Match Allocation
        /// </summary>
        public Allocation Allocation { get; set; }
        #endregion

        #region Functions
        /// <summary>
        /// Get status about game is started
        /// </summary>
        /// <returns></returns>
        public bool IsStarted() => StartTime <= DateTime.Now;

        /// <inheritdoc/>
        public override string ToString()
        { 
            return !IsStarted()
                ? $@"No.{No} / {StartTime:yy.MM.dd} / {Contest} / {Category} / {HomeTeam} : {AwayTeam}"
                : $@"No.{No} / {StartTime:yy.MM.dd} / {Contest} / {Category} / {HomeTeam}({Score.Home}) : {AwayTeam}({Score.Away})";
        }

        /// <summary>
        /// Get match result
        /// </summary>
        /// <returns></returns>
        public virtual eMatchResult GetResult() => Score?.GetResult() ?? eMatchResult.Invalid;
        #endregion
    }
}
