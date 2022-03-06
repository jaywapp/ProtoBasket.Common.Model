using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    /// <summary>
    /// Sport Match Score
    /// </summary>
    public class Score : IScore
    {
        #region Properties
        /// <inheritdoc/>
        public double Home { get; set; }
        /// <inheritdoc/>
        public double Away { get; set; }
        #endregion
    }
}
