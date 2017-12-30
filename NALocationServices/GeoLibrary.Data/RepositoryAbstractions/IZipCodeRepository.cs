using GeoLibrary.Core;
using GeoLibrary.Data.Entities;
using System.Collections.Generic;

namespace GeoLibrary.Data.RepositoryAbstractions
{
    public interface IZipCodeRepository : IDataRepository<ZipCode>
    {
        ZipCode GetByZip(string zip);
        IEnumerable<ZipCode> GetByState(string state);
        IEnumerable<ZipCode> GetZipsForRange(ZipCode zip, int range);
        void UpdateCityBatch(Dictionary<string, string> cityBatch);
        void UpdateCity(string zip, string city);
    }
}
