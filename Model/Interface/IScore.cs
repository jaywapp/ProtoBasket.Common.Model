namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IScore
    {
        /// <summary>
        /// Home Team Score
        /// </summary>
        double Home { get; set; }
        /// <summary>
        /// Away Team Score
        /// </summary>
        double Away { get; set; }
    }

    public static class ScoreExt
    {
        /// <summary>
        /// Get match result
        /// </summary>
        /// <returns></returns>
        public static eMatchResult GetResult(this IScore score)
        {
            if (score.Home > score.Away)
                return eMatchResult.Win;
            else if (score.Home < score.Away)
                return eMatchResult.Lose;

            return eMatchResult.Draw;
        }

        /// <summary>
        /// Get match result (integrated score, under or over)
        /// </summary>
        /// <param name="value">standard value</param>
        /// <returns></returns>
        public static eUnderOverMatchResult GetUnderOverResult(this IScore score, double value)
        {
            return score.Home + score.Away > value
                ? eUnderOverMatchResult.Over
                : eUnderOverMatchResult.Under;
        }

        /// <summary>
        /// Get match result (handicap)
        /// </summary>
        /// <param name="value">handicap value</param>
        /// <returns></returns>
        public static eMatchResult GetHandicapResult(this IScore score, double value)
        {
            // applying handicap value
            var home = score.Home + value;

            if (home > score.Away)
                return eMatchResult.Win;
            else if (home < score.Away)
                return eMatchResult.Lose;

            return eMatchResult.Draw;
        }
    }
}
