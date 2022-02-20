using System.Collections.Generic;

namespace ProtoBasket.Common.Model.Model
{
    /// <summary>
    /// Proto 
    /// </summary>
    public class Proto
    {
        #region Properties
        /// <summary>
        /// Proto No
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// Match List
        /// </summary>
        public List<Match> Matches { get; set; } = new List<Match>();
        #endregion
    }
}
