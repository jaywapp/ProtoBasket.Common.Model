namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IUnderOverMatch : IMatch
    {
        /// <summary>
        /// UnderOver Value
        /// </summary>
        double? UnderOver { get; set; }
    }
}
