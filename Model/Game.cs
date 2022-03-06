using ProtoBasket.Common.Model.Model.Interface;
using System;

namespace ProtoBasket.Common.Model.Model
{
    public class Game : IGame
    {
        #region Properties
        public DateTime Time { get; set; }
        public string Contest { get; set; }
        public eMatchCategory Category { get; set; }
        public string HomeTeam { get; set; }
        public double HomeScore { get; set; } = 0;
        public string AwayTeam { get; set; }
        public double AwayScore { get; set; } = 0;
        #endregion

        #region Functions
        /// <summary>
        /// Get status about game is started
        /// </summary>
        /// <returns></returns>
        public bool IsStarted() => Time <= DateTime.Now;

        /// <inheritdoc/>
        public override string ToString()
        {
            var home = !IsStarted() ? HomeTeam : $"{HomeTeam}({HomeScore})";
            var away = !IsStarted() ? AwayTeam : $"{AwayTeam}({AwayScore})";

            return $@"{Time:yy.MM.dd} / {Contest} / {Category} / {home} : {away}";
        }
        #endregion
    }
}
