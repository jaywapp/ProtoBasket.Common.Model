using ProtoBasket.Common.Model.Model.Interface;

namespace ProtoBasket.Common.Model
{
    public class Match : IIdentification, IMatch
    {
        #region Properties
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int Year { get; set; }
        /// <inheritdoc />
        public int ProtoNo { get; set; }
        /// <inheritdoc />
        public int MatchNo { get; set; }
        /// <inheritdoc />
        public IAllocation Allocation { get; set; }
        /// <inheritdoc />
        public IGame Game { get; set; }
        #endregion

        #region Functions
        /// <inheritdoc/>
        public override string ToString() => $@"[{MatchNo}] {Game} / {Allocation}";
        #endregion
    }
}
