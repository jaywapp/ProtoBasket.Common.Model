namespace ProtoBasket.Common.Model
{
    public class Allocation
    {
        #region Properties
        /// <summary>
        /// allocation when home team win (in under/over match, about under score)
        /// </summary>
        public double Win { get; set; }
        /// <summary>
        /// allocation when teams draw (in under/over match, about under score)
        /// </summary>
        public double Draw { get; set; }
        /// <summary>
        /// allocation when away team win (in under/over match, about over score)
        /// </summary>
        public double Lose { get; set; }
        #endregion

        #region Functions
        /// <summary>
        /// Get allocation value about <paramref name="result"/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public double GetValue(eMatchResult result)
        {
            switch (result)
            {
                case eMatchResult.Win:
                    return Win;
                case eMatchResult.Draw:
                    return Draw;
                case eMatchResult.Lose:
                    return Lose;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Get allocation value about <paramref name="result"/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public double GetValue(eUnderOverMatchResult result)
        {
            switch (result)
            {
                case eUnderOverMatchResult.Under:
                    return Win;
                case eUnderOverMatchResult.Over:
                    return Lose;
                default:
                    return 0;
            }
        }
        #endregion
    }
}
