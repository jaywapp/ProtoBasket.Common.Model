namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IScorable
    {
        /// <summary>
        /// Home Team Score
        /// </summary>
        double HomeScore { get; set; }
        /// <summary>
        /// Away Team Score
        /// </summary>
        double AwayScore { get; set; }
    }

    public static class ScoreExt
    {
        /// <summary>
        /// Get match result
        /// </summary>
        /// <returns></returns>
        public static eMatchResult GetResult(this IScorable score)
        {
            if (score.HomeScore > score.AwayScore)
                return eMatchResult.Win;
            else if (score.HomeScore < score.AwayScore)
                return eMatchResult.Lose;

            return eMatchResult.Draw;
        }

        /// <summary>
        /// Get match result (integrated score, under or over)
        /// </summary>
        /// <param name="value">standard value</param>
        /// <returns></returns>
        public static eUnderOverMatchResult GetUnderOverResult(this IScorable score, double value)
        {
            return score.HomeScore + score.AwayScore > value
                ? eUnderOverMatchResult.Over
                : eUnderOverMatchResult.Under;
        }

        /// <summary>
        /// Get match result (handicap)
        /// </summary>
        /// <param name="value">handicap value</param>
        /// <returns></returns>
        public static eMatchResult GetHandicapResult(this IScorable score, double value)
        {
            // applying handicap value
            var home = score.HomeScore + value;

            if (home > score.AwayScore)
                return eMatchResult.Win;
            else if (home < score.AwayScore)
                return eMatchResult.Lose;

            return eMatchResult.Draw;
        }
    }
}
