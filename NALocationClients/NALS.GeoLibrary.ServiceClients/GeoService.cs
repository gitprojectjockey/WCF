using NALS.GeoLibrary.Contracts;
using System.ServiceModel;
using System.Collections.Generic;

namespace NALS.GeoLibrary.ServiceClient
{
    public class GeoService : ClientBase<IGeoService>, IGeoService
    {
        public ZipCodeData GetZipCode(string zip) => Channel.GetZipCode(zip);

        public IEnumerable<ZipCodeData> GetZips(string state) => Channel.GetZips(state);

        public IEnumerable<ZipCodeData> GetZips(string zip, int range) => Channel.GetZips(zip, range);

        public StateCodeData GetStateCode(string state) => Channel.GetStateCode(state);

        public IEnumerable<StateCodeData> GetStatesCodes(bool primaryOnly) => Channel.GetStatesCodes(primaryOnly);

        public IEnumerable<string> GetStates(bool primaryOnly) => Channel.GetStates(primaryOnly);
    }
}
