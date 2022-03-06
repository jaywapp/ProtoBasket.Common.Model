namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IHandicapMatch : IMatch
    {
        /// <summary>
        /// Handicap Value
        /// </summary>
        double? Handicap { get; set; }
    }
}
