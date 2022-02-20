namespace ProtoBasket.Common.Model
{
    public class HandicapMatch : Match
    {
        #region Properties
        /// <summary>
        /// Handicap Value
        /// </summary>
        public double Handicap { get; set; } = 0;
        #endregion

        #region Functions
        /// <inheritdoc/>
        public override string ToString()
        {
            var prefix = Handicap >= 0 ? "+" : "";
            return $"{base.ToString()} ({prefix}{Handicap})";
        }

        /// <inheritdoc/>
        public override eMatchResult GetResult() => Score?.GetHandicapResult(Handicap) ?? eMatchResult.Invalid;
        #endregion
    }
}
