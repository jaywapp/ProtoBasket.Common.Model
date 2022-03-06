namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IMatch
    {
        /// <summary>
        /// Id
        /// </summary>
        int Id { get; }
        /// <summary>
        /// Year
        /// </summary>
        int Year { get; }
        /// <summary>
        /// Proto Number
        /// </summary>
        int ProtoNo { get; }
        /// <summary>
        /// Match Number
        /// </summary>
        int MatchNo { get; }
        /// <summary>
        /// Sport Game
        /// </summary>
        IGame Game { get; }
        /// <summary>
        /// Allocation
        /// </summary>
        IAllocation Allocation { get; }
    }
}
