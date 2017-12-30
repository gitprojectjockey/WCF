using GeoLibrary.Data.Entities;
using GeoLibrary.Data.Repositories;
using GeoLibrary.Data.RepositoryAbstractions;
using Postal.Catalog.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Postal.Catalog.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PostalStateCodeManager :IPostalStateService
    {
        IStateRepository _stateRepository;

        public PostalStateCodeManager(){}

        public PostalStateCodeManager(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public StateCodeData GetStateCode(string stateAbbrev)
        {
            var state = GetStateRepository().Get(stateAbbrev);
            return new StateCodeData()
            {
                StateId = state.StateId,
                Abbreviation = state.Abbreviation,
                Name = state.Name,
                SSCode = state.SSCode
            };
        }

        public IEnumerable<string> GetStates(bool primaryOnly)
        {
            IEnumerable<State> states = GetStateRepository().Get(primaryOnly);
            if (states == null) return null;
            return states.Select(s => s.Abbreviation).ToList();
        }

        public string Ping(string echo)
        {
            return echo;
        }

        private IStateRepository GetStateRepository() => _stateRepository ?? new StateRepository();
    }
}
