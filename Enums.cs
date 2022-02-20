namespace ProtoBasket.Common.Model
{
    /// <summary>
    /// Sport match result
    /// </summary>
    public enum eMatchResult
    {
        Invalid,
        Win,
        Draw,
        Lose,
    }

    /// <summary>
    /// Sport integrated score result (Under or Over)
    /// </summary>
    public enum eUnderOverMatchResult
    {
        Invalid,
        Under,
        Over,
    }

    /// <summary>
    /// Sport Category
    /// </summary>
    public enum eMatchCategory
    {
        Invalid,
        Soccer,
        BasketBall,
        BaseBall,
        VallyBall,
    }
}
