using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    public class HandicapMatch : Match, IHandicapMatch
    {
        #region Properties
        /// <inheritdoc />
        public double? Handicap { get; set; } = 0;
        #endregion

        #region Functions
        /// <inheritdoc/>
        public override string ToString()
        {
            var prefix = Handicap >= 0 ? "+" : "";
            return $"{base.ToString()} ({prefix}{Handicap})";
        }
        #endregion
    }
}
