using System.Collections.Generic;
using System.Linq;

namespace ProtoBasket.Common.Model.Repository
{
    public class ProtoRepository
    {
        #region Properties
        public IEnumerable<Proto> Protos { get; }
        #endregion

        #region Constructor
        public ProtoRepository(IEnumerable<Proto> protos)
        {
            Protos = protos;
        }
        #endregion

        #region Operator
        public Proto this[int id] => Protos.FirstOrDefault(p => p.Id == id);
        #endregion
    }
}
