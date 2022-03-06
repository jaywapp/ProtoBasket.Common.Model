using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    public class UnderOverMatch : Match, IUnderOverMatch
    {
        #region Properties
        /// <inheritdoc />
        public double? UnderOver { get; set; } = 0;
        #endregion

        #region Functions
        /// <inheritdoc/>
        public override string ToString() => $"{base.ToString()} (U/O {UnderOver})";
        #endregion
    }
}
