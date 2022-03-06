using ProtoBasket.Common.Model.Model.Interface;
using System;

namespace ProtoBasket.Common.Model
{
    public class Match : IIdentification, IMatch
    {
        #region Properties
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int Year { get; set; }
        /// <inheritdoc />
        public int ProtoNo { get; set; }
        /// <inheritdoc />
        public int MatchNo { get; set; }
        /// <inheritdoc />
        public DateTime StartTime { get; set; }
        /// <inheritdoc />
        public string Contest { get; set; }
        /// <inheritdoc />
        public eMatchCategory Category { get; set; }
        /// <inheritdoc />
        public string HomeTeam { get; set; }
        /// <inheritdoc />
        public string AwayTeam { get; set; }
        /// <inheritdoc />
        public Score Score { get; set; }
        /// <inheritdoc />
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
