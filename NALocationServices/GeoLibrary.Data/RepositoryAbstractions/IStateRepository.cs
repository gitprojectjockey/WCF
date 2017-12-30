using GeoLibrary.Core;
using GeoLibrary.Data.Entities;
using System.Collections.Generic;

namespace GeoLibrary.Data.RepositoryAbstractions
{
    public interface IStateRepository : IDataRepository<State>
    {
        State Get(string abbrev);
        IEnumerable<State> Get(bool primaryOnly);
        void UpdateStateCodeBatch(Dictionary<int, string> stateCodeBatch);
    }
}
