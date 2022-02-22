using ProtoBasket.Common.Model.Model.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProtoBasket.Common.Model
{
    /// <summary>
    /// Proto 
    /// </summary>
    public class Proto : IIdentification
    {
        #region Internal Field
        private IDictionary<int, Match> _dic;
        #endregion

        #region Properties
        public int Id { get; set; }
        /// <summary>
        /// Year
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Proto No
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// Match List
        /// </summary>
        public List<Match> Matches { get; set; }
        #endregion

        #region Operator
        public Match this[int id] => Matches.FirstOrDefault(m=>m.Id == id);
        #endregion

        #region Constructor
        public Proto() { }

        public Proto(int year, int no, IEnumerable<Match> matches)
        {
            Id = year * 100 + no;
            Year = year;
            No = no;
            Matches = matches.ToList();

            _dic = matches.ToDictionary(m => m.MatchNo);
        }
        #endregion

        #region Functions
        public bool TryGet(int no, out Match match) => _dic.TryGetValue(no, out match);
        #endregion
    }
}
