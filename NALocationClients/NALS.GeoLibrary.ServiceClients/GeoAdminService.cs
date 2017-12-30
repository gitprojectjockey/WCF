using NALS.GeoLibrary.Contracts;
using System.Collections.Generic;
using System.ServiceModel;

namespace NALS.GeoLibrary.ServiceClient
{
    public class GeoAdminService : ClientBase<IGeoAdminService>, IGeoAdminService
    {
        public void UpdateStateCodeBatch(IEnumerable<StateCodeData> stateCodeBatch) => Channel.UpdateStateCodeBatch(stateCodeBatch);

        public void UpdateZipCity(string zip, string city) => Channel.UpdateZipCity(zip, city);

        public void UpdateZipCity(IEnumerable<ZipCityData> zipCityData) => Channel.UpdateZipCity(zipCityData);
    }
}
