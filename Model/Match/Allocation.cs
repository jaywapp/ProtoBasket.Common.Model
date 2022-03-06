using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    public class Allocation : IAllocation
    {
        #region Properties
        /// <inheritdoc/>
        public double Win { get; set; }
        /// <inheritdoc/>
        public double Draw { get; set; }
        /// <inheritdoc/>
        public double Lose { get; set; }
        #endregion
    }
}
