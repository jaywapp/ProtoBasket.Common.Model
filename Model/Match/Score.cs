namespace ProtoBasket.Common.Model
{
    /// <summary>
    /// Sport Match Score
    /// </summary>
    public class Score
    {
        #region Properties
        /// <summary>
        /// Home Team Score
        /// </summary>
        public double Home { get; set; }
        /// <summary>
        /// Away Team Score
        /// </summary>
        public double Away { get; set; }
        #endregion

        #region Functions
        /// <summary>
        /// Get match result
        /// </summary>
        /// <returns></returns>
        public eMatchResult GetResult()
        {
            if (Home > Away)
                return eMatchResult.Win;
            else if (Home < Away)
                return eMatchResult.Lose;

            return eMatchResult.Draw;
        }

        /// <summary>
        /// Get match result (integrated score, under or over)
        /// </summary>
        /// <param name="value">standard value</param>
        /// <returns></returns>
        public eUnderOverMatchResult GetUnderOverResult(double value)
        {
            return Home + Away > value
                ? eUnderOverMatchResult.Over
                : eUnderOverMatchResult.Under;
        }

        /// <summary>
        /// Get match result (handicap)
        /// </summary>
        /// <param name="value">handicap value</param>
        /// <returns></returns>
        public eMatchResult GetHandicapResult(double value)
        {
            // applying handicap value
            var home = Home + value;

            if (home > Away)
                return eMatchResult.Win;
            else if (home < Away)
                return eMatchResult.Lose;

            return eMatchResult.Draw;
        }
        #endregion
    }
}
