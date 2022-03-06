using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    public class HandicapMatch : Match, IHandicapMatch
    {
        #region Properties
        /// <summary>
        /// Handicap Value
        /// </summary>
        public double? Handicap { get; set; } = 0;
        #endregion

        #region Functions
        /// <inheritdoc/>
        public override string ToString()
        {
            var prefix = Handicap >= 0 ? "+" : "";
            return $"{base.ToString()} ({prefix}{Handicap})";
        }

        /// <inheritdoc/>
        public override eMatchResult GetResult()
        {
            if (Score == null || !Handicap.HasValue)
                return eMatchResult.Invalid;

            return Score.GetHandicapResult(Handicap.Value);
        }
        #endregion
    }
}
