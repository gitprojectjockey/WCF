using GeoLibrary.Data.Entities;
using GeoLibrary.Data.Repositories;
using GeoLibrary.Data.RepositoryAbstractions;
using Postal.Catalog.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Postal.Catalog.Services
{
    [ServiceBehavior(Namespace = "http://www.goPostal.com/postalServices" ,InstanceContextMode = InstanceContextMode.PerCall)]
    [ServiceKnownType(typeof(IPostalServiceBase))]
    public class PostalZipCodeManager : IPostalZipService
    {
        IZipCodeRepository _zipcodeRepository;

        public PostalZipCodeManager(){}

        public PostalZipCodeManager(IZipCodeRepository zipcodeRepository)
        {
            _zipcodeRepository = zipcodeRepository;
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


        public string Ping(string echo)
        {
            return echo;
        }

        private IZipCodeRepository GetZipCodeRepository() => _zipcodeRepository ?? new ZipCodeRepository();
        

    }
}
