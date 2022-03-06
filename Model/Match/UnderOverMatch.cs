using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    public class UnderOverMatch : Match, IUnderOverMatch
    {
        #region Properties
        /// <summary>
        /// UnderOver Value
        /// </summary>
        public double? UnderOver { get; set; } = 0;
        #endregion

        #region Functions
        /// <inheritdoc/>
        public override string ToString() => $"{base.ToString()} (U/O {UnderOver})";

        /// <inheritdoc/>
        public override eMatchResult GetResult()
        {
            if (Score == null || !UnderOver.HasValue)
                return eMatchResult.Invalid;

            var result = Score.GetUnderOverResult(UnderOver.Value);

            switch (result)
            {
                case eUnderOverMatchResult.Under:
                    return eMatchResult.Win;
                case eUnderOverMatchResult.Over:
                    return eMatchResult.Lose;
                default:
                    return eMatchResult.Invalid;
            }
        }
        #endregion
    }
}
