using System.Collections.Generic;
using GeoLibrary.Contracts;
using GeoLibrary.Data.RepositoryAbstractions;
using GeoLibrary.Data.Repositories;
using GeoLibrary.Data.Entities;
using System.Linq;
using System.ServiceModel;

namespace GeoLibrary.Services
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerCall)]
    public class GeoManager : IGeoService
    {
        IZipCodeRepository _zipcodeRepsitory;
        IStateRepository _stateRepository;

        public GeoManager(){}
       
        public GeoManager(IZipCodeRepository zipcodeRepository)
        {
            _zipcodeRepsitory = zipcodeRepository;
        }

        public GeoManager(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public GeoManager(IZipCodeRepository zipcodeRepository, IStateRepository stateRepository)
        {
            _zipcodeRepsitory = zipcodeRepository;
            _stateRepository = stateRepository;
        }

        public IEnumerable<string> GetStates(bool primaryOnly)
        {
            IEnumerable<State> states = GetStateRepository().Get(primaryOnly);
            if (states == null) return null;
            return states.Select(s => s.Abbreviation).ToList();
        }

        public ZipCodeData GetZipCode(string zip)
        {
            ZipCodeData zipCodeData = null;

            ZipCode zipCodeEntity = GetZipCodeRepository().GetByZip(zip);
            if (zipCodeEntity != null)
            {
                zipCodeData = new ZipCodeData()
                {
                    City = zipCodeEntity.City,
                    State = zipCodeEntity.State.Abbreviation,
                    ZipCode = zipCodeEntity.Zip
                };
            }
            return zipCodeData;
        }

        public IEnumerable<ZipCodeData> GetZips(string zip, int range)
        {
            ZipCode zipCodeEntity = GetZipCodeRepository().GetByZip(zip);

            if (zipCodeEntity == null) return null;

            IEnumerable<ZipCode> zipCodeEntities = GetZipCodeRepository().GetZipsForRange(zipCodeEntity, range);

            return zipCodeEntities == null
               ? null
               : zipCodeEntities?.Select(entity => new ZipCodeData()
               {
                   ZipCode = entity.Zip,
                   City = entity.City,
                   State = entity.State.Abbreviation
               });
        }

        public IEnumerable<ZipCodeData> GetZips(string state)
        {
            IEnumerable<ZipCode> zipCodeEntities = GetZipCodeRepository().GetByState(state);

            return zipCodeEntities == null
                ? null
                : zipCodeEntities?.Select(entity => new ZipCodeData()
                {
                    ZipCode = entity.Zip,
                    City = entity.City,
                    State = entity.State.Abbreviation
                });
        }
       
        public StateCodeData GetStateCode(string abbrev)
        {
            var state = GetStateRepository().Get(abbrev);
            return new StateCodeData()
            {
                StateId = state.StateId,
                Abbreviation = state.Abbreviation,
                Name = state.Name,
                SSCode = state.SSCode 
            };
        }

        public IEnumerable<StateCodeData> GetStatesCodes(bool primaryOnly)
        {
            var states = GetStateRepository().Get(primaryOnly);
            return states.Select(s => new StateCodeData()
            {
                Abbreviation = s.Abbreviation,
                 Name = s.Name,
                 SSCode = s.SSCode,
                 StateId = s.StateId
            });
        }

        //------------------------------------------------------------------------------------------------------------

        private IZipCodeRepository GetZipCodeRepository()
        {
            return _zipcodeRepsitory ?? new ZipCodeRepository();
        }

        private IStateRepository GetStateRepository()
        {
            return _stateRepository ?? new StateRepository();
        }
    }
}
