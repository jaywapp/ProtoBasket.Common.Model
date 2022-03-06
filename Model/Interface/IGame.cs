using System;

namespace ProtoBasket.Common.Model.Model.Interface
{
    public interface IGame : IScorable
    {
        DateTime Time { get; set; }
        string Contest { get; set; }
        eMatchCategory Category { get; set; }
        string HomeTeam { get; set; }
        string AwayTeam { get; set; }
    }
}
