using ProtoBasket.Common.Model.Model.Interface;
using System;

namespace ProtoBasket.Common.Model
{
    public class Match : IIdentification
    {
        #region Properties
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Year
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Proto Number
        /// </summary>
        public int ProtoNo { get; set; }
        /// <summary>
        /// Match Number
        /// </summary>
        public int MatchNo { get; set; }
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
        public eMatchCategory Category { get; set; }
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
            var home = !IsStarted() ? HomeTeam : $"{HomeTeam}({Score.Home})";
            var away = !IsStarted() ? AwayTeam : $"{AwayTeam}({Score.Away})";

            return $@"No.{MatchNo} / {StartTime:yy.MM.dd} / {Contest} / {Category} / {home} : {away}";
        }

        /// <summary>
        /// Get match result
        /// </summary>
        /// <returns></returns>
        public virtual eMatchResult GetResult() => Score?.GetResult() ?? eMatchResult.Invalid;
        #endregion
    }
}
