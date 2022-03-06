namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IAllocation
    {
        /// <summary>
        /// allocation when home team win (in under/over match, about under score)
        /// </summary>
        double Win { get; set; }
        /// <summary>
        /// allocation when teams draw (in under/over match, about under score)
        /// </summary>
        double Draw { get; set; }
        /// <summary>
        /// allocation when away team win (in under/over match, about over score)
        /// </summary>
        double Lose { get; set; }
    }

    public static class AllocationExt
    {
        /// <summary>
        /// Get allocation value about <paramref name="result"/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static double GetValue(this IAllocation allocation, eMatchResult result)
        {
            switch (result)
            {
                case eMatchResult.Win:
                    return allocation.Win;
                case eMatchResult.Draw:
                    return allocation.Draw;
                case eMatchResult.Lose:
                    return allocation.Lose;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Get allocation value about <paramref name="result"/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static double GetValue(this IAllocation allocation, eUnderOverMatchResult result)
        {
            switch (result)
            {
                case eUnderOverMatchResult.Under:
                    return allocation.Win;
                case eUnderOverMatchResult.Over:
                    return  allocation.Lose;
                default:
                    return 0;
            }
        }
    }
}
